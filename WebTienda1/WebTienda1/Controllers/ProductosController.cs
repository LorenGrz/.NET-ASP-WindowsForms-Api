using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Net.Http;
using WebTienda1.Configuracion;
using ProyectoCompartido;
using Newtonsoft.Json;

namespace WebTienda1.Controllers
{
    public class ProductosController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string baseUrl;
        public ProductosController(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> apiSettings)
        {
            _httpClient = httpClientFactory.CreateClient();
            baseUrl = apiSettings.Value.BaseUrl;

            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: ProductosController
        public async Task<IActionResult> Index()
        {
            var respuesta = await _httpClient.GetAsync("/Producto/ListarProductos");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<List<Producto>>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> Detalles(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Producto/ListarProductoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<Producto>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult AgregarProducto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProducto(Producto productoVista)
        {
            var respuesta = await _httpClient.PostAsJsonAsync("/Producto/RegistrarProducto", productoVista);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> ActualizarProducto(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Producto/ListarProductoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<Producto>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ActualizarProducto(int id, Producto producto)
        {
            var respuesta = await _httpClient.PutAsJsonAsync($"/Producto/ActualizarProducto?_id={id}", producto);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EliminarProducto(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Producto/ListarProductoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<Producto>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPost, ActionName("ConfirmarEliminacionProducto")]
        public async Task<IActionResult> ConfirmarEliminacionProducto(int id)
        {
            var respuesta = await _httpClient.DeleteAsync($"/Producto/EliminarProducto?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }
    }
}
