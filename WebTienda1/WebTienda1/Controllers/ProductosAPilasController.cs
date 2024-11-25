using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ProyectoCompartido;
using System.Net.Http.Headers;
using WebTienda1.Configuracion;

namespace WebTienda1.Controllers
{
    public class ProductosAPilasController : Controller
    {
        // GET: ProductosAPilasController
        private readonly HttpClient _httpClient;
        private readonly string baseUrl;
        public ProductosAPilasController(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> apiSettings)
        {
            _httpClient = httpClientFactory.CreateClient();
            baseUrl = apiSettings.Value.BaseUrl;

            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: ProductosElectronicosController
        public async Task<IActionResult> Index()
        {
            var respuesta = await _httpClient.GetAsync("/ProductoAPilas/ListarProductosAPilas");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<List<ProductoAPilas>>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> DetallesAPilas(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoAPilas/ListarProductoAPilasPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoAPilas>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult AgregarProductoAPilas()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProductoAPilas(ProductoAPilas productoVista)
        {
            var respuesta = await _httpClient.PostAsJsonAsync("/ProductoAPilas/RegistrarProductoAPilas", productoVista);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> ActualizarProductoAPilas(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoAPilas/ListarProductoAPilasPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoAPilas>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProductoAPilas(int id, ProductoAPilas producto)
        {
            var respuesta = await _httpClient.PutAsJsonAsync($"/ProductoAPilas/ModificarProductoAPilas?_id={id}", producto);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EliminarProductoAPilas(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoAPilas/ListarProductoAPilasPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoAPilas>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpDelete, ActionName("ConfirmarEliminacionProductoAPilas")]
        public async Task<IActionResult> ConfirmarEliminacionProductoAPilas(int id)
        {
            var respuesta = await _httpClient.DeleteAsync($"/ProductoAPilas/EliminarProductoAPilas?_id={id}");
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
