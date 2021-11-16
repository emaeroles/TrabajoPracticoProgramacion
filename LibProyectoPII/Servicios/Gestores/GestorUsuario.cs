using System.Collections.Generic;

namespace LibProyectoPII
{
    public class GestorUsuario : IGestorUsuario
    {
        private IDaoUsuario daoUsuario;

        public GestorUsuario(AbstractDaoFactory daoFactory)
        {
            daoUsuario = daoFactory.CrearDaoUsuario();
        }

        public bool CreateUpdate(Usuario usuario, CreUpReDe que)
        {
            return daoUsuario.CreateUpdate(usuario, que);
        }
        public List<Usuario> ListaUsuarios(TiposUsers tipo)
        {
            return daoUsuario.ListaUsuarios(tipo);
        }
        public bool Logueo(string userName, string password)
        {
            return daoUsuario.Logueo(userName, password);
        }
        public int ProximoId()
        {
            return daoUsuario.ProximoId();
        }
        public bool Baja(int id)
        {
            return daoUsuario.Baja(id);
        }
    }
}
