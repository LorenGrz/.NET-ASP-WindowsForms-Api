using Api_Tienda_TP.Datos;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_ProductoElectronico : IBL_ProductoElectronico
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_ProductoElectronico(TiendaDbContext context)
        {
            _context = context;
        }

        ProductoElectronico IBL_ProductoElectronico.ObtenerProductoElectronico(int _idProducto)
        {
            return _context.ProductosElectronicos.FirstOrDefault(p => p.Id == _idProducto);
        }
        // Obtener todos los productos desde la base de datos
        List<ProductoElectronico> IBL_ProductoElectronico.ObtenerProductosElectronicos()
        {
            return _context.ProductosElectronicos.ToList();  // Obtiene todos los productos de la base de datos
        }

        // Obtener todos los productos por proveedor desde la base de datos
        List<ProductoElectronico> IBL_ProductoElectronico.ObtenerProductosElectronicosPorProveedor(int idProveedor)
        {
            return _context.Productos.OfType<ProductoElectronico>().Where(p => p.ProveedorID == idProveedor).ToList();  // Obtiene todos los productos de la base de datos
        }
        // Metodo que actualiza un producto electronico
        void IBL_ProductoElectronico.ActualizarProductoElectronico(ProductoElectronico productoElectronico, decimal nuevoPrecio, int nuevaCantidad)
        {
            // Validaciones de negocio
            if (nuevoPrecio > 0)
            {
                productoElectronico.Precio = nuevoPrecio;
            }
            else
            {
                Console.WriteLine("El precio debe ser mayor a 0");
            }

            if (nuevaCantidad >= 0)
            {
                productoElectronico.Cantidad = nuevaCantidad;
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa");
            }

            // Actualiza el producto en la base de datos
            _context.ProductosElectronicos.Update(productoElectronico);
            _context.SaveChanges();  // Guarda los cambios en la base de datos
        }
        // Metodo que Elimina un producto electronico de la lista
        string IBL_ProductoElectronico.EliminarProductoElectronicoDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var productoElectronico = _context.ProductosElectronicos.FirstOrDefault(p => p.Id == _Id);

                if (productoElectronico != null)
                {
                    // Elimina el Producto de la lista
                    _context.ProductosElectronicos.Remove(productoElectronico);
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
        // Metodo que Registra un producto electronico

        ProductoElectronico IBL_ProductoElectronico.RegistrarProductoElectronico(ProductoElectronico productoElectronico)
        {
            try
            {
                var local = _context.Productos.Local.FirstOrDefault(entry => entry.Id == productoElectronico.Id);

                if (local != null)
                {
                    _context.Entry(local).State = EntityState.Detached;
                }

                _context.ProductosElectronicos.Add(productoElectronico);  // Agrega el producto a la base de datos
                _context.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return productoElectronico;
        }
        // Metodo que actualiza un producto electronico de la lista
        string IBL_ProductoElectronico.ActualizarProductoElectronicoDeLista(int _Id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor, int nuevoVoltaje, bool nuevoTransformador)
        {
            string resp = "";
            try
            {
                // Busca el producto por su nombre
                var productoElectronico = _context.ProductosElectronicos.FirstOrDefault(p => p.Id == _Id);

                if (productoElectronico != null)
                {
                    // Actualiza las propiedades del producto
                    productoElectronico.Descripcion = descripcion;
                    productoElectronico.Precio = nuevoPrecio;
                    productoElectronico.Cantidad = nuevaCantidad;
                    productoElectronico.ProveedorID = nuevoProveedor;
                    productoElectronico.Voltaje = nuevoVoltaje;
                    productoElectronico.Transformador = nuevoTransformador;

                    // Actualiza el producto en la base de datos
                    _context.ProductosElectronicos.Update(productoElectronico);
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
    }
}
