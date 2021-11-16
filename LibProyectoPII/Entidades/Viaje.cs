using System;
using System.Collections.Generic;

namespace LibProyectoPII
{
    public class Viaje
    {
        public int Id { get; set; }
        public int IdCamion { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public bool Finalizado { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public List<Carga> LCargas { get; set; }

        public Viaje()
        {
            LCargas = new List<Carga>();
        }

        public Viaje(int id, int idCamion, string origen, string destino)
        {
            Id = id;
            IdCamion = idCamion;
            Origen = origen;
            Destino = destino;
            LCargas = new List<Carga>();
        }

        public Viaje(int id, int idCamion, string origen, string destino, bool finalizado, DateTime fechaSalida, DateTime fechaLlegada)
        {
            Id = id;
            IdCamion = idCamion;
            Origen = origen;
            Destino = destino;
            Finalizado = finalizado;
            FechaSalida = fechaSalida;
            FechaLlegada = fechaLlegada;
            LCargas = new List<Carga>();
        }

        public void AgregarDetalle(Carga carga)
        {
            LCargas.Add(carga);
        }

        public void QuitarDetalle(int id)
        {
            foreach (Carga c in LCargas)
            {
                if (c.Id == id)
                {
                    c.Cargado = false;
                }
            }
        }

        public decimal CalcPesoCargas()
        {
            decimal pesoCargas = 0;
            foreach (Carga c in LCargas)
            {
                if (c.Cargado)
                    pesoCargas += c.Peso;
            }
            return pesoCargas;
        }

        public int UltimoId()
        {
            int num = 0;
            foreach (Carga carga in LCargas)
            {
                if (carga.Id > num)
                {
                    num = carga.Id;
                }
            }
            return num + 1;
        }
    }
}
