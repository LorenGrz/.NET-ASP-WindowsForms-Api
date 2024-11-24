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

namespace ControlStockWindowsForms
{
    public partial class UI_Ventas : Form
    {
        public UI_Ventas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UI_Ventas_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Venta p = new Venta();
            RegistroVentas frm = new RegistroVentas(p, Enumeradores.Accion.Alta);
            var result = frm.ShowDialog();

            // Si el formulario se cerró y el resultado es OK, recargar la grilla
            //if (result == DialogResult.OK)
            //{
            //   CargarProveedores();  // Llamar al método que recarga la grilla
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta p = new Venta();
            EliminarVenta frm = new EliminarVenta(p, Enumeradores.Accion.Alta);
            var result = frm.ShowDialog();
        }
    }
}
