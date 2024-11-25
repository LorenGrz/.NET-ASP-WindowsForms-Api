using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_ProductoAPilas
    {
        List<ProductoAPilas> ObtenerProductosAPilas();
        List<ProductoAPilas> ObtenerProductosAPilasPorProveedor(int idProveedor);
        string EliminarProductoAPilasDeLista(int Id);
        ProductoAPilas ObtenerProductoAPilas(int IdProducto);
        ProductoAPilas RegistrarProductoAPilas(ProductoAPilas productoAPilas);
        string ActualizarProductoAPilasDeLista(int Id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor, int cantPilas, TipoPilas tipoPilas);
        void ActualizarProductoAPilas(ProductoAPilas productoAPilas, decimal nuevoPrecio, int nuevaCantidad);
    }
}