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
    public partial class ModificarProveedor : Form
    {
        Accion _accion;
        Proveedor proveedor;
        int id;
        public ModificarProveedor(Proveedor proveedorSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            proveedor = proveedorSeleccionado;
            InitializeComponent();
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Modificacion)
            {
                CargarDatosProveedor();
                //CargarTablaProductos();
            }
        }
        private void CargarDatosProveedor()
        {
            textBoxIdProveedorModificar.Text = proveedor.Id.ToString();
            textBoxNombreProveedor.Text = proveedor.Nombre;
            textBoxEmailProveedor.Text = proveedor.Email;
            textBoxDireccionProveedor.Text = proveedor.Direccion;
            textBoxTelefonoProveedor.Text = proveedor.Telefono;
        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los datos del proveedor
                id = Int32.Parse(textBoxIdProveedorModificar.Text);
                proveedor.Nombre = textBoxNombreProveedor.Text;
                proveedor.Email = textBoxEmailProveedor.Text;
                proveedor.Direccion = textBoxDireccionProveedor.Text;
                proveedor.Telefono = textBoxTelefonoProveedor.Text;
                modificarProveedor(id);
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

        public async void modificarProveedor(int id)
        {
            string apiUrl = $"https://localhost:7177/Proveedor/ModificarProveedor?_id={id}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProveedor = JsonConvert.SerializeObject(proveedor); //??
                    var content = new StringContent(jsonProveedor, Encoding.UTF8, "application/json");

                    // Enviar el proveedor a la API mediante POST
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                    Console.WriteLine(jsonProveedor); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Proveedor modificado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el proveedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
