
namespace LibProyectoPII
{
    public class DaoFactory : AbstractDaoFactory
    {
        public override IDaoUsuario CrearDaoUsuario()
        {
            return new DaoUsuario();
        }
        public override IDaoCamion CrearDaoCamion()
        {
            return new DaoCamion();
        }
        public override IDaoViaje CrearDaoViaje()
        {
            return new DaoViaje();
        }
    }
}
