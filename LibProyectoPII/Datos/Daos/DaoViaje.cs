using System;
using System.Collections.Generic;
using System.Data;

namespace LibProyectoPII
{
    class DaoViaje : IDaoViaje
    {
        public bool CreateUpdate(Viaje viaje, CreUpReDe que)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id_viaje", viaje.Id);
            
            if (que == CreUpReDe.Create)
            {
                parametros.Add("@id_camion", viaje.IdCamion);
                parametros.Add("@origen", viaje.Origen);
                parametros.Add("@destino", viaje.Destino);
            }
            
            List<Dictionary<string, object>> lDetalles = new List<Dictionary<string, object>>();

            foreach (Carga carga in viaje.LCargas)
            {
                Dictionary<string, object> parametrosDetalle = new Dictionary<string, object>();
                parametrosDetalle.Add("@id_viaje", carga.IdViaje);
                parametrosDetalle.Add("@id_carga", carga.Id);
                parametrosDetalle.Add("@peso", carga.Peso);
                parametrosDetalle.Add("@id_tipo_carga", carga.TipoCarga);
                parametrosDetalle.Add("@cargado", carga.Cargado);

                lDetalles.Add(parametrosDetalle);
            }

            if (que == CreUpReDe.Create)
                return HelperDao.ObtenerInstancia().EjectProcMaestroDetalle(parametros, lDetalles, 
                                                                            "PA_INSERTAR_VIAJE", "PA_INSERT_CARGA");
            else
                return HelperDao.ObtenerInstancia().EjectProcMaestroDetalle(parametros, lDetalles, 
                                                                            "PA_UPDATE_VIAJE", "PA_INSERT_CARGA");
        }

        public int ProximoId()
        {
            DataTable tabla = new DataTable();
            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_PROXIMO_ID_VIAJE");
            int id = Convert.ToInt32(tabla.Rows[0][0]) + 1;
            return id;
        }

        public bool FinalizarViaje(int id, DateTime fecha)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);
            parametros.Add("@fecha_llagada", fecha);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_FINALIZAR_VIAJE", parametros);
        }

        public bool Partir(int id, DateTime fecha)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);
            parametros.Add("@fecha_salida", fecha);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_PARTIR_VIAJE", parametros);
        }

        public List<Carga> ListaCargas(int id)
        {
            List<Carga> lCargas = new List<Carga>();
            DataTable tabla = new DataTable();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id_viaje", id);

            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_CARGAS", parametros);

            foreach (DataRow row in tabla.Rows)
            {
                Carga carga = new Carga(Convert.ToInt32(row["id_carga"]),
                                        Convert.ToInt32(row["id_viaje"]),
                                        Convert.ToDecimal(row["peso"]),
                                        (TiposDeCarga)row["id_tipo_carga"],
                                        Convert.ToBoolean(row["cargado"]));

                lCargas.Add(carga);
            }
            return lCargas;
        }

        public List<Viaje> ListaViajes()
        {
            List<Viaje> lViajes = new List<Viaje>();
            DataTable tabla = new DataTable();

            tabla = HelperDao.ObtenerInstancia().EjectProcRead("PA_OBTENER_VIAJES");

            foreach (DataRow row in tabla.Rows)
            {
                bool finalizado;

                if (Convert.ToInt32(row["finalizado"]) == 1)
                    finalizado = true;
                else
                    finalizado = false;

                Viaje Viaje = new Viaje(Convert.ToInt32(row["id_viaje"]),
                                        Convert.ToInt32(row["id_camion"]),
                                        Convert.ToString(row["origen"]),
                                        Convert.ToString(row["destino"]),
                                        finalizado,
                                        Convert.ToDateTime(row["fecha_salida"]),
                                        Convert.ToDateTime(row["fecha_llegada"]));

                lViajes.Add(Viaje);

            }
            return lViajes;
        }

        public bool EliminarCarga(int idViaje, int idCarga)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id_viaje", idViaje);
            parametros.Add("@id_carga", idCarga);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_DELETE_CARGA", parametros);
        }

        public bool DescragarCarga(int idViaje, int idCarga)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id_viaje", idViaje);
            parametros.Add("@id_carga", idCarga);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_DESCARGAR_CARGA", parametros);
        }

        public bool DescragarCamion(int idViaje)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@id_viaje", idViaje);
            return HelperDao.ObtenerInstancia().EjectProcSimple("PA_DESCARGAR_CAMION", parametros);
        }
    }
}
