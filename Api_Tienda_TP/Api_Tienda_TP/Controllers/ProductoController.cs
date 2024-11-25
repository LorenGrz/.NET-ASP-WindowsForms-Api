using ProyectoCompartido;
using Api_Tienda_TP.Negocio.Implementacion;
using Api_Tienda_TP.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tienda_TP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IBL_Producto _producto;

        public ProductoController(IBL_Producto producto)
        {
            _producto = producto;
        }

        [HttpGet]
        [Route("ListarProductos")]
        public ActionResult<IEnumerable<Producto>> ObtenerProductos()
        {
            return _producto.ObtenerProductos();
        }

        [HttpGet]
        [Route("ListarProductoPorId")]
        public ActionResult<Producto> ObtenerProductoPorId(int _id)
        {
            return _producto.ObtenerProducto(_id);
        }

        [HttpGet]
        [Route("ListarProductosPorProveedor")]
        public ActionResult<IEnumerable<Producto>> ObtenerProductosPorProveedor(int IdProveedor)
        {
            return _producto.ObtenerProductosPorProveedor(IdProveedor);
        }

        [HttpPost]
        [Route("RegistrarProducto")]
        public ActionResult<Producto> CrearProducto(
            [FromBody] Producto producto
            )
        {
            Producto prodNuevo = new Producto(producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion, producto.ProveedorID);
            return  _producto.RegistrarProducto(prodNuevo);
        }

        [HttpDelete]
        [Route("EliminarProducto")]
        public ActionResult<string> EliminarProducto(int _id)
        {
            var resultado = _producto.EliminarProductoDeLista(_id);
            return Ok(resultado);
        }
        
        [HttpPut]
        [Route("ActualizarProducto")]
        public ActionResult<string> ActualizarProducto(int _id, 
            [FromBody] Producto producto
            )
        {
            var resultado = _producto.ActualizarProductoDeLista(_id, producto.Descripcion, producto.Precio, producto.Cantidad,producto.ProveedorID);
            return Ok(resultado);
        }

        //public ActionResult<string> RegistrarProducto([FromBody] Producto producto)
        //{
        //    //if (!_producto.ValidarProducto(producto))
        //    //{
        //    //    return BadRequest("El producto no es válido.");
        //    //}

        //    var resultado = _producto.RegistrarProducto(producto);
        //    return Ok(resultado);
        //}

        //// GET: ProductoController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ProductoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProductoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProductoController/Create
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

        //// GET: ProductoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoController/Edit/5
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

        //// GET: ProductoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductoController/Delete/5
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
