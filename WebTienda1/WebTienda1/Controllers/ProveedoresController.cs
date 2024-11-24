using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ProyectoCompartido;
using System.Net.Http.Headers;
using WebTienda1.Configuracion;

namespace WebTienda1.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string baseUrl;
        public ProveedoresController(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> apiSettings)
        {
            _httpClient = httpClientFactory.CreateClient();
            baseUrl = apiSettings.Value.BaseUrl;

            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        
        public async Task<IActionResult> Index()
        {
            var respuesta = await _httpClient.GetAsync("/Proveedor/ListarProveedores");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var productos = JsonConvert.DeserializeObject<List<Proveedor>>(contenido);
                return View(productos);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> Detalles(int id)
        {
            var respuesta = await _httpClient.GetAsync($"Proveedor/ListarProveedorPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var proveedor = JsonConvert.DeserializeObject<List<Proveedor>>(contenido);
                return View(proveedor);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult AgregarProveedor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProveedor(Proveedor proveedorVista)
        {
            var respuesta = await _httpClient.PostAsJsonAsync("/Proveedor/RegistrarProveedor", proveedorVista);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> ActualizarProveedor(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Proveedor/ListarProveedorPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var proveedor = JsonConvert.DeserializeObject<List<Proveedor>>(contenido);
                return View(proveedor);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProveedor(int id, Proveedor proveedor)
        {
            var respuesta = await _httpClient.PutAsJsonAsync($"/Proveedor/ModificarProveedor?_id={id}", proveedor);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EliminarProveedor(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Producto/ListarProveedorPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var proveedor = JsonConvert.DeserializeObject<List<Proveedor>>(contenido);
                return View(proveedor);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpDelete, ActionName("Eliminar")]
        public async Task<IActionResult> ConfirmarEliminacionProveedor(int id)
        {
            var respuesta = await _httpClient.DeleteAsync($"/Proveedor/EliminarProveedor?_id={id}");
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
