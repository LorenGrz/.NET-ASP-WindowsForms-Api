using Api_Tienda_TP.Datos;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using System.Security.Cryptography;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_Venta : IBL_Venta
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_Venta(TiendaDbContext context)
        {
            _context = context;
        }
        // Metodo que lista las ventas
        public List<Venta> ObtenerVentas()
        {
            return _context.Ventas.ToList();
        }
        Venta IBL_Venta.ObtenerVenta(int _idVenta)
        {
            return _context.Ventas.FirstOrDefault(p => p.Id == _idVenta);
        }
        bool IBL_Venta.ValidarVenta(Venta venta)
        {          
            bool valid = true;
            if (string.IsNullOrEmpty(Convert.ToString(venta.Fecha)))
            {
                Console.WriteLine("el nombre no puede ser nulo ni vacio");
                valid = false;
            }
            if (venta.Id <= 0)
            {
                Console.WriteLine("el Id no puede ser negativo o cero");
                valid = false;
            }
            if (venta.CantidadVendida<0)
            {
                Console.WriteLine("La cantidad vendida no puede ser negativa");
                valid = false;
            }
            if (venta.PrecioVenta < 0)
            {
                Console.WriteLine("El precio de la venta no puede ser negativa");
                valid = false;
            }
            if (valid)
            {
                Console.WriteLine("Validacion Exitosa!");
            }
            return valid;
        }
        Venta IBL_Venta.RegistrarVenta(Venta venta)
        {
            venta.Prod = _context.Productos.FirstOrDefault(p => p.Id == venta.IdProducto);
            try
            {
                if (venta.Prod != null)
                {
                    venta.Prod.Cantidad -= venta.CantidadVendida;
                    _context.Productos.Update(venta.Prod);
                    _context.Ventas.Add(venta);  // Agrega el producto a la base de datos
                    _context.SaveChanges();  // Guarda los cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return venta;
        }
        string IBL_Venta.EliminarVentaDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca la venta por su ID
                var venta = _context.Ventas.FirstOrDefault(p => p.Id == _Id);
                if (venta != null)
                {
                    var prod = _context.Productos.FirstOrDefault(p => p.Id == venta.IdProducto);
                    prod.Cantidad += venta.CantidadVendida;
                    _context.Productos.Update(prod);
                    // Elimina el Cliente de la lista
                    _context.Ventas.Remove(venta);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Venta Eliminada con éxito";
                }
                else
                {
                    resp = "Venta no encontrada";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
    }
}
