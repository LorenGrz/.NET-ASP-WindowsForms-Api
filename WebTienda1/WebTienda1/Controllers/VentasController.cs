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
    public class VentasController : Controller
    {
        // GET: VentasController
        private readonly HttpClient _httpClient;
        private readonly string baseUrl;
        public VentasController(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> apiSettings)
        {
            _httpClient = httpClientFactory.CreateClient();
            baseUrl = apiSettings.Value.BaseUrl;

            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<IActionResult> Index()
        {
            var respuesta = await _httpClient.GetAsync("/Ventas/ListarVentas");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var ventas = JsonConvert.DeserializeObject<List<Venta>>(contenido);
                return View(ventas);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> DetallesVenta(int id)
        {
            var respuesta = await _httpClient.GetAsync($"Ventas/ListarVentaPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var venta = JsonConvert.DeserializeObject<Venta>(contenido);
                return View(venta);
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult AgregarVenta()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarVenta(Venta ventaVista)
        {
            var respuesta = await _httpClient.PostAsJsonAsync("/Ventas/RegistrarVenta", ventaVista);
            if (respuesta.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> EliminarVenta(int id)
        {
            var respuesta = await _httpClient.GetAsync($"/Ventas/ListarVentaPorId?_id={id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var proveedor = JsonConvert.DeserializeObject<Venta>(contenido);
                return View(proveedor);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpDelete]
        [ActionName("ConfirmarEliminacionVenta")]
        public async Task<IActionResult> ConfirmarEliminacionVenta(int id)
        {
            var respuesta = await _httpClient.DeleteAsync($"/Ventas/EliminarVenta?_id={id}");
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
