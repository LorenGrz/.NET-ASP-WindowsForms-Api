namespace ControlStockWindowsForms
{
    partial class RegistroProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            menuStrip1 = new MenuStrip();
            guardarProductoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            comboBoxTipoPilas = new ComboBox();
            label9 = new Label();
            checkBoxTransformador = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxCantPilas = new TextBox();
            textBoxVoltaje = new TextBox();
            checkBoxAPilas = new CheckBox();
            checkBoxElectrico = new CheckBox();
            textBoxIdProvProducto = new TextBox();
            textBoxDescripcionProducto = new TextBox();
            textBoxCantidadProducto = new TextBox();
            textBoxPrecioProducto = new TextBox();
            textBoxNombreProducto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { guardarProductoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // guardarProductoToolStripMenuItem
            // 
            guardarProductoToolStripMenuItem.Image = Properties.Resources.guardar;
            guardarProductoToolStripMenuItem.Name = "guardarProductoToolStripMenuItem";
            guardarProductoToolStripMenuItem.Size = new Size(160, 24);
            guardarProductoToolStripMenuItem.Text = "Guardar Producto";
            guardarProductoToolStripMenuItem.Click += guardarProductoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(comboBoxTipoPilas);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(checkBoxTransformador);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxCantPilas);
            panel1.Controls.Add(textBoxVoltaje);
            panel1.Controls.Add(checkBoxAPilas);
            panel1.Controls.Add(checkBoxElectrico);
            panel1.Controls.Add(textBoxIdProvProducto);
            panel1.Controls.Add(textBoxDescripcionProducto);
            panel1.Controls.Add(textBoxCantidadProducto);
            panel1.Controls.Add(textBoxPrecioProducto);
            panel1.Controls.Add(textBoxNombreProducto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 422);
            panel1.TabIndex = 1;
            // 
            // comboBoxTipoPilas
            // 
            comboBoxTipoPilas.FormattingEnabled = true;
            comboBoxTipoPilas.Location = new Point(142, 376);
            comboBoxTipoPilas.Name = "comboBoxTipoPilas";
            comboBoxTipoPilas.Size = new Size(151, 28);
            comboBoxTipoPilas.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 283);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 21;
            label9.Text = "Voltaje:";
            // 
            // checkBoxTransformador
            // 
            checkBoxTransformador.AutoSize = true;
            checkBoxTransformador.Location = new Point(169, 250);
            checkBoxTransformador.Name = "checkBoxTransformador";
            checkBoxTransformador.Size = new Size(18, 17);
            checkBoxTransformador.TabIndex = 20;
            checkBoxTransformador.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 247);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 19;
            label8.Text = "Posee Transformador:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 379);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 18;
            label7.Text = "Tipo de Pilas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 346);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 17;
            label6.Text = "Cantidad de Pilas:";
            // 
            // textBoxCantPilas
            // 
            textBoxCantPilas.Location = new Point(142, 343);
            textBoxCantPilas.Name = "textBoxCantPilas";
            textBoxCantPilas.Size = new Size(125, 27);
            textBoxCantPilas.TabIndex = 15;
            // 
            // textBoxVoltaje
            // 
            textBoxVoltaje.Location = new Point(142, 280);
            textBoxVoltaje.Name = "textBoxVoltaje";
            textBoxVoltaje.Size = new Size(125, 27);
            textBoxVoltaje.TabIndex = 14;
            // 
            // checkBoxAPilas
            // 
            checkBoxAPilas.AutoSize = true;
            checkBoxAPilas.Location = new Point(142, 313);
            checkBoxAPilas.Name = "checkBoxAPilas";
            checkBoxAPilas.Size = new Size(98, 24);
            checkBoxAPilas.TabIndex = 12;
            checkBoxAPilas.Text = "Es a Pilas?";
            checkBoxAPilas.UseVisualStyleBackColor = true;
            checkBoxAPilas.CheckedChanged += checkBoxAPilas_CheckedChanged;
            // 
            // checkBoxElectrico
            // 
            checkBoxElectrico.AutoSize = true;
            checkBoxElectrico.Location = new Point(142, 217);
            checkBoxElectrico.Name = "checkBoxElectrico";
            checkBoxElectrico.Size = new Size(113, 24);
            checkBoxElectrico.TabIndex = 11;
            checkBoxElectrico.Text = "Es Electrico?";
            checkBoxElectrico.UseVisualStyleBackColor = true;
            checkBoxElectrico.CheckedChanged += checkBoxElectrico_CheckedChanged;
            // 
            // textBoxIdProvProducto
            // 
            textBoxIdProvProducto.Location = new Point(142, 168);
            textBoxIdProvProducto.Name = "textBoxIdProvProducto";
            textBoxIdProvProducto.Size = new Size(409, 27);
            textBoxIdProvProducto.TabIndex = 10;
            // 
            // textBoxDescripcionProducto
            // 
            textBoxDescripcionProducto.Location = new Point(142, 128);
            textBoxDescripcionProducto.Name = "textBoxDescripcionProducto";
            textBoxDescripcionProducto.Size = new Size(409, 27);
            textBoxDescripcionProducto.TabIndex = 9;
            // 
            // textBoxCantidadProducto
            // 
            textBoxCantidadProducto.Location = new Point(142, 88);
            textBoxCantidadProducto.Name = "textBoxCantidadProducto";
            textBoxCantidadProducto.Size = new Size(409, 27);
            textBoxCantidadProducto.TabIndex = 8;
            // 
            // textBoxPrecioProducto
            // 
            textBoxPrecioProducto.Location = new Point(142, 50);
            textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            textBoxPrecioProducto.Size = new Size(409, 27);
            textBoxPrecioProducto.TabIndex = 7;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(142, 12);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(409, 27);
            textBoxNombreProducto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 5;
            label4.Text = "IDProveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // RegistroProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "RegistroProductos";
            Text = "RegistroProductos";
            Load += RegistroProductos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarProductoToolStripMenuItem;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox textBoxIdProvProducto;
        private TextBox textBoxDescripcionProducto;
        private TextBox textBoxCantidadProducto;
        private TextBox textBoxPrecioProducto;
        private TextBox textBoxNombreProducto;
        private CheckBox checkBoxAPilas;
        private CheckBox checkBoxElectrico;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxCantPilas;
        private TextBox textBoxVoltaje;
        private Label label9;
        private CheckBox checkBoxTransformador;
        private ComboBox comboBoxTipoPilas;
    }
}