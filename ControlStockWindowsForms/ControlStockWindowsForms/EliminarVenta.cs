using ProyectoCompartido;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControlStockWindowsForms.Enumeradores;

namespace ControlStockWindowsForms
{
    public partial class EliminarVenta : Form
    {
        Accion _accion;
        Venta venta;
        int id;

        public EliminarVenta(Venta ventaSeleccionada, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            venta = ventaSeleccionada;
            InitializeComponent();
        }

        private void EliminarVenta_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Baja)
            {
                CargarDatosVenta();
                //CargarTablaProductos();
            }
            CargarVentas();
        }
        private async void CargarVentas()
        {
            string urlApi = "https://localhost:7177/Ventas/ListarVentas";
            try
            {
                // Crear instancia de cliente httpClient
                using (HttpClient client = new HttpClient())
                {
                    // Hacer solicitud get
                    HttpResponseMessage response = await client.GetAsync(urlApi);
                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer el contenido de la respuesta como string
                        var jsonResponse = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON en una lista de objetos
                        List<Venta> ventas = JsonConvert.DeserializeObject<List<Venta>>(jsonResponse);
                        GridViewVentas.DataSource = ventas;
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar las ventas desde la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas desde la base de datos");
            }
        }
        private void CargarDatosVenta()
        {
            textBoxIdVentaAEliminar.Text = venta.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos del venta
                id = Int32.Parse(textBoxIdVentaAEliminar.Text);
                eliminarVenta();
                // Si el registro fue exitoso, cerrar el formulario con DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el venta: {ex.Message}");
                this.DialogResult = DialogResult.None;  // Mantener el formulario abierto si hay un error
            }
        }

        public async void eliminarVenta()
        {
            string apiUrl = $"https://localhost:7177/Venta/EliminarVenta?_id={id}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Enviar el `id` a la API mediante una solicitud DELETE
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el venta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void GridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
