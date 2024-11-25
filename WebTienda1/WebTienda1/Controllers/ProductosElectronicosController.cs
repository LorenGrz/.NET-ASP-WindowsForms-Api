using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ProyectoCompartido;
using System.Net.Http;
using System.Net.Http.Headers;
using WebTienda1.Configuracion;

namespace WebTienda1.Controllers
{
    public class ProductosElectronicosController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string baseUrl;
        public ProductosElectronicosController(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> apiSettings)
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
            var respuesta = await _httpClient.GetAsync("/ProductoElectronico/ListarProductosElectronicos");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<List<ProductoElectronico>>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> DetallesElectronico(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoElectronico/ListarProductoElectronicoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoElectronico>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult AgregarProductoElectronico()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProductoElectronico(ProductoElectronico productoVista)
        {
            var respuesta = await _httpClient.PostAsJsonAsync("/ProductoElectronico/RegistrarProductoElectronico", productoVista);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> ActualizarProductoElectronico(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoElectronico/ListarProductoElectronicoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoElectronico>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProductoElectronico(int id, ProductoElectronico producto)
        {
            var respuesta = await _httpClient.PutAsJsonAsync($"/ProductoElectronico/ModificarProductoElectronico?_id={id}", producto);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EliminarProductoElectronico(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/ProductoElectronico/ListarProductoElectronicoPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<ProductoElectronico>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpDelete, ActionName("ConfirmarEliminacionProductoElectronico")]
        public async Task<IActionResult> ConfirmarEliminacionProductoElectronico(int id)
        {
            var respuesta = await _httpClient.DeleteAsync($"/ProductoElectronico/EliminarProductoElectronico?_id={id}");
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
