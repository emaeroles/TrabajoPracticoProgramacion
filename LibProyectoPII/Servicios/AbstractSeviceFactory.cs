
namespace LibProyectoPII
{
    public abstract class AbstractServiceFactory
    {
        public abstract IGestorUsuario CrearGestorUsuario();
        public abstract IGestorCamion CrearGestorCamion();
        public abstract IGestorViaje CrearGestorViaje();
    }
}
