namespace ControlStockWindowsForms
{
    partial class EliminarVenta
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
            panel1 = new Panel();
            button1 = new Button();
            textBoxIdVentaAEliminar = new TextBox();
            label1 = new Label();
            GridViewVentas = new DataGridView();
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
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(GridViewVentas);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxIdVentaAEliminar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(306, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxIdVentaAEliminar
            // 
            textBoxIdVentaAEliminar.Location = new Point(175, 6);
            textBoxIdVentaAEliminar.Name = "textBoxIdVentaAEliminar";
            textBoxIdVentaAEliminar.Size = new Size(125, 27);
            textBoxIdVentaAEliminar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Id de Venta a Eliminar:";
            // 
            // GridViewVentas
            // 
            GridViewVentas.BackgroundColor = SystemColors.GradientActiveCaption;
            GridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewVentas.Columns.AddRange(new DataGridViewColumn[] { prod, Fecha, IdProducto, CantidadVendida, PrecioVenta, TotalVenta });
            GridViewVentas.Dock = DockStyle.Bottom;
            GridViewVentas.Location = new Point(0, 39);
            GridViewVentas.Name = "GridViewVentas";
            GridViewVentas.RowHeadersWidth = 51;
            GridViewVentas.Size = new Size(800, 411);
            GridViewVentas.TabIndex = 4;
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
            // EliminarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EliminarVenta";
            Text = "EliminarVenta";
            Load += EliminarVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBoxIdVentaAEliminar;
        private Label label1;
        private Button button1;
        private DataGridView GridViewVentas;
        private DataGridViewTextBoxColumn prod;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn CantidadVendida;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn TotalVenta;
    }
}