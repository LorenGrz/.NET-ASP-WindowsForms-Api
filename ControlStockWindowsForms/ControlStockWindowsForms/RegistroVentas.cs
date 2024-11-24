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
    public partial class RegistroVentas : Form
    {
        Accion _accion;
        Venta venta;
        public RegistroVentas(Venta ventaSeleccionada, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            venta = ventaSeleccionada;
            InitializeComponent();
        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Alta)
            {
                CargarDatosVenta();
                //CargarTablaProductos();
            }
        }
        private void CargarDatosVenta()
        {
            textBoxIdDelProductoVentas.Text = venta.IdProducto.ToString();
            textBoxCantidadVendidaVentas.Text = venta.CantidadVendida.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guardarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos del proveedor
                venta.IdProducto = Int32.Parse(textBoxIdDelProductoVentas.Text);
                venta.CantidadVendida = Int32.Parse(textBoxCantidadVendidaVentas.Text);
                // Aquí puedes implementar la lógica para guardar los cambios en la base de datos o en tu lista
                guardarVenta();

                // Si el registro fue exitoso, cerrar el formulario con DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
                this.DialogResult = DialogResult.None;  // Mantener el formulario abierto si hay un error
            }
        }
        public async void guardarVenta()
        {
            string apiUrl = "http://localhost:7177/Ventas/RegistrarVenta";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonVenta = JsonConvert.SerializeObject(venta);
                    var content = new StringContent(jsonVenta, Encoding.UTF8, "application/json");

                    // Enviar el proveedor a la API mediante POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    Console.WriteLine(jsonVenta); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la Venta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
