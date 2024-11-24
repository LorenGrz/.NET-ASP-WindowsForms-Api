using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_Proveedor
    {
        // Desarrollar Obtener Proveedor
        Proveedor RegistrarProveedor(Proveedor proveedor);
        bool ValidarProveedor(Proveedor proveedor);
        List<Proveedor> ObtenerProveedores();
        string EliminarProveedorDeLista(int Id);
        string ActualizarProveedorDeLista(int Id, Proveedor proveedor);
        bool TieneProductos(int Id);
        string EliminarProductosDelProveedor(int id);
        Proveedor ObtenerProveedor(int IdProveedor);
    }
}