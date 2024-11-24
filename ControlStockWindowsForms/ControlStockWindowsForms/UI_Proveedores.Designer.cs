namespace ControlStockWindowsForms
{
    partial class UI_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Proveedores));
            panel1 = new Panel();
            button1 = new Button();
            BtnEliminar = new Button();
            BtnModificar = new Button();
            GridViewProveedores = new DataGridView();
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnModificar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 68);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 62);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(202, 3);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 62);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(103, 3);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(93, 62);
            BtnModificar.TabIndex = 3;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // GridViewProveedores
            // 
            GridViewProveedores.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewProveedores.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Email, Direccion, Telefono, Productos });
            GridViewProveedores.Dock = DockStyle.Fill;
            GridViewProveedores.Location = new Point(0, 0);
            GridViewProveedores.Name = "GridViewProveedores";
            GridViewProveedores.RowHeadersWidth = 51;
            GridViewProveedores.Size = new Size(832, 435);
            GridViewProveedores.TabIndex = 1;
            GridViewProveedores.CellContentClick += GridViewProveedores_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
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
            // UI_Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(GridViewProveedores);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI_Proveedores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ADMINISTRADOR DE PROVEEDORES";
            Load += UI_Proveedorescs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView GridViewProveedores;
        private Button BtnEliminar;
        private Button BtnModificar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Productos;
        private Button button1;
    }
}