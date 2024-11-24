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
    public partial class ModificarProducto : Form
    {
        Accion _accion;
        Producto producto;
        int id;
        public ModificarProducto(Producto productoSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            producto = productoSeleccionado;
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            if (_accion != Accion.Modificacion)
            {
                CargarDatosProducto();
                //CargarTablaProductos();
            }
        }
        private void CargarDatosProducto()
        {
            textBoxIdProductoAModificar.Text = producto.Id.ToString();
            textBoxNombreProducto.Text = producto.Nombre;
            textBoxPrecioProducto.Text = producto.Precio.ToString();
            textBoxCantidadProducto.Text = producto.Cantidad.ToString();
            textBoxDescripcionProducto.Text = producto.Descripcion;
            textBoxIdProvProducto.Text = producto.ProveedorID.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            try
            {
                // Actualizar los datos del proveedor
                id = Int32.Parse(textBoxIdProductoAModificar.Text);
                producto.Nombre = textBoxNombreProducto.Text;
                producto.Precio = Decimal.Parse(textBoxPrecioProducto.Text);
                producto.Cantidad = Int32.Parse(textBoxCantidadProducto.Text);
                producto.Descripcion = textBoxDescripcionProducto.Text;
                producto.ProveedorID = Int32.Parse(textBoxIdProvProducto.Text);
                modificarProducto(id);
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

        public async void modificarProducto(int id)
        {
            string apiUrl = $"https://localhost:7177/Producto/ModificarProducto?_id={id}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProveedor = JsonConvert.SerializeObject(producto); //??
                    var content = new StringContent(jsonProveedor, Encoding.UTF8, "application/json");

                    // Enviar el proveedor a la API mediante POST
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                    Console.WriteLine(jsonProveedor); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto modificado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el producto.");
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
