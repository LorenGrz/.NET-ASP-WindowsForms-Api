using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_Producto
    {
        bool ValidarProducto(Producto producto);
        List<Producto> ObtenerProductos();
        List<Producto> ObtenerProductosPorProveedor(int idProveedor);
        Producto ObtenerProducto(int IdProducto);
        Producto RegistrarProducto(Producto producto);
        void ActualizarProducto(Producto producto, decimal nuevoPrecio, int nuevaCantidad);
        string ActualizarProductoDeLista(int Id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor);
        string EliminarProductoDeLista(int Id);
    }
}