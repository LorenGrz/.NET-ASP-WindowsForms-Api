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
    public partial class RegistroProductos : Form
    {
        Accion _accion;
        private Producto producto;
        private ProductoAPilas productoAPilas;
        private ProductoElectronico productoElectronico;

        public RegistroProductos(Producto productoSeleccionado, Accion accionSeleccionada)
        {
            _accion = accionSeleccionada;
            InitializeComponent();
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            comboBoxTipoPilas.DataSource = Enum.GetValues(typeof(TipoPilas));
            textBoxCantPilas.Enabled = false;
            comboBoxTipoPilas.Enabled = false;
            checkBoxTransformador.Enabled = false;
            textBoxVoltaje.Enabled = false;

            if (_accion != Accion.Alta)
            {
                CargarDatosProducto();
                //CargarTablaProductos();
            }
        }
        private void CargarDatosProducto()
        {
            textBoxNombreProducto.Text = producto.Nombre;
            textBoxPrecioProducto.Text = producto.Precio.ToString();
            textBoxCantidadProducto.Text = producto.Cantidad.ToString();
            textBoxDescripcionProducto.Text = producto.Descripcion;
            textBoxIdProvProducto.Text = producto.ProveedorID.ToString();
        }

        private void guardarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxAPilas.Checked)
                {
                    productoAPilas = new ProductoAPilas
                    {
                        Nombre = textBoxNombreProducto.Text,
                        Precio = decimal.Parse(textBoxPrecioProducto.Text),
                        Cantidad = int.Parse(textBoxCantidadProducto.Text),
                        Descripcion = textBoxDescripcionProducto.Text,
                        ProveedorID = Int32.Parse(textBoxIdProvProducto.Text),
                        CantPilas = int.Parse(textBoxCantPilas.Text),
                        Tipo = (TipoPilas)comboBoxTipoPilas.SelectedItem
                    };
                    guardarProductoAPilas(productoAPilas);
                }
                // Verificar si es un producto electrónico
                else if (checkBoxElectrico.Checked)
                {
                    productoElectronico = new ProductoElectronico
                    {
                        Nombre = textBoxNombreProducto.Text,
                        Precio = decimal.Parse(textBoxPrecioProducto.Text),
                        Cantidad = int.Parse(textBoxCantidadProducto.Text),
                        Descripcion = textBoxDescripcionProducto.Text,
                        ProveedorID = Int32.Parse(textBoxIdProvProducto.Text),
                        Voltaje = decimal.Parse(textBoxVoltaje.Text),
                        Transformador = checkBoxTransformador.Checked
                    };
                    guardarProductoElectronico(productoElectronico);
                }
                // Producto convencional
                else
                {
                    producto = new Producto
                    {      
                        // Actualizar los datos del Producto
                        Nombre = textBoxNombreProducto.Text,
                        Precio = Decimal.Parse(textBoxPrecioProducto.Text),
                        Cantidad = Int32.Parse(textBoxCantidadProducto.Text),
                        Descripcion = textBoxDescripcionProducto.Text,
                        ProveedorID = Int32.Parse(textBoxIdProvProducto.Text)
                        // Aquí puedes implementar la lógica para guardar los cambios en la base de datos o en tu lista
                        
                    };
                    guardarProducto(producto);
                }
         

                // Si el registro fue exitoso, cerrar el formulario con DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el Producto: {ex.Message}");
                this.DialogResult = DialogResult.None;  // Mantener el formulario abierto si hay un error
            }
        }
        public async void guardarProducto(Producto producto)
        {
            string apiUrl = "http://localhost:7177/Producto/RegistrarProducto";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProducto = JsonConvert.SerializeObject(producto);
                    var content = new StringContent(jsonProducto, Encoding.UTF8, "application/json");

                    // Enviar el producto a la API mediante POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    Console.WriteLine(jsonProducto); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar El Producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        public async void guardarProductoElectronico(ProductoElectronico producto)
        {
            string apiUrl = "http://localhost:7177/ProductoElectronico/RegistrarProductoElectronico";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProducto = JsonConvert.SerializeObject(producto);
                    var content = new StringContent(jsonProducto, Encoding.UTF8, "application/json");

                    // Enviar el producto a la API mediante POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    Console.WriteLine(jsonProducto); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar El Producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        public async void guardarProductoAPilas(ProductoAPilas producto)
        {
            string apiUrl = "http://localhost:7177/ProductoAPilas/RegistrarProductoAPilas";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Serializar el objeto a JSON
                    var jsonProducto = JsonConvert.SerializeObject(producto);
                    var content = new StringContent(jsonProducto, Encoding.UTF8, "application/json");

                    // Enviar el producto a la API mediante POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    Console.WriteLine(jsonProducto); // Verifica el JSON
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar El Producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }


        private void checkBoxAPilas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAPilas.Checked)
            {
                checkBoxElectrico.Checked = false;
            }

            textBoxCantPilas.Enabled = checkBoxAPilas.Checked;
            comboBoxTipoPilas.Enabled = checkBoxAPilas.Checked;

            if (!checkBoxAPilas.Checked)
            {
                textBoxCantPilas.Text = string.Empty;
                comboBoxTipoPilas.Text = string.Empty;
            }
        }

        private void checkBoxElectrico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxElectrico.Checked)
            {
                checkBoxAPilas.Checked = false;
            }

            checkBoxTransformador.Enabled = checkBoxElectrico.Checked;
            textBoxVoltaje.Enabled = checkBoxElectrico.Checked;

            if (!checkBoxElectrico.Checked)
            {
                textBoxVoltaje.Text = string.Empty;
            }
        }
    }
}
