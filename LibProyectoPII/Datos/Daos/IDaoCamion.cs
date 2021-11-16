using System.Collections.Generic;

namespace LibProyectoPII
{
    public interface IDaoCamion
    {
        bool CreateUpdate(Camion camion, CreUpReDe que);
        List<Camion> ListaCamiones(Camiones cuales);
        int ProximoId();
        bool Baja(int id);
        bool CambioEstadoSutuado(int id, Estados estado, string situado);
        Camion GetCamion(int id);
    }
}
