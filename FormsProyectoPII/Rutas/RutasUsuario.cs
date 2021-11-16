
namespace FormsProyectoPII
{
    class RutasUsuario : Rutas
    {
        public string Id { get; set; }
        public string Alta { get; set; }
        public string Actualizar { get; set; }
        public string Baja { get; set; }
        public string Camioneros { get; set; }
        public string Todos { get; set; }
        public string Logueo { get; set; }

        public RutasUsuario()
        {
            Id = "https://" + host + "/api/Usuario/Id";
            Alta = "https://" + host + "/api/Usuario/Alta";
            Actualizar = "https://" + host + "/api/Usuario/Actualizar";
            Baja = "https://" + host + "/api/Usuario/Baja";
            Camioneros = "https://" + host + "/api/Usuario/Camioneros";
            Todos = "https://" + host + "/api/Usuario/Todos";
            Logueo = "https://" + host + "/api/Usuario/Logueo";
        }
    }
}
