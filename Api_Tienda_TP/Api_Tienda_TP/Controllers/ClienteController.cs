using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IBL_Cliente _cliente;

        public ClienteController(IBL_Cliente cliente)
        {
            _cliente = cliente;
        }
     
        [HttpGet]
        [Route("LeerCliente")]
        public ActionResult<IEnumerable<Cliente>> ObtenerClientes()
        {
            return _cliente.GetClientes();
        }

        [HttpPost]
        [Route("RegistrarCliente")]
        public ActionResult<Cliente> CrearCliente(
            [FromBody] Cliente cliente
            )
        {
            Cliente clienteNuevo = new Cliente(cliente.Nombre, cliente.Email, cliente.Telefono);
            return _cliente.RegistrarCliente(clienteNuevo);
        }

        [HttpDelete]
        [Route("EliminarCliente")]
        public ActionResult<string> ActualizarCliente(int _id)
        {
            var resultado = _cliente.EliminarClienteDeLista(_id);
            return Ok(resultado);
        }

        [HttpPut]
        [Route("ActualizarCLiente")]
        public ActionResult<string> ActualizarCliente(int _id,
            [FromBody] Cliente cliente
            )
        {
            var resultado = _cliente.ActualizarClienteDeLista(_id, cliente.Nombre, cliente.Email, cliente.Telefono);
            return Ok(resultado);
        }

        // GET: ClienteController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ClienteController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ClienteController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ClienteController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ClienteController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ClienteController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ClienteController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ClienteController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
