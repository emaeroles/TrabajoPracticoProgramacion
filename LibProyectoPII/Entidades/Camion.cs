
using System;

namespace LibProyectoPII
{
    public class Camion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Patente { get; set; }
        public int IdCamionero { get; set; }
        public Estados Estado { get; set; }
        public decimal PesoMaximo { get; set; }
        public string Situado { get; set; }

        public Camion()
        {
            Id = 0;
            Descripcion = "";
            Patente = "";
            IdCamionero = 0;
            Estado = Estados.Disponible;
            PesoMaximo = 0;
            Situado = "";
        }

        public Camion(int id, string descripcion, string patente, int idCamionero, Estados estado, decimal pesoMaximo, string situado)
        {
            Id = id;
            Descripcion = descripcion;
            Patente = patente;
            IdCamionero = idCamionero;
            Estado = estado;
            PesoMaximo = pesoMaximo;
            Situado = situado;
        }

        public decimal CalcCargaResatante(decimal pesoCargas)
        {
            return PesoMaximo - pesoCargas;
        }

        public decimal CalcPorcentageCarga(decimal pesoCargas)
        {
            decimal result = (pesoCargas * 100 / PesoMaximo);
            return result;
        }
    }
}
