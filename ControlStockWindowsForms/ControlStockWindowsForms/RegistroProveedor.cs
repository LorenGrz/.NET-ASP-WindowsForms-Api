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
    public partial class RegistroProveedor : Form
    {
        Accion _accion;
        Proveedor proveedor;
        public RegistroProveedor(Proveedor proveedorSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            proveedor = proveedorSeleccionado;
            InitializeComponent();
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Alta)
            {
                CargarDatosProveedor();
            }
        }

        private void CargarDatosProveedor()
        {
            textBoxNombreProveedor.Text = proveedor.Nombre;
            textBoxEmailProveedor.Text = proveedor.Email;
            textBoxDireccionProveedor.Text = proveedor.Direccion;
            textBoxTelefonoProveedor.Text = proveedor.Telefono;

            //CargarProductosDelProveedor(proveedor);
        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos del proveedor
                proveedor.Nombre = textBoxNombreProveedor.Text;
                proveedor.Email = textBoxEmailProveedor.Text;
                proveedor.Direccion = textBoxDireccionProveedor.Text;
                proveedor.Telefono = textBoxTelefonoProveedor.Text;
                guardarProveedor();
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
       
        public async void guardarProveedor()
        {
            string apiUrl = "https://localhost:7177/Proveedor/RegistrarProveedor";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProveedor = JsonConvert.SerializeObject(proveedor);
                    var content = new StringContent(jsonProveedor, Encoding.UTF8, "application/json");

                    // Enviar el proveedor a la API mediante POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    Console.WriteLine(jsonProveedor); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el proveedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

    }
}