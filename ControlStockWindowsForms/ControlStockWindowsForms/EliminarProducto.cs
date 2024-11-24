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
    public partial class EliminarProducto : Form
    {
        Accion _accion;
        Producto producto;
        int id;
        public EliminarProducto(Producto productoSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            producto = productoSeleccionado;
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Baja)
            {
                CargarDatosProducto();
                //CargarTablaProductos();
            }
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
        private void CargarDatosProducto()
        {
            textBoxIdProductoAEliminar.Text = producto.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos del id
                id = Int32.Parse(textBoxIdProductoAEliminar.Text);
                eliminarProducto();
                // Si el registro fue exitoso, cerrar el formulario con DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el producto: {ex.Message}");
                this.DialogResult = DialogResult.None;  // Mantener el formulario abierto si hay un error
            }
        }

        public async void eliminarProducto()
        {
            string apiUrl = $"https://localhost:7177/Producto/EliminarProducto?_id={id}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Enviar el `id` a la API mediante una solicitud DELETE
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void GridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
