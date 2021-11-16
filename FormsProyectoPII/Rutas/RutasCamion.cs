
namespace FormsProyectoPII
{
    class RutasCamion : Rutas
    {
        public string Id { get; set; }
        public string Alta { get; set; }
        public string Actualizar { get; set; }
        public string Baja { get; set; }
        public string Libres { get; set; }
        public string Todos { get; set; }
        public string EstSit { get; set; }
        public string CamionById { get; set; }

        public RutasCamion()
        {
            Id = "https://" + host + "/api/Camion/Id";
            Alta = "https://" + host + "/api/Camion/Alta";
            Actualizar = "https://" + host + "/api/Camion/Actualizar";
            Baja = "https://" + host + "/api/Camion/Baja";
            Libres = "https://" + host + "/api/Camion/CamionesLibres";
            Todos = "https://" + host + "/api/Camion/Camiones";
            EstSit = "https://" + host + "/api/Camion/CambioEstadoSituado";
            CamionById = "https://" + host + "/api/Camion/Camion";
        }
    }
}
