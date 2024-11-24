namespace ControlStockWindowsForms
{
    partial class ModificarProducto
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
            menuStrip1 = new MenuStrip();
            guardarCambiosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            textBoxIdProvProducto = new TextBox();
            textBoxDescripcionProducto = new TextBox();
            textBoxCantidadProducto = new TextBox();
            textBoxPrecioProducto = new TextBox();
            textBoxNombreProducto = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            textBoxIdProductoAModificar = new TextBox();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { guardarCambiosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // guardarCambiosToolStripMenuItem
            // 
            guardarCambiosToolStripMenuItem.Image = Properties.Resources.guardar;
            guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            guardarCambiosToolStripMenuItem.Size = new Size(158, 24);
            guardarCambiosToolStripMenuItem.Text = "Guardar Cambios";
            guardarCambiosToolStripMenuItem.Click += guardarCambiosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(textBoxIdProvProducto);
            panel1.Controls.Add(textBoxDescripcionProducto);
            panel1.Controls.Add(textBoxCantidadProducto);
            panel1.Controls.Add(textBoxPrecioProducto);
            panel1.Controls.Add(textBoxNombreProducto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxIdProductoAModificar);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 422);
            panel1.TabIndex = 1;
            // 
            // textBoxIdProvProducto
            // 
            textBoxIdProvProducto.Location = new Point(128, 218);
            textBoxIdProvProducto.Name = "textBoxIdProvProducto";
            textBoxIdProvProducto.Size = new Size(409, 27);
            textBoxIdProvProducto.TabIndex = 26;
            // 
            // textBoxDescripcionProducto
            // 
            textBoxDescripcionProducto.Location = new Point(128, 178);
            textBoxDescripcionProducto.Name = "textBoxDescripcionProducto";
            textBoxDescripcionProducto.Size = new Size(409, 27);
            textBoxDescripcionProducto.TabIndex = 25;
            // 
            // textBoxCantidadProducto
            // 
            textBoxCantidadProducto.Location = new Point(128, 138);
            textBoxCantidadProducto.Name = "textBoxCantidadProducto";
            textBoxCantidadProducto.Size = new Size(409, 27);
            textBoxCantidadProducto.TabIndex = 24;
            // 
            // textBoxPrecioProducto
            // 
            textBoxPrecioProducto.Location = new Point(128, 100);
            textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            textBoxPrecioProducto.Size = new Size(409, 27);
            textBoxPrecioProducto.TabIndex = 23;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(128, 62);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(409, 27);
            textBoxNombreProducto.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 21;
            label4.Text = "IDProveedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 181);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 20;
            label1.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 18;
            label2.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 65);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 17;
            label6.Text = "Nombre:";
            // 
            // textBoxIdProductoAModificar
            // 
            textBoxIdProductoAModificar.Location = new Point(269, 19);
            textBoxIdProductoAModificar.Name = "textBoxIdProductoAModificar";
            textBoxIdProductoAModificar.Size = new Size(268, 27);
            textBoxIdProductoAModificar.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 22);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 15;
            label5.Text = "Id de Producto a Modrificar:";
            label5.Click += label5_Click;
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ModificarProducto";
            Text = "ModificarProducto";
            Load += ModificarProducto_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private Panel panel1;
        private TextBox textBoxIdProductoAModificar;
        private Label label5;
        private TextBox textBoxIdProvProducto;
        private TextBox textBoxDescripcionProducto;
        private TextBox textBoxCantidadProducto;
        private TextBox textBoxPrecioProducto;
        private TextBox textBoxNombreProducto;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}