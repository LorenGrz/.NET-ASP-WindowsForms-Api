using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCompartido;

namespace Api_Tienda_TP.Negocio.Interfaz
{
    public interface IBL_Cliente
    {
        List<Cliente> GetClientes();
        Cliente RegistrarCliente(Cliente cliente);
        bool ValidarCliente(Cliente cliente);
        string EliminarClienteDeLista(int Id);
        string ActualizarClienteDeLista(int Id, string nombre, string email, string telefono);
    }
}