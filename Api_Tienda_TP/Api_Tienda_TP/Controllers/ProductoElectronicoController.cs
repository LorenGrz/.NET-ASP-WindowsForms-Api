using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoElectronicoController : ControllerBase
    {
        private readonly IBL_ProductoElectronico _productoElectronico;

        public ProductoElectronicoController(IBL_ProductoElectronico productoElectronico)
        {
            _productoElectronico = productoElectronico;
        }

        [HttpGet]
        [Route("ListarProductosElectronicos")]
        public ActionResult<IEnumerable<ProductoElectronico>> ObtenerProductosElectronicos()
        {
            return _productoElectronico.ObtenerProductosElectronicos();
        }

        [HttpGet]
        [Route("ListarProductosPorProveedor")]
        public ActionResult<IEnumerable<ProductoElectronico>> ObtenerProductosElectronicosPorProveedor(int IdProveedor)
        {
            return _productoElectronico.ObtenerProductosElectronicosPorProveedor(IdProveedor);
        }

        [HttpDelete]
        [Route("EliminarProductoElectronico")]
        public ActionResult<string> EliminarProductoElectronico(int _id)
        {
            var resultado = _productoElectronico.EliminarProductoElectronicoDeLista(_id);
            return Ok(resultado);
        }

        [HttpPost]
        [Route("RegistrarProductoElectronico")]
        public ActionResult<ProductoElectronico> CrearProductoElectronico([FromBody] ProductoElectronico prodElectronico

            )
        {
            ProductoElectronico prodNuevo = new ProductoElectronico(prodElectronico.Nombre, prodElectronico.Precio, prodElectronico.Cantidad, 
                prodElectronico.Descripcion, prodElectronico.ProveedorID, prodElectronico.Voltaje, prodElectronico.Transformador);
            return _productoElectronico.RegistrarProductoElectronico(prodNuevo);
        }

        [HttpPut]
        [Route("Actualizar Producto Electronico")]
        public ActionResult<string> ActualizarProductoElectronico(
            int _id,
            [FromBody] ProductoElectronico prodElectronico
            )
        {
            var resultado = _productoElectronico.ActualizarProductoElectronicoDeLista(_id, prodElectronico.Descripcion, prodElectronico.Precio, 
                prodElectronico.Cantidad, prodElectronico.ProveedorID, prodElectronico.Voltaje, prodElectronico.Transformador);
            return Ok(resultado);
        }

        //// GET: ProductoElectronicoController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ProductoElectronicoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProductoElectronicoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProductoElectronicoController/Create
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

        //// GET: ProductoElectronicoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoElectronicoController/Edit/5
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

        //// GET: ProductoElectronicoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoElectronicoController/Delete/5
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
