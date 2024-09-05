using System.ComponentModel.DataAnnotations;

namespace VentasParcial.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public required string Nombre { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
    }
