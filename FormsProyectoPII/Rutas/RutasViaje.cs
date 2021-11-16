
namespace FormsProyectoPII
{
    class RutasViaje : Rutas
    {
        public string Id { get; set; }
        public string Alta { get; set; }
        public string Actualizar { get; set; }
        public string Finalizar { get; set; }
        public string Viajes { get; set; }
        public string Partir { get; set; }
        public string GetCargas { get; set; }
        public string DescargarCarga { get; set; }
        public string DescargarCamion { get; set; }

        public RutasViaje()
        {
            Id = "https://" + host + "/api/Viaje/Id";
            Alta = "https://" + host + "/api/Viaje/Alta";
            Actualizar = "https://" + host + "/api/Viaje/Actualizar";
            Finalizar = "https://" + host + "/api/Viaje/Finalizar";
            Viajes = "https://" + host + "/api/Viaje/Viajes";
            Partir = "https://" + host + "/api/Viaje/Partir";
            GetCargas = "https://" + host + "/api/Viaje/Cargas";
            DescargarCarga = "https://" + host + "/api/Viaje/DescargarCarga";
            DescargarCamion = "https://" + host + "/api/Viaje/DescargarCamion";
        }
    }
}
