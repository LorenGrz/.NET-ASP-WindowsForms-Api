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
    public partial class UI_Productos : Form
    {
        public UI_Productos()
        {
            InitializeComponent();
        }

        private async void UI_Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private async void CargarProductos()
        {
            string urlApi = "https://localhost:7177/Producto/ListarProductos";
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
                        List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(jsonResponse);
                        GridViewProductos.DataSource = productos;
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar los productos desde la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos desde la base de datos");
            }
        }

        private void GridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            RegistroProductos frm = new RegistroProductos(p, Enumeradores.Accion.Alta);
            var result = frm.ShowDialog();

            // Si el formulario se cerró y el resultado es OK, recargar la grilla
            //if (result == DialogResult.OK)
            //{
            //   CargarProveedores();  // Llamar al método que recarga la grilla
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            ModificarProducto frm = new ModificarProducto(p, Enumeradores.Accion.Modificacion);
            var result = frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            EliminarProducto frm = new EliminarProducto(p, Enumeradores.Accion.Baja);
            var result = frm.ShowDialog();
        }
    }
}
