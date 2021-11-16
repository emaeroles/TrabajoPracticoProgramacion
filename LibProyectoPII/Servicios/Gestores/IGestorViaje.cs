using System;
using System.Collections.Generic;

namespace LibProyectoPII
{
    public interface IGestorViaje
    {
        bool CreateUpdate(Viaje viaje, CreUpReDe que);
        int ProximoId();
        bool FinalizarViaje(int id, DateTime fecha);
        bool Partir(int id, DateTime fecha);
        List<Viaje> ListaViajes();

        List<Carga> ListaCargas(int id);

        bool EliminarCarga(int idViaje, int idCarga);
        bool DescargarCarga(int idViaje, int idCarga);
        bool DescargarCamion(int idViaje);
    }
}
