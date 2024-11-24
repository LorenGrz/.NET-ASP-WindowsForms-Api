using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompartido
{
    [Table("ProductoElectronico")]
    public class ProductoElectronico : Producto
    {
        [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "El valor debe ser mayor a 0.")]
        public decimal Voltaje { get; set; }

        public bool Transformador { get; set; }

        public ProductoElectronico()
        { }
        public ProductoElectronico(string nombre,decimal precio,int cantidad,string descripcion, int provId, decimal voltaje, bool transformador): base(nombre,precio,cantidad,descripcion,provId)
        {
            Transformador = transformador;
            Voltaje = voltaje;
        }
        public override string ObtenerDescripcionCompleta()
        {
            return $"{base.ObtenerDescripcionCompleta()}, Voltaje:{Voltaje}, Utiliza Transformador:{Transformador}";
        }
    }
}
