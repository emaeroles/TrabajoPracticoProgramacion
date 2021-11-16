
namespace LibProyectoPII
{
    public class ServiceFactory : AbstractServiceFactory
    {
        public override IGestorUsuario CrearGestorUsuario()
        {
            return new GestorUsuario(new DaoFactory());
        }
        public override IGestorCamion CrearGestorCamion()
        {
            return new GestorCamion(new DaoFactory());
        }
        public override IGestorViaje CrearGestorViaje()
        {
            return new GestorViaje(new DaoFactory());
        }
    }
}
