using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly IBL_Venta _venta;

        private readonly IBL_Producto _producto;

        public VentasController(IBL_Venta venta, IBL_Producto producto)
        {
            _venta = venta;
            _producto = producto;       
        }
        [HttpGet]
        [Route("ListarVentaPorId")]
        public ActionResult<Venta> ObtenerVentaPorId(int _id)
        {
            return _venta.ObtenerVenta(_id);
        }
        [HttpGet]
        [Route("ListarVentas")]
        public ActionResult<IEnumerable<Venta>> ObtenerVentas()
        {
            return _venta.ObtenerVentas();
        }

        [HttpPost]
        [Route("RegistrarVenta")]
        public ActionResult<Venta> CrearVenta(
            [FromBody] Venta venta
            )
        {
            Producto prod = _producto.ObtenerProducto(venta.IdProducto);
            if(prod == null)
            {
                return BadRequest("El ID ingresado no concuerda con la base de datos");
            }
            else if (prod.Cantidad < venta.CantidadVendida)
            {
                return BadRequest("La cantidad ingresada no concuerda con la base de datos");
            }
            Venta ventaNueva = new Venta(DateTime.Now.Date, venta.IdProducto, venta.CantidadVendida, prod.Precio, prod);
            return _venta.RegistrarVenta(ventaNueva);
        }

        [HttpDelete]
        [Route("EliminarVenta")]
        public ActionResult<string> EliminarVenta(int _id)
        {
            var resultado = _venta.EliminarVentaDeLista(_id);
            return Ok(resultado);
        }

        //// GET: VentasController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: VentasController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: VentasController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: VentasController/Create
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

        //// GET: VentasController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: VentasController/Edit/5
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

        //// GET: VentasController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: VentasController/Delete/5
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
