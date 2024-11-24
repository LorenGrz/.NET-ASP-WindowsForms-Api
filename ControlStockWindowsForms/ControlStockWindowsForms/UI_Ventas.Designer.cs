namespace ControlStockWindowsForms
{
    partial class UI_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Ventas));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            GridViewVentas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            prod = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            CantidadVendida = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            TotalVenta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 68);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 62);
            button2.TabIndex = 4;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 62);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GridViewVentas
            // 
            GridViewVentas.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewVentas.Columns.AddRange(new DataGridViewColumn[] { id, prod, Fecha, IdProducto, CantidadVendida, PrecioVenta, TotalVenta });
            GridViewVentas.Dock = DockStyle.Fill;
            GridViewVentas.Location = new Point(0, 0);
            GridViewVentas.Name = "GridViewVentas";
            GridViewVentas.RowHeadersWidth = 51;
            GridViewVentas.Size = new Size(832, 435);
            GridViewVentas.TabIndex = 2;
            GridViewVentas.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // prod
            // 
            prod.DataPropertyName = "prod";
            prod.HeaderText = "prod";
            prod.MinimumWidth = 6;
            prod.Name = "prod";
            prod.Visible = false;
            prod.Width = 125;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "idProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // CantidadVendida
            // 
            CantidadVendida.DataPropertyName = "cantidadVendida";
            CantidadVendida.HeaderText = "Cantidad Vendida";
            CantidadVendida.MinimumWidth = 6;
            CantidadVendida.Name = "CantidadVendida";
            CantidadVendida.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "precioVenta";
            PrecioVenta.HeaderText = "Precio de la Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 125;
            // 
            // TotalVenta
            // 
            TotalVenta.DataPropertyName = "totalVenta";
            TotalVenta.HeaderText = "Total de la Venta";
            TotalVenta.MinimumWidth = 6;
            TotalVenta.Name = "TotalVenta";
            TotalVenta.Width = 125;
            // 
            // UI_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(GridViewVentas);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI_Ventas";
            Text = "ADMINISTRADOR DE VENTAS";
            Load += UI_Ventas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView GridViewVentas;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn prod;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn CantidadVendida;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn TotalVenta;
    }
}