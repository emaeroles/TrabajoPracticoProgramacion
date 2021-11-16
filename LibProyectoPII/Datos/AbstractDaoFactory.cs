
namespace LibProyectoPII
{
    public abstract class AbstractDaoFactory
    {
        public abstract IDaoUsuario CrearDaoUsuario();
        public abstract IDaoCamion CrearDaoCamion();
        public abstract IDaoViaje CrearDaoViaje();
    }
}
