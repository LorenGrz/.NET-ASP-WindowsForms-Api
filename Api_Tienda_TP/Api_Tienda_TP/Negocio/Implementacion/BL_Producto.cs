using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using Api_Tienda_TP.Datos;
using Microsoft.EntityFrameworkCore;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_Producto : IBL_Producto
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_Producto(TiendaDbContext context)
        {
            _context = context;
        }

        // Método para validar un producto
        bool IBL_Producto.ValidarProducto(Producto _producto)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(_producto.Nombre))
            {
                Console.WriteLine("el nombre no puede ser nulo ni vacio");
                valid = false;
            }
            if (_producto.Id <= 0)
            {
                Console.WriteLine("el Id no puede ser negativo o cero");
                valid = false;
            }
            if (_producto.Cantidad<0)
            {
                Console.WriteLine("La cantidad no puede ser negativa");
                valid = false;
            }
            if (_producto.Precio <= 0)
            {
                Console.WriteLine("El precio no puede ser negativo o cero");
                valid = false;
            }
            if (valid)
            {
                Console.WriteLine("Validacion Exitosa!");
            }
            return valid;
        }

        // Método para actualizar un producto
        void IBL_Producto.ActualizarProducto(Producto producto, decimal nuevoPrecio, int nuevaCantidad)
        {
            // Validaciones de negocio
            if (nuevoPrecio > 0)
            {
                producto.Precio = nuevoPrecio;
            }
            else
            {
                Console.WriteLine("El precio debe ser mayor a 0");
            }

            if (nuevaCantidad >= 0)
            {
                producto.Cantidad = nuevaCantidad;
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa");
            }

            // Actualiza el producto en la base de datos
            _context.Productos.Update(producto);
            _context.SaveChanges();  // Guarda los cambios en la base de datos
        }

        // Método para registrar un nuevo producto
        Producto IBL_Producto.RegistrarProducto(Producto producto)
        {
            try
            {
                var proveedorExiste = _context.Proveedores.Any(p => p.Id == producto.ProveedorID);
                if (!proveedorExiste)
                {
                    Console.WriteLine("No existe el ID del Proveedor");
                    return producto;
                }
                _context.Productos.Add(producto);  // Agrega el producto a la base de datos
                _context.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return producto;
        }

        // Recibe Id y devuelve el producto
        Producto IBL_Producto.ObtenerProducto(int _idProducto)
        {
            return _context.Productos.FirstOrDefault(p => p.Id == _idProducto);        
        }

        // Obtener todos los productos desde la base de datos
        List<Producto> IBL_Producto.ObtenerProductos()
        {
            return _context.Productos.ToList();  // Obtiene todos los productos de la base de datos
        }

        // Obtener todos los productos por proveedor desde la base de datos
        List<Producto> IBL_Producto.ObtenerProductosPorProveedor(int idProveedor)
        {
            return _context.Productos.Where(p => p.ProveedorID == idProveedor).ToList();
        }

        // Actualizar producto por nombre (ejemplo básico de actualización)
        string IBL_Producto.ActualizarProductoDeLista(int id, string descripcion, decimal nuevoPrecio, int nuevaCantidad, int nuevoProveedor)
        {
            string resp = "";
            try
            {
                // Busca el producto por su nombre
                var producto = _context.Productos.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Actualiza las propiedades del producto
                    producto.Descripcion = descripcion;
                    producto.Precio = nuevoPrecio;
                    producto.Cantidad = nuevaCantidad;
                    producto.ProveedorID = nuevoProveedor;

                    // Actualiza el producto en la base de datos
                    _context.Productos.Update(producto);
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
        string IBL_Producto.EliminarProductoDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var producto = _context.Productos.FirstOrDefault(p => p.Id == _Id);

                if (producto != null)
                {
                    // Elimina el Producto de la lista
                    _context.Productos.Remove(producto);
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
    }
}