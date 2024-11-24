using Api_Tienda_TP.Datos;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_Proveedor : IBL_Proveedor
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_Proveedor(TiendaDbContext context)
        {
            _context = context;
        }
        public List<Proveedor> ObtenerProveedores()
        {
            return _context.Proveedores.ToList();  // Obtiene todos los productos de la base de datos
        }
        Proveedor IBL_Proveedor.RegistrarProveedor(Proveedor _proveedor)
        {
            try
            {
                if (string.IsNullOrEmpty(_proveedor.Nombre))
                {
                    Console.WriteLine("el nombre no puede ser nulo ni vacio");
                }
                if (_proveedor.Id <= 0)
                {
                    Console.WriteLine("el Id no puede ser negativo o cero");
                }
                if (!_proveedor.Email.Contains("@"))
                {
                    Console.WriteLine("El Email debe contener @");
                }
                _context.Proveedores.Add(_proveedor);  // Agrega el cliente a la base de datos
                _context.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return _proveedor;
        }
        bool IBL_Proveedor.ValidarProveedor(Proveedor _proveedor)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(_proveedor.Nombre))
            {
                Console.WriteLine("el nombre no puede ser nulo ni vacio");
                valid = false;
            }
            if (_proveedor.Id <= 0)
            {
                Console.WriteLine("el Id no puede ser negativo o cero");
                valid = false;
            }
            if (!_proveedor.Email.Contains("@"))
            {
                Console.WriteLine("El Email debe contener @");
                valid = false;
            }
            if (valid)
            {
                Console.WriteLine("Validacion Exitosa!");
            }
            return valid;
        }
        Proveedor IBL_Proveedor.ObtenerProveedor(int _IdProveedor)
        {
            return _context.Proveedores.FirstOrDefault(p => p.Id == _IdProveedor);

        }
        Proveedor ObtenerProveedor(int _IdProveedor)
        {
            return _context.Proveedores.FirstOrDefault(p => p.Id == _IdProveedor);
        }

        bool IBL_Proveedor.TieneProductos(int id)
        {
            var proveedor = ObtenerProveedor(id);
            if (proveedor != null)
            {
                foreach (var producto in _context.Productos)
                {
                    if (producto.ProveedorID == id)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        string IBL_Proveedor.EliminarProductosDelProveedor(int id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var proveedor = ObtenerProveedor(id);

                if (proveedor != null)
                {
                    foreach (var producto in _context.Productos)
                    {
                        if (producto.ProveedorID == id)
                        {
                            _context.Productos.Remove(producto);
                        }
                    }
                    _context.SaveChanges();
                    resp = "Productos eliminados con exito";
                }
                else
                {
                    resp = "Proveedor no encontrado";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
        string IBL_Proveedor.EliminarProveedorDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var proveedor = _context.Proveedores.FirstOrDefault(p => p.Id == _Id);

                if (proveedor != null)
                {
                    // Elimina el Cliente de la lista
                    _context.Proveedores.Remove(proveedor);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Proveedor Eliminado con éxito";
                }
                else
                {
                    resp = "Proveedor no encontrado";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
        string IBL_Proveedor.ActualizarProveedorDeLista(int _Id, Proveedor _proveedor)
        {
            string resp = "";
            try
            {
                // Busca el cliente por su id
                var proveedor = _context.Proveedores.FirstOrDefault(p => p.Id == _Id);

                if (proveedor != null)
                {
                    // Actualiza las propiedades del cliente
                    proveedor.Nombre = _proveedor.Nombre;
                    proveedor.Email = _proveedor.Email;
                    proveedor.Telefono = _proveedor.Telefono;
                    proveedor.Direccion = _proveedor.Direccion;

                    // Actualiza el producto en la base de datos
                    _context.Proveedores.Update(proveedor);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Proveedor actualizado con éxito";
                }
                else
                {
                    resp = "Proveedor no encontrado";
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
