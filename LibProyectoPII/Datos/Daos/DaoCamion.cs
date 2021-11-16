using System;
using System.Collections.Generic;
using System.Data;

namespace LibProyectoPII
{
    class DaoCamion : IDaoCamion
    {

        public bool CreateUpdate(Camion camion, CreUpReDe que)
        {
            Dictionary<string, object> parametrosMaestro = new Dictionary<string, object>();
            parametrosMaestro.Add("@id", camion.Id);
            parametrosMaestro.Add("@descripcion", camion.Descripcion);
            parametrosMaestro.Add("@patente", camion.Patente);
            parametrosMaestro.Add("@id_camionero", camion.IdCamionero);
            parametrosMaestro.Add("@estado", camion.Estado);
            parametrosMaestro.Add("@peso_maximo", camion.PesoMaximo);
            parametrosMaestro.Add("@situado", camion.Situado);

            if (que == CreUpReDe.Create)
                return HelperDao.ObtenerInstancia().EjectProcSimple("PA_INSERTAR_CAMION", parametrosMaestro);
            else
                return HelperDao.ObtenerInstancia().EjectProcSimple("PA_UPDATE_CAMION", parametrosMaestro);
        }

        public int ProximoId()
        {
            DataTable tabla = new DataTable();
            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_PROXIMO_ID_CAMION");
            int id = Convert.ToInt32(tabla.Rows[0][0]) + 1;
            return id;
        }

        public bool CambioEstadoSutuado(int id, Estados estado, string situado)
        {
            Dictionary<string, object> parametrosMaestro = new Dictionary<string, object>();
            parametrosMaestro.Add("@id_camion", id);
            parametrosMaestro.Add("@estado", estado);
            parametrosMaestro.Add("@situado", situado);

            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_ESTADO_SITUADO", parametrosMaestro);
        }

        public Camion GetCamion(int id)
        {
            DataTable tabla = new DataTable();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);

            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_CONSULTAR_CAMION_ID", parametros);

            Camion camion = new Camion(Convert.ToInt32(tabla.Rows[0]["id_camion"]),
                                       Convert.ToString(tabla.Rows[0]["descripcion"]),
                                       Convert.ToString(tabla.Rows[0]["patente"]),
                                       Convert.ToInt32(tabla.Rows[0]["id_camionero"]),
                                       (Estados)tabla.Rows[0]["estado"],
                                       Convert.ToDecimal(tabla.Rows[0]["peso_maximo"]),
                                       Convert.ToString(tabla.Rows[0]["situado"]));
            
            return camion;
        }

        public List<Camion> ListaCamiones(Camiones cuales)
        {
            List<Camion> lCamiones = new List<Camion>();
            DataTable tabla = new DataTable();

            if (cuales == Camiones.Libres)
                tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_CAMIONES_LIBRES");
            else
                tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_CAMIONES");

            foreach (DataRow row in tabla.Rows)
            {

                Camion camion = new Camion(Convert.ToInt32(row["id_camion"]),
                                           Convert.ToString(row["descripcion"]),
                                           Convert.ToString(row["patente"]),
                                           Convert.ToInt32(row["id_camionero"]),
                                           (Estados)row["estado"],
                                           Convert.ToDecimal(row["peso_maximo"]),
                                           Convert.ToString(row["situado"]));

                lCamiones.Add(camion);
            }
            return lCamiones;
        }

        public bool Baja(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_BAJA_CAMION", parametros);
        }
    }
}
