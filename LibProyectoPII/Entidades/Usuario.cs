
namespace LibProyectoPII
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int TipoUsuario { get; set; }
        public string Documento { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Usuario()
        {
            Id = 0;
            Nombre = "";
            Apellido = "";
            Telefono = "";
            TipoUsuario = 0;
            Documento = "";
            UserName = "";
            Password = "";
        }

        public Usuario(int id, string nombre, string apellido, string telefono, 
                       string documento, int tipoUsuario, string userName, string password)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            TipoUsuario = tipoUsuario;
            Documento = documento;
            UserName = userName;
            Password = password;
        }

        public Usuario(int id, string nombre, string apellido, string telefono,
                       string documento, int tipoUsuario)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Documento = documento;
            TipoUsuario = tipoUsuario;
        }
    }
}
