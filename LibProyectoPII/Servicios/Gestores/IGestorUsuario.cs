using System.Collections.Generic;

namespace LibProyectoPII
{
    public interface IGestorUsuario
    {
        bool CreateUpdate(Usuario usuario, CreUpReDe que);
        List<Usuario> ListaUsuarios(TiposUsers tipo);
        bool Logueo(string userName, string password);
        int ProximoId();
        bool Baja(int id);
    }
}
