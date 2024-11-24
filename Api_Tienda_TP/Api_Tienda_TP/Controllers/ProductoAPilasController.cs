using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoAPilasController : ControllerBase
    {
        private readonly IBL_ProductoAPilas _productoAPilas;

        public ProductoAPilasController(IBL_ProductoAPilas productoAPilas)
        {
            _productoAPilas = productoAPilas;
        }

        [HttpGet]
        [Route("ListarProductosAPilas")]
        public ActionResult<IEnumerable<ProductoAPilas>> ObtenerProductosAPilas()
        {
            return _productoAPilas.ObtenerProductosAPilas();
        }

        [HttpGet]
        [Route("ListarProductosAPilasPorProveedor")]
        public ActionResult<IEnumerable<ProductoAPilas>> ObtenerProductosAPilasPorProveedor(int IdProveedor)
        {
            return _productoAPilas.ObtenerProductosAPilasPorProveedor(IdProveedor);
        }

        [HttpPost]
        [Route("RegistrarProductoAPilas")]
        public ActionResult<Producto> CrearProductoAPilas(
            [FromBody] ProductoAPilas productoAPilas
            )
        {
            ProductoAPilas prodNuevo = new ProductoAPilas(productoAPilas.Nombre, productoAPilas.Precio, productoAPilas.Cantidad, 
                productoAPilas.Descripcion, productoAPilas.ProveedorID, productoAPilas.CantPilas, productoAPilas.Tipo);
            return _productoAPilas.RegistrarProductoAPilas(prodNuevo);
        }

        [HttpDelete]
        [Route("EliminarProductoAPilas")]
        public ActionResult<string> EliminarProductoAPilas(int _id)
        {
            var resultado = _productoAPilas.EliminarProductoAPilasDeLista(_id);
            return Ok(resultado);
        }

        [HttpPut]
        [Route("ActualizarProductoAPilas")]

        public ActionResult<string> ActualizarProductoAPilas(int _id,
            [FromBody] ProductoAPilas productoAPilas
            )
        {
            var resultado = _productoAPilas.ActualizarProductoAPilasDeLista(_id, productoAPilas.Descripcion, productoAPilas.Precio, productoAPilas.Cantidad, 
                productoAPilas.ProveedorID, productoAPilas.CantPilas, productoAPilas.Tipo);
            return Ok(resultado);
        }

        //// GET: ProductoAPilasController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ProductoAPilasController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProductoAPilasController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProductoAPilasController/Create
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

        //// GET: ProductoAPilasController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoAPilasController/Edit/5
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

        //// GET: ProductoAPilasController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoAPilasController/Delete/5
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
