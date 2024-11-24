namespace ControlStockWindowsForms
{
    partial class EliminarProveedor
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
            GridViewProveedores = new DataGridView();
            button1 = new Button();
            textBoxIdProveedorAEliminar = new TextBox();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 8;
            label1.Text = "Id de Proveedor a Eliminar:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(GridViewProveedores);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxIdProveedorAEliminar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 7;
            // 
            // GridViewProveedores
            // 
            GridViewProveedores.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewProveedores.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Email, Direccion, Telefono, Productos });
            GridViewProveedores.Dock = DockStyle.Bottom;
            GridViewProveedores.Location = new Point(0, 40);
            GridViewProveedores.Name = "GridViewProveedores";
            GridViewProveedores.RowHeadersWidth = 51;
            GridViewProveedores.Size = new Size(800, 410);
            GridViewProveedores.TabIndex = 8;
            GridViewProveedores.CellContentClick += GridViewProveedores_CellContentClick;
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
            // textBoxIdProveedorAEliminar
            // 
            textBoxIdProveedorAEliminar.Location = new Point(206, 6);
            textBoxIdProveedorAEliminar.Name = "textBoxIdProveedorAEliminar";
            textBoxIdProveedorAEliminar.Size = new Size(125, 27);
            textBoxIdProveedorAEliminar.TabIndex = 5;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Productos
            // 
            Productos.DataPropertyName = "Productos";
            Productos.HeaderText = "Productos";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            Productos.Visible = false;
            Productos.Width = 125;
            // 
            // EliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EliminarProveedor";
            Text = "EliminarProveedor";
            Load += EliminarProveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox textBoxIdProveedorAEliminar;
        private DataGridView GridViewProveedores;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Productos;
    }
}