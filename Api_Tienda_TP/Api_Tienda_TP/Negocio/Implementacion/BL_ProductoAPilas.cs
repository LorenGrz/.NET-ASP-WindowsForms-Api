using Api_Tienda_TP.Datos;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using System.Security.Cryptography;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_ProductoAPilas : IBL_ProductoAPilas
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_ProductoAPilas(TiendaDbContext context)
        {
            _context = context;
        }

        // Obtener todos los productos desde la base de datos
        List<ProductoAPilas> IBL_ProductoAPilas.ObtenerProductosAPilas()
        {
            return _context.ProductosAPilas.ToList();  // Obtiene todos los productos de la base de datos
        }

        // Obtener todos los productos por proveedor desde la base de datos
        List<ProductoAPilas> IBL_ProductoAPilas.ObtenerProductosAPilasPorProveedor(int idProveedor)
        {
            return _context.Productos.OfType<ProductoAPilas>().Where(p => p.ProveedorID == idProveedor).ToList();  // Obtiene todos los productos de la base de datos
        }

        // Metodo elimina el Productos A Pilas 
        string IBL_ProductoAPilas.EliminarProductoAPilasDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var productoAPilas = _context.ProductosAPilas.FirstOrDefault(p => p.Id == _Id);

                if (productoAPilas != null)
                {
                    // Elimina el Producto de la lista
                    _context.ProductosAPilas.Remove(productoAPilas);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Producto Eliminado con éxito";
                }
                else
                {
                    resp = "Producto no encontrado";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
        // Metodo que registra un Producto A Pilas
        ProductoAPilas IBL_ProductoAPilas.RegistrarProductoAPilas(ProductoAPilas productoAPilas)
        {
            try
            {
                _context.ProductosAPilas.Add(productoAPilas);  // Agrega el producto a la base de datos
                _context.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return productoAPilas;
        }
        // Metodo actualiza el Productos A Pilas de la lista
        string IBL_ProductoAPilas.ActualizarProductoAPilasDeLista(int _Id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor, int nuevaCantPilas, TipoPilas nuevoTipoPilas)
        {
            string resp = "";
            try
            {
                // Busca el producto por su nombre
                var productoAPilas = _context.ProductosAPilas.FirstOrDefault(p => p.Id == _Id);

                if (productoAPilas != null)
                {
                    // Actualiza las propiedades del producto
                    productoAPilas.Descripcion = descripcion;
                    productoAPilas.Precio = nuevoPrecio;
                    productoAPilas.Cantidad = nuevaCantidad;
                    productoAPilas.ProveedorID = nuevoProveedor;
                    productoAPilas.CantPilas = nuevaCantPilas;
                    productoAPilas.Tipo = nuevoTipoPilas;

                    // Actualiza el producto en la base de datos
                    _context.ProductosAPilas.Update(productoAPilas);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Producto actualizado con éxito";
                }
                else
                {
                    resp = "Producto no encontrado";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
        // Metodo actualiza un Productos A Pilas
        void IBL_ProductoAPilas.ActualizarProductoAPilas(ProductoAPilas productoAPilas, decimal nuevoPrecio, int nuevaCantidad)
        {
            // Validaciones de negocio
            if (nuevoPrecio > 0)
            {
                productoAPilas.Precio = nuevoPrecio;
            }
            else
            {
                Console.WriteLine("El precio debe ser mayor a 0");
            }

            if (nuevaCantidad >= 0)
            {
                productoAPilas.Cantidad = nuevaCantidad;
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa");
            }

            // Actualiza el producto en la base de datos
            _context.ProductosAPilas.Update(productoAPilas);
            _context.SaveChanges();  // Guarda los cambios en la base de datos
        }
    }
}
