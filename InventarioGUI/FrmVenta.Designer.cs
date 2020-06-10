namespace InventarioGUI
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.LblProducto = new System.Windows.Forms.Label();
            this.CmbVendedor = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblIva = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblVendedor = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.PckCantidad = new System.Windows.Forms.NumericUpDown();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ChkDescuento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PckCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(25, 90);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(69, 23);
            this.LblProducto.TabIndex = 27;
            this.LblProducto.Text = "Producto:";
            // 
            // CmbVendedor
            // 
            this.CmbVendedor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CmbVendedor.FormattingEnabled = true;
            this.CmbVendedor.Location = new System.Drawing.Point(219, 47);
            this.CmbVendedor.Name = "CmbVendedor";
            this.CmbVendedor.Size = new System.Drawing.Size(286, 24);
            this.CmbVendedor.TabIndex = 26;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCalcular.Location = new System.Drawing.Point(172, 420);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(82, 64);
            this.BtnCalcular.TabIndex = 25;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtTotal.Location = new System.Drawing.Point(425, 360);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(146, 22);
            this.TxtTotal.TabIndex = 24;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(366, 355);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(43, 23);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "Total:";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.Location = new System.Drawing.Point(291, 317);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(32, 23);
            this.LblIva.TabIndex = 21;
            this.LblIva.Text = "Iva:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtDescuento.Location = new System.Drawing.Point(143, 355);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(132, 22);
            this.TxtDescuento.TabIndex = 20;
            this.TxtDescuento.Text = "0";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuento.Location = new System.Drawing.Point(60, 350);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(77, 23);
            this.LblDescuento.TabIndex = 19;
            this.LblDescuento.Text = "Descuento:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(375, 420);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 64);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(60, 311);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(66, 23);
            this.LblSubtotal.TabIndex = 15;
            this.LblSubtotal.Text = "Subtotal:";
            // 
            // LblVendedor
            // 
            this.LblVendedor.AutoSize = true;
            this.LblVendedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendedor.Location = new System.Drawing.Point(127, 47);
            this.LblVendedor.Name = "LblVendedor";
            this.LblVendedor.Size = new System.Drawing.Size(69, 23);
            this.LblVendedor.TabIndex = 28;
            this.LblVendedor.Text = "Vendedor:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtCodigo.Location = new System.Drawing.Point(260, 95);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(197, 22);
            this.TxtCodigo.TabIndex = 29;
            // 
            // CmbProducto
            // 
            this.CmbProducto.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(100, 95);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(140, 24);
            this.CmbProducto.TabIndex = 30;
            this.CmbProducto.SelectedIndexChanged += new System.EventHandler(this.CmbProducto_SelectedIndexChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(476, 95);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(70, 23);
            this.LblCantidad.TabIndex = 31;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // PckCantidad
            // 
            this.PckCantidad.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.PckCantidad.Location = new System.Drawing.Point(552, 97);
            this.PckCantidad.Name = "PckCantidad";
            this.PckCantidad.Size = new System.Drawing.Size(55, 22);
            this.PckCantidad.TabIndex = 33;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.DgvProductos.Location = new System.Drawing.Point(45, 186);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(542, 108);
            this.DgvProductos.TabIndex = 34;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtSubtotal.Location = new System.Drawing.Point(143, 318);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(135, 22);
            this.TxtSubtotal.TabIndex = 17;
            // 
            // TxtIva
            // 
            this.TxtIva.Enabled = false;
            this.TxtIva.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtIva.Location = new System.Drawing.Point(329, 320);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(135, 22);
            this.TxtIva.TabIndex = 22;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(91)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnAgregar.Location = new System.Drawing.Point(80, 129);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 43);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(15)))), ((int)(((byte)(52)))));
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(433, 130);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(113, 43);
            this.BtnEliminar.TabIndex = 37;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ChkDescuento
            // 
            this.ChkDescuento.AutoSize = true;
            this.ChkDescuento.Location = new System.Drawing.Point(493, 322);
            this.ChkDescuento.Name = "ChkDescuento";
            this.ChkDescuento.Size = new System.Drawing.Size(78, 17);
            this.ChkDescuento.TabIndex = 38;
            this.ChkDescuento.Text = "Descuento";
            this.ChkDescuento.UseVisualStyleBackColor = true;
            this.ChkDescuento.CheckedChanged += new System.EventHandler(this.ChkDescuento_CheckedChanged);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 496);
            this.Controls.Add(this.ChkDescuento);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.PckCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.CmbProducto);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblVendedor);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.CmbVendedor);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.LblDescuento);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.LblSubtotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            ((System.ComponentModel.ISupportInitialize)(this.PckCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.ComboBox CmbVendedor;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblVendedor;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.NumericUpDown PckCantidad;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}