using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ProyectoCompartido
{
    public class Producto
    {
        public Producto() { }

        public Producto(string nombre, decimal precio, int cantidad, string descripcion, int provId)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Descripcion = descripcion;
            ProveedorID = provId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "El valor debe ser mayor a 0.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; } 

        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser un número entero positivo mayor o igual a 0.")]
        public int Cantidad { get; set; } 

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        [ForeignKey("Proveedor")]
        public int ProveedorID { get; set; }

        [JsonIgnore] // Ignora la propiedad de navegacion
        public virtual Proveedor? Proveedor { get; set; }

        public virtual string ObtenerDescripcionCompleta()
        {
            return $"{Nombre}: {Descripcion}, Precio:{Precio}, Cantidad: {Cantidad}";
        }
    }
}