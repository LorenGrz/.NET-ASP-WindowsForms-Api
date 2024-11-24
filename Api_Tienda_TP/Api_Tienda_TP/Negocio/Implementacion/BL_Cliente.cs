using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Interfaz;
using Api_Tienda_TP.Datos;
using Microsoft.EntityFrameworkCore;

namespace Api_Tienda_TP.Negocio.Implementacion
{
    public class BL_Cliente : IBL_Cliente
    {
        private readonly TiendaDbContext _context;  // Inyección del DbContext para trabajar con EF

        // Constructor que recibe el DbContext para inyectar las dependencias
        public BL_Cliente(TiendaDbContext context)
        {
            _context = context;
        }
        // Metodo que registra un nuevo Cliente
        Cliente IBL_Cliente.RegistrarCliente(Cliente _cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(_cliente.Nombre))
                {
                    Console.WriteLine("el nombre no puede ser nulo ni vacio");
                }
                if (_cliente.Id <= 0)
                {
                    Console.WriteLine("el Id no puede ser negativo o cero");
                }
                if (!_cliente.Email.Contains("@"))
                {
                    Console.WriteLine("El Email debe contener @");
                }
                _context.Clientes.Add(_cliente);  // Agrega el cliente a la base de datos
                _context.SaveChanges();  // Guarda los cambios en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return _cliente;
        }
        // Metodo que Valida un Cliente enviado
        bool IBL_Cliente.ValidarCliente(Cliente _cliente)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(_cliente.Nombre))
            {
                Console.WriteLine("el nombre no puede ser nulo ni vacio");
                valid = false;
            }
            if (_cliente.Id <= 0)
            {
                Console.WriteLine("el Id no puede ser negativo o cero");
                valid = false;
            }
            if (!_cliente.Email.Contains("@"))
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
        // Metodo que Lista y muestra los Clientes
        List<Cliente> IBL_Cliente.GetClientes()
        {
            return _context.Clientes.ToList();  // Obtiene todos los productos de la base de datos
        }
        // Metodo que elimina un Cliente de la lista de clientes
        string IBL_Cliente.EliminarClienteDeLista(int _Id)
        {
            string resp = "";
            try
            {
                // Busca el producto por su ID
                var cliente = _context.Clientes.FirstOrDefault(p => p.Id == _Id);

                if (cliente != null)
                {
                    // Elimina el Cliente de la lista
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Cliente eliminado con éxito";
                }
                else
                {
                    resp = "Cliente no encontrado";
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
        // Metodo que actualiza un Cliente de la lista de clientes
        string IBL_Cliente.ActualizarClienteDeLista(int _Id, string nuevoNombre, string nuevoEmail, string nuevoTelefono)
        {
            string resp = "";
            try
            {
                // Busca el cliente por su id
                var cliente = _context.Clientes.FirstOrDefault(p => p.Id == _Id);

                if (cliente != null)
                {
                    // Actualiza las propiedades del cliente
                    cliente.Nombre = nuevoNombre;
                    cliente.Email = nuevoEmail;
                    cliente.Telefono = nuevoTelefono;

                    // Actualiza el producto en la base de datos
                    _context.Clientes.Update(cliente);
                    _context.SaveChanges();  // Guarda los cambios
                    resp = "Cliente actualizado con éxito";
                }
                else
                {
                    resp = "Cliente no encontrado";
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
