using System.Collections.Generic;

namespace LibProyectoPII
{
    public class GestorCamion : IGestorCamion
    {
        private IDaoCamion daoCamion;

        public GestorCamion(AbstractDaoFactory daoFactory)
        {
            daoCamion = daoFactory.CrearDaoCamion();
        }

        public bool CreateUpdate(Camion camion, CreUpReDe que)
        {
            return daoCamion.CreateUpdate(camion, que);
        }
        public List<Camion> ListaCamiones(Camiones cuales)
        {
            return daoCamion.ListaCamiones(cuales);
        }
        public int ProximoId()
        {
            return daoCamion.ProximoId();
        }
        public bool Baja(int id)
        {
            return daoCamion.Baja(id);
        }
        public bool CambioEstadoSutuado(int id, Estados estado, string situado)
        {
            return daoCamion.CambioEstadoSutuado(id, estado, situado);
        }
        public Camion GetCamion(int id)
        {
            return daoCamion.GetCamion(id);
        }
    }
}
