namespace VentasParcial.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; } 
        public int? MarcaId { get; set; }  
        public string Modelo { get; set; } = null;  
        public int Año { get; set; }
        public int? Cantidad_De_Puertas { get; set; }

        public virtual Marca? Marca { get; set; }

        public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
    }
}
