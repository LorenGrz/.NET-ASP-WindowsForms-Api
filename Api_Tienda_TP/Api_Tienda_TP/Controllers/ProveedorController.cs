using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProveedorController : ControllerBase
    {
        private readonly IBL_Proveedor _proveedor;

        public ProveedorController(IBL_Proveedor proveedor)
        {
            _proveedor= proveedor;
        }
        [HttpGet]
        [Route("ListarProveedorPorId")]
        public ActionResult<Proveedor> ObtenerProveedorPorId(int _id)
        {
            return _proveedor.ObtenerProveedor(_id);
        }
        [HttpGet]
        [Route("ListarProveedores")]
        public ActionResult<IEnumerable<Proveedor>> ObtenerProveedores()
        {
            return _proveedor.ObtenerProveedores();
        }

        [HttpPost]
        [Route("RegistrarProveedor")]
        public ActionResult<Proveedor> CrearProveedor(
            [FromBody] Proveedor proveedor
            )
        {
            Proveedor provNuevo = new Proveedor(proveedor.Nombre,proveedor.Email,proveedor.Direccion,proveedor.Telefono);
            return _proveedor.RegistrarProveedor(provNuevo);
        }

        [HttpDelete]
        [Route("EliminarProveedor")]
        public ActionResult<string> EliminarProveedor(int _id)
        {
            var resultado = _proveedor.EliminarProveedorDeLista(_id);
            return Ok(resultado);
        }

        [HttpPut]
        [Route("ActualizarProveedor")]
        public ActionResult<string> ActualizarProveedor(int _id,
            [FromBody] Proveedor proveedor
            )
        {
            var resultado = _proveedor.ActualizarProveedorDeLista(_id, proveedor);
            return Ok(resultado);
        }

        [HttpGet]
        [Route("TieneProductos")]
        public ActionResult<bool> TieneProductos(int _id)
        {
            return _proveedor.TieneProductos(_id);
        }

        [HttpDelete]
        [Route("EliminarProductosDelProveedor")]
        public ActionResult<string> EliminarProductosDelProveedor(int _id)
        {
            return _proveedor.EliminarProductosDelProveedor(_id);
        }
        //// GET: ProveedorController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ProveedorController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProveedorController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProveedorController/Create
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

        //// GET: ProveedorController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProveedorController/Edit/5
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

        //// GET: ProveedorController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProveedorController/Delete/5
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
