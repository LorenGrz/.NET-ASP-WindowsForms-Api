namespace ControlStockWindowsForms
{
    partial class RegistroProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProveedor));
            menuStrip2 = new MenuStrip();
            guardarCambiosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            textBoxEmailProveedor = new TextBox();
            textBoxDireccionProveedor = new TextBox();
            textBoxTelefonoProveedor = new TextBox();
            textBoxNombreProveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { guardarCambiosToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // guardarCambiosToolStripMenuItem
            // 
            guardarCambiosToolStripMenuItem.Image = Properties.Resources.guardar;
            guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            guardarCambiosToolStripMenuItem.Size = new Size(168, 24);
            guardarCambiosToolStripMenuItem.Text = "Guardar Proveedor";
            guardarCambiosToolStripMenuItem.Click += guardarCambiosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(textBoxEmailProveedor);
            panel1.Controls.Add(textBoxDireccionProveedor);
            panel1.Controls.Add(textBoxTelefonoProveedor);
            panel1.Controls.Add(textBoxNombreProveedor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 422);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // textBoxEmailProveedor
            // 
            textBoxEmailProveedor.Location = new Point(106, 53);
            textBoxEmailProveedor.Name = "textBoxEmailProveedor";
            textBoxEmailProveedor.Size = new Size(409, 27);
            textBoxEmailProveedor.TabIndex = 2;
            // 
            // textBoxDireccionProveedor
            // 
            textBoxDireccionProveedor.Location = new Point(106, 93);
            textBoxDireccionProveedor.Name = "textBoxDireccionProveedor";
            textBoxDireccionProveedor.Size = new Size(409, 27);
            textBoxDireccionProveedor.TabIndex = 3;
            // 
            // textBoxTelefonoProveedor
            // 
            textBoxTelefonoProveedor.Location = new Point(106, 132);
            textBoxTelefonoProveedor.Name = "textBoxTelefonoProveedor";
            textBoxTelefonoProveedor.Size = new Size(409, 27);
            textBoxTelefonoProveedor.TabIndex = 4;
            // 
            // textBoxNombreProveedor
            // 
            textBoxNombreProveedor.Location = new Point(106, 13);
            textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            textBoxNombreProveedor.Size = new Size(409, 27);
            textBoxNombreProveedor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // RegistroProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistroProveedor";
            Text = "RegistroProveedor";
            Load += RegistroProveedor_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxEmailProveedor;
        private TextBox textBoxDireccionProveedor;
        private TextBox textBoxTelefonoProveedor;
        private TextBox textBoxNombreProveedor;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}