using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibProyectoPII
{
    class HelperDao
    {
        private static HelperDao instancia;
        SqlConnection conexion;

        private HelperDao()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-H8R3LUT;Initial Catalog=TRANSPORTE_CARGAS;Integrated Security=True");
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();

            return instancia;
        }

        public DataTable EjectProcRead(string procedimiento)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                tabla.Load(comando.ExecuteReader());
            }
            catch
            {
                 
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }

        public DataTable EjectProcRead(string procedimiento, Dictionary<string, object> parametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                foreach (var item in parametros)
                {
                    comando.Parameters.AddWithValue(item.Key, item.Value);
                }

                tabla.Load(comando.ExecuteReader());
            }
            catch
            {

            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }

        public bool EjectProcSimple(string procedimiento, Dictionary<string, object> parametros)
        {
            bool salida;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                foreach (var item in parametros)
                {
                    comando.Parameters.AddWithValue(item.Key, item.Value);
                }

                comando.ExecuteNonQuery();
                salida = true;
        }
            catch
            {
                salida = false;
            }
            finally
            {
                conexion.Close();
            }
            return salida;
        }

        public bool EjectProcMaestroDetalle(Dictionary<string, object> parametrosMaestro, 
                                            List<Dictionary<string, object>> lParametrosDetalle,
                                            string procedimientoMaestro,
                                            string procedimientoDetalle)
        {
            SqlTransaction t = null;
            bool salida;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comandoMaestro = new SqlCommand(procedimientoMaestro, conexion, t);
                comandoMaestro.CommandType = CommandType.StoredProcedure;

                foreach (var item in parametrosMaestro)
                {
                    comandoMaestro.Parameters.AddWithValue(item.Key, item.Value);
                }

                comandoMaestro.ExecuteNonQuery();

                foreach (Dictionary<string, object> detalle in lParametrosDetalle)
                {
                    SqlCommand comandoDetalle = new SqlCommand(procedimientoDetalle, conexion, t);
                    comandoDetalle.CommandType = CommandType.StoredProcedure;

                    foreach (var item in detalle)
                    {
                        comandoDetalle.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    comandoDetalle.ExecuteNonQuery();
                }
                t.Commit();
                salida = true;
            }
            catch
            {
                t.Rollback();
                salida = false;
            }
            finally
            {
                conexion.Close();
            }
            return salida;
        }
    }
}
