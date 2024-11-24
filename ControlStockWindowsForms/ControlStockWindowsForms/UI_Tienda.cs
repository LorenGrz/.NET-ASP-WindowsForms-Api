using ProyectoCompartido;
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
    public partial class UI_Tienda : Form
    {
        public UI_Tienda()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Proveedores frm = new UI_Proveedores();
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Productos frm = new UI_Productos();
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Ventas frm = new UI_Ventas();
            frm.Show();
        }

        private void UI_Tienda_Load(object sender, EventArgs e)
        {

        }
    }
}
