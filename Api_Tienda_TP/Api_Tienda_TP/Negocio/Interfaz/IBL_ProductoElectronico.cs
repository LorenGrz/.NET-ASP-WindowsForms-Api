using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_ProductoElectronico
    {
        void ActualizarProductoElectronico(ProductoElectronico productoElectronico, decimal nuevoPrecio, int nuevaCantidad);
        string EliminarProductoElectronicoDeLista(int Id);
        ProductoElectronico ObtenerProductoElectronico(int IdProducto);

        List<ProductoElectronico> ObtenerProductosElectronicos();
        List<ProductoElectronico> ObtenerProductosElectronicosPorProveedor(int idProveedor);
        ProductoElectronico RegistrarProductoElectronico(ProductoElectronico productoElectronico);
        string ActualizarProductoElectronicoDeLista(int Id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor, int voltaje, bool transformador);
    }
}