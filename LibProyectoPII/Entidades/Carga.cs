using System.Text.Json.Serialization;

namespace LibProyectoPII
{
    public class Carga
    {
        public int Id { get; set; }
        public int IdViaje { get; set; }
        public decimal Peso { get; set; }
        public TiposDeCarga TipoCarga { get; set; }
        public bool Cargado { get; set; }

        public Carga()
        {
            Id = 0;
            IdViaje = 0;
            Peso = 0;
            TipoCarga = TiposDeCarga.Packing;
            Cargado = false;
        }

        public Carga(int id, int idViaje, decimal peso, TiposDeCarga tipoCarga, bool cargado)
        {
            Id = id;
            IdViaje = idViaje;
            Peso = peso;
            TipoCarga = tipoCarga;
            Cargado = cargado;
        }

        public Carga(int id, int idViaje, TiposDeCarga tipoCarga, decimal peso)
        {
            Id = id;
            IdViaje = idViaje;
            Peso = peso;
            TipoCarga = tipoCarga;
            Cargado = true;
        }
    }
}
