using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompartido
{
    [Table("ProductoAPilas")]
    public class ProductoAPilas: Producto
    {
        // Constructor sin parámetros requerido por Entity Framework
        public ProductoAPilas() { }

        // Constructor con parámetros para uso en la lógica de negocio
        public ProductoAPilas(string nombre, decimal precio, int cantidad, string descripcion, int provid, int cantpilas, TipoPilas tipo)
            : base(nombre, precio, cantidad, descripcion, provid)
        {
            CantPilas = cantpilas;
            Tipo = tipo;
        }

        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser un número entero positivo mayor a 0.")]
        public int CantPilas { get; set; }

        [Required(ErrorMessage = "El tipo de pila es obligatorio.")]
        public TipoPilas Tipo { get; set; }
      
        public override string ObtenerDescripcionCompleta()
        {
            return $"{base.ObtenerDescripcionCompleta()}, Cantidad Pilas: {CantPilas}, Tipo de Pilas: {Tipo}";
        }
    }
}
