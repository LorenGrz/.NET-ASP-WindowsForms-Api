using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_Venta
    {
        // Desarrollar Obtener Venta
        bool ValidarVenta(Venta venta);
        List<Venta> ObtenerVentas();
        Venta RegistrarVenta(Venta venta);
        string EliminarVentaDeLista(int Id);
        Venta ObtenerVenta(int IdVenta);
    }
}