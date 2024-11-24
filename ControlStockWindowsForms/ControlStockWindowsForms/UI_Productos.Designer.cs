namespace ControlStockWindowsForms
{
    partial class UI_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Productos));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            GridViewProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            proveedorID = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 68);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 62);
            button4.TabIndex = 4;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 62);
            button3.TabIndex = 6;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 62);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GridViewProductos
            // 
            GridViewProductos.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewProductos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, precio, cantidad, descripcion, proveedorID, proveedor });
            GridViewProductos.Dock = DockStyle.Fill;
            GridViewProductos.Location = new Point(0, 0);
            GridViewProductos.Name = "GridViewProductos";
            GridViewProductos.RowHeadersWidth = 51;
            GridViewProductos.Size = new Size(832, 435);
            GridViewProductos.TabIndex = 1;
            GridViewProductos.CellContentClick += GridViewProductos_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
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
            // UI_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(GridViewProductos);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI_Productos";
            Text = "ADMINISTRADOR DE PRODUCTOS";
            Load += UI_Productos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView GridViewProductos;
        private Button button3;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn proveedorID;
        private DataGridViewTextBoxColumn proveedor;
        private Button button4;
    }
}