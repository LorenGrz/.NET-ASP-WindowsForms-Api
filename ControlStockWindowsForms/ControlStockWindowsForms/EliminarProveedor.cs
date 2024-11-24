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
    public partial class EliminarProveedor : Form
    {
        Accion _accion;
        Proveedor proveedor;
        public EliminarProveedor(Proveedor proveedorSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            proveedor = proveedorSeleccionado;
            InitializeComponent();
        }

        private void EliminarProveedor_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Baja)
            {
                CargarDatosProveedor();
                //CargarTablaProductos();
            }
            ActualizarGrilla();
        }


        public async void ActualizarGrilla()
        {
            string urlApi = "https://localhost:7177/Proveedor/ListarProveedores";
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
                        List<Proveedor> proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(jsonResponse);
                        GridViewProveedores.DataSource = proveedores;
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar los proveedores desde la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores desde la base de datos");
            }
        }

        private void CargarDatosProveedor()
        {
            textBoxIdProveedorAEliminar.Text = proveedor.Id.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(textBoxIdProveedorAEliminar.Text);
                if (await tieneProductos(id))
                {
                    MessageBox.Show("Se eliminaran los productos del Proveedor seleccionado.");
                    eliminarProductosDelProveedor(id);
                }
                    // Actualizar los datos del proveedor
                    eliminarProveedor(id);
                    // Si el registro fue exitoso, cerrar el formulario con DialogResult.OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();     
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el proveedor: {ex.Message}");
                this.DialogResult = DialogResult.None;  // Mantener el formulario abierto si hay un error
            }
        }

        public async Task<bool> tieneProductos(int id) 
        {
            string apiUrl = $"https://localhost:7177/Proveedor/TieneProductos?_id={id}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Realizar la solicitud GET a la API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Comprobar si la respuesta es exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer y deserializar el valor booleano de la respuesta
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return bool.Parse(responseBody); // Convertir el string "true" o "false" a bool
                    }
                    else
                    {
                        MessageBox.Show("Error al verificar productos: " + response.StatusCode);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public async void eliminarProductosDelProveedor(int id)    
        {
            string apiUrl = $"https://localhost:7177/Proveedor/EliminarProductosDelProveedor?_id={id}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Enviar el `id` a la API mediante una solicitud DELETE
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Productos eliminados con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar los productos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        public async void eliminarProveedor(int id)
        {
            string apiUrl = $"https://localhost:7177/Proveedor/EliminarProveedor?_id={id}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Enviar el `id` a la API mediante una solicitud DELETE
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
