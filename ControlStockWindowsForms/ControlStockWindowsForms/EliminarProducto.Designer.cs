namespace ControlStockWindowsForms
{
    partial class EliminarProducto
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
            label1 = new Label();
            panel1 = new Panel();
            GridViewProductos = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            proveedorID = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxIdProductoAEliminar = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 11;
            label1.Text = "Id de Producto a Eliminar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(GridViewProductos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxIdProductoAEliminar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 10;
            // 
            // GridViewProductos
            // 
            GridViewProductos.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewProductos.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, cantidad, descripcion, proveedorID, proveedor });
            GridViewProductos.Dock = DockStyle.Bottom;
            GridViewProductos.Location = new Point(0, 40);
            GridViewProductos.Name = "GridViewProductos";
            GridViewProductos.RowHeadersWidth = 51;
            GridViewProductos.Size = new Size(800, 410);
            GridViewProductos.TabIndex = 8;
            GridViewProductos.CellContentClick += GridViewProductos_CellContentClick;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // precio
            // 
            precio.DataPropertyName = "precio";
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // proveedorID
            // 
            proveedorID.DataPropertyName = "proveedorID";
            proveedorID.HeaderText = "proveedorID";
            proveedorID.MinimumWidth = 6;
            proveedorID.Name = "proveedorID";
            proveedorID.Visible = false;
            proveedorID.Width = 125;
            // 
            // proveedor
            // 
            proveedor.DataPropertyName = "proveedor";
            proveedor.HeaderText = "Proveedor";
            proveedor.MinimumWidth = 6;
            proveedor.Name = "proveedor";
            proveedor.Visible = false;
            proveedor.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(337, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxIdProductoAEliminar
            // 
            textBoxIdProductoAEliminar.Location = new Point(206, 6);
            textBoxIdProductoAEliminar.Name = "textBoxIdProductoAEliminar";
            textBoxIdProductoAEliminar.Size = new Size(125, 27);
            textBoxIdProductoAEliminar.TabIndex = 5;
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            Load += EliminarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox textBoxIdProductoAEliminar;
        private DataGridView GridViewProductos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn proveedorID;
        private DataGridViewTextBoxColumn proveedor;
    }
}