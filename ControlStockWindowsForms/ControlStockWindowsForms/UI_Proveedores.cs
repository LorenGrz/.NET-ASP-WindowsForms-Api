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
    public partial class UI_Proveedores : Form
    {
        public UI_Proveedores()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UI_Proveedorescs_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private async void CargarProveedores()
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

        private void GridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            RegistroProveedor frm = new RegistroProveedor(p, Enumeradores.Accion.Alta);
            var result = frm.ShowDialog();

            // Si el formulario se cerró y el resultado es OK, recargar la grilla
            if (result == DialogResult.OK)
            {
                CargarProveedores();  // Llamar al método que recarga la grilla
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            ModificarProveedor frm = new ModificarProveedor(p, Enumeradores.Accion.Modificacion);
            var result = frm.ShowDialog();

            // Si el formulario se cerró y el resultado es OK, recargar la grilla
            if (result == DialogResult.OK)
            {
                CargarProveedores();  // Llamar al método que recarga la grilla
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            EliminarProveedor frm = new EliminarProveedor(p, Enumeradores.Accion.Baja);
            var result = frm.ShowDialog();

            // Si el formulario se cerró y el resultado es OK, recargar la grilla
            if (result == DialogResult.OK)
            {
                CargarProveedores();  // Llamar al método que recarga la grilla
            }
        }
    }
}