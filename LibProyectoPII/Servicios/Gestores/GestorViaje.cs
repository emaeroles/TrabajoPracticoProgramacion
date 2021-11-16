using System;
using System.Collections.Generic;

namespace LibProyectoPII
{
    public class GestorViaje : IGestorViaje
    {
        private IDaoViaje daoViaje;

        public GestorViaje(AbstractDaoFactory daoFactory)
        {
            daoViaje = daoFactory.CrearDaoViaje();
        }

        public bool CreateUpdate(Viaje viaje, CreUpReDe que)
        {
            return daoViaje.CreateUpdate(viaje, que);
        }
        public int ProximoId()
        {
            return daoViaje.ProximoId();
        }
        public bool FinalizarViaje(int id, DateTime fecha)
        {
            return daoViaje.FinalizarViaje(id, fecha);
        }
        public bool Partir(int id, DateTime fecha)
        {
            return daoViaje.Partir(id, fecha);
        }
        public List<Viaje> ListaViajes()
        {
            return daoViaje.ListaViajes();
        }

        public List<Carga> ListaCargas(int id)
        {
            return daoViaje.ListaCargas(id);
        }

        public bool EliminarCarga(int idViaje, int idCarga)
        {
            return daoViaje.EliminarCarga(idViaje, idCarga);
        }
        public bool DescargarCarga(int idViaje, int idCarga)
        {
            return daoViaje.DescragarCarga(idViaje, idCarga);
        }
        public bool DescargarCamion(int idViaje)
        {
            return daoViaje.DescragarCamion(idViaje);
        }
        
    }
}
