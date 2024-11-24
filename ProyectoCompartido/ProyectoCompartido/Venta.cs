using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace ProyectoCompartido
{
    public class Venta
    {      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        [ForeignKey("Producto")]
        public int IdProducto { get; set; }

        [JsonIgnore]
        public virtual Producto? Prod { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser un número entero positivo mayor a 0.")]
        public int CantidadVendida { get; set; }

        [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "El valor debe ser mayor a 0.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioVenta { get; set; }

        [NotMapped]
        public decimal TotalVenta => CantidadVendida * PrecioVenta;  // Propiedad calculada
        public Venta(DateTime fecha, int idProducto, int cantidadVendida, decimal precioVenta, Producto? producto)
        {
            Fecha = fecha;
            IdProducto = idProducto;
            CantidadVendida = cantidadVendida;
            PrecioVenta = precioVenta;
            Prod = producto;
        }
        public Venta() { }
    }
}
