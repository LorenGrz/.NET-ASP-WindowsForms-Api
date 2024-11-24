namespace ControlStockWindowsForms
{
    partial class ModificarProveedor
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
            textBoxIdProveedorModificar = new TextBox();
            label5 = new Label();
            textBoxEmailProveedor = new TextBox();
            textBoxDireccionProveedor = new TextBox();
            label1 = new Label();
            textBoxTelefonoProveedor = new TextBox();
            label2 = new Label();
            textBoxNombreProveedor = new TextBox();
            label3 = new Label();
            label4 = new Label();
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
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            panel1.Controls.Add(textBoxIdProveedorModificar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxEmailProveedor);
            panel1.Controls.Add(textBoxDireccionProveedor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTelefonoProveedor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNombreProveedor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 422);
            panel1.TabIndex = 1;
            // 
            // textBoxIdProveedorModificar
            // 
            textBoxIdProveedorModificar.Location = new Point(259, 27);
            textBoxIdProveedorModificar.Name = "textBoxIdProveedorModificar";
            textBoxIdProveedorModificar.Size = new Size(264, 27);
            textBoxIdProveedorModificar.TabIndex = 14;
            textBoxIdProveedorModificar.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 30);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 13;
            label5.Text = "Id de Proveedor a Modrificar:";
            // 
            // textBoxEmailProveedor
            // 
            textBoxEmailProveedor.Location = new Point(114, 111);
            textBoxEmailProveedor.Name = "textBoxEmailProveedor";
            textBoxEmailProveedor.Size = new Size(409, 27);
            textBoxEmailProveedor.TabIndex = 8;
            // 
            // textBoxDireccionProveedor
            // 
            textBoxDireccionProveedor.Location = new Point(114, 151);
            textBoxDireccionProveedor.Name = "textBoxDireccionProveedor";
            textBoxDireccionProveedor.Size = new Size(409, 27);
            textBoxDireccionProveedor.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 74);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // textBoxTelefonoProveedor
            // 
            textBoxTelefonoProveedor.Location = new Point(114, 190);
            textBoxTelefonoProveedor.Name = "textBoxTelefonoProveedor";
            textBoxTelefonoProveedor.Size = new Size(409, 27);
            textBoxTelefonoProveedor.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // textBoxNombreProveedor
            // 
            textBoxNombreProveedor.Location = new Point(114, 71);
            textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            textBoxNombreProveedor.Size = new Size(409, 27);
            textBoxNombreProveedor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 151);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 9;
            label3.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 11;
            label4.Text = "Telefono:";
            // 
            // ModificarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ModificarProveedor";
            Text = "ModificarProveedor";
            Load += ModificarProveedor_Load;
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
        private TextBox textBoxIdProveedorModificar;
        private Label label5;
        private TextBox textBoxEmailProveedor;
        private TextBox textBoxDireccionProveedor;
        private Label label1;
        private TextBox textBoxTelefonoProveedor;
        private Label label2;
        private TextBox textBoxNombreProveedor;
        private Label label3;
        private Label label4;
    }
}