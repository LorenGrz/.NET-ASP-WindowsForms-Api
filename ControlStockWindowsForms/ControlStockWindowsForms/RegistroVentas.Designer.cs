namespace ControlStockWindowsForms
{
    partial class RegistroVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVentas));
            menuStrip1 = new MenuStrip();
            guardarVentaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            textBoxCantidadVendidaVentas = new TextBox();
            textBoxIdDelProductoVentas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { guardarVentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // guardarVentaToolStripMenuItem
            // 
            guardarVentaToolStripMenuItem.Image = Properties.Resources.guardar;
            guardarVentaToolStripMenuItem.Name = "guardarVentaToolStripMenuItem";
            guardarVentaToolStripMenuItem.Size = new Size(137, 24);
            guardarVentaToolStripMenuItem.Text = "Guardar Venta";
            guardarVentaToolStripMenuItem.Click += guardarVentaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(textBoxCantidadVendidaVentas);
            panel1.Controls.Add(textBoxIdDelProductoVentas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 422);
            panel1.TabIndex = 1;
            // 
            // textBoxCantidadVendidaVentas
            // 
            textBoxCantidadVendidaVentas.Location = new Point(173, 59);
            textBoxCantidadVendidaVentas.Name = "textBoxCantidadVendidaVentas";
            textBoxCantidadVendidaVentas.Size = new Size(161, 27);
            textBoxCantidadVendidaVentas.TabIndex = 5;
            // 
            // textBoxIdDelProductoVentas
            // 
            textBoxIdDelProductoVentas.Location = new Point(173, 18);
            textBoxIdDelProductoVentas.Name = "textBoxIdDelProductoVentas";
            textBoxIdDelProductoVentas.Size = new Size(161, 27);
            textBoxIdDelProductoVentas.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad Vendida:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Id Del Producto:";
            // 
            // RegistroVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "RegistroVentas";
            Text = "RegistroVentas";
            Load += RegistroVentas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarVentaToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxCantidadVendidaVentas;
        private TextBox textBoxIdDelProductoVentas;
    }
}