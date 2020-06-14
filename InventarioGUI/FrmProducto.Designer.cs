namespace InventarioGUI
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.TxtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.LblPrecioUnidad = new System.Windows.Forms.Label();
            this.BtnGuardarProducto = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdeProducto = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblIdProducto = new System.Windows.Forms.Label();
            this.TblMateriaPrima = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlmacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblMateriaPrima = new System.Windows.Forms.Label();
            this.CmbMateria = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPrecioUnidad
            // 
            this.TxtPrecioUnidad.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtPrecioUnidad.Location = new System.Drawing.Point(331, 127);
            this.TxtPrecioUnidad.Name = "TxtPrecioUnidad";
            this.TxtPrecioUnidad.Size = new System.Drawing.Size(197, 22);
            this.TxtPrecioUnidad.TabIndex = 32;
            // 
            // LblPrecioUnidad
            // 
            this.LblPrecioUnidad.AutoSize = true;
            this.LblPrecioUnidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioUnidad.Location = new System.Drawing.Point(161, 124);
            this.LblPrecioUnidad.Name = "LblPrecioUnidad";
            this.LblPrecioUnidad.Size = new System.Drawing.Size(125, 23);
            this.LblPrecioUnidad.TabIndex = 31;
            this.LblPrecioUnidad.Text = "Precio por unidad:";
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.BtnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarProducto.Image")));
            this.BtnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardarProducto.Location = new System.Drawing.Point(123, 501);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.Size = new System.Drawing.Size(82, 64);
            this.BtnGuardarProducto.TabIndex = 30;
            this.BtnGuardarProducto.Text = "Guardar";
            this.BtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarProducto.UseVisualStyleBackColor = true;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtNombre.Location = new System.Drawing.Point(331, 88);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(197, 22);
            this.TxtNombre.TabIndex = 29;
            // 
            // TxtIdeProducto
            // 
            this.TxtIdeProducto.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtIdeProducto.Location = new System.Drawing.Point(331, 53);
            this.TxtIdeProducto.Name = "TxtIdeProducto";
            this.TxtIdeProducto.Size = new System.Drawing.Size(197, 22);
            this.TxtIdeProducto.TabIndex = 28;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(161, 84);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 23);
            this.LblNombre.TabIndex = 27;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblIdProducto
            // 
            this.LblIdProducto.AutoSize = true;
            this.LblIdProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdProducto.Location = new System.Drawing.Point(161, 48);
            this.LblIdProducto.Name = "LblIdProducto";
            this.LblIdProducto.Size = new System.Drawing.Size(85, 23);
            this.LblIdProducto.TabIndex = 26;
            this.LblIdProducto.Text = "Id producto:";
            // 
            // TblMateriaPrima
            // 
            this.TblMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.fechaAlmacenamiento});
            this.TblMateriaPrima.Location = new System.Drawing.Point(123, 333);
            this.TblMateriaPrima.Name = "TblMateriaPrima";
            this.TblMateriaPrima.Size = new System.Drawing.Size(440, 150);
            this.TblMateriaPrima.TabIndex = 38;
            this.TblMateriaPrima.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblMateriaPrima_CellClick);
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
            // fechaAlmacenamiento
            // 
            this.fechaAlmacenamiento.HeaderText = "Fecha de Almacenamiento";
            this.fechaAlmacenamiento.Name = "fechaAlmacenamiento";
            // 
            // LblMateriaPrima
            // 
            this.LblMateriaPrima.AutoSize = true;
            this.LblMateriaPrima.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMateriaPrima.Location = new System.Drawing.Point(134, 193);
            this.LblMateriaPrima.Name = "LblMateriaPrima";
            this.LblMateriaPrima.Size = new System.Drawing.Size(104, 23);
            this.LblMateriaPrima.TabIndex = 39;
            this.LblMateriaPrima.Text = "Materia prima:";
            // 
            // CmbMateria
            // 
            this.CmbMateria.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CmbMateria.FormattingEnabled = true;
            this.CmbMateria.Location = new System.Drawing.Point(250, 194);
            this.CmbMateria.Name = "CmbMateria";
            this.CmbMateria.Size = new System.Drawing.Size(191, 24);
            this.CmbMateria.TabIndex = 40;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgregar.Location = new System.Drawing.Point(210, 242);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 68);
            this.BtnAgregar.TabIndex = 42;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(369, 242);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 68);
            this.BtnEliminar.TabIndex = 43;
            this.BtnEliminar.Text = "Eliminar\r\n";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // NumCantidad
            // 
            this.NumCantidad.Location = new System.Drawing.Point(531, 199);
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(47, 20);
            this.NumCantidad.TabIndex = 44;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(455, 196);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(70, 23);
            this.LblCantidad.TabIndex = 45;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(469, 501);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(94, 64);
            this.BtnConsultar.TabIndex = 46;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 588);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CmbMateria);
            this.Controls.Add(this.LblMateriaPrima);
            this.Controls.Add(this.TblMateriaPrima);
            this.Controls.Add(this.TxtPrecioUnidad);
            this.Controls.Add(this.LblPrecioUnidad);
            this.Controls.Add(this.BtnGuardarProducto);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdeProducto);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdProducto);
            this.MaximizeBox = false;
            this.Name = "FrmProducto";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.TblMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPrecioUnidad;
        private System.Windows.Forms.Label LblPrecioUnidad;
        private System.Windows.Forms.Button BtnGuardarProducto;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdeProducto;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblIdProducto;
        private System.Windows.Forms.DataGridView TblMateriaPrima;
        private System.Windows.Forms.Label LblMateriaPrima;
        private System.Windows.Forms.ComboBox CmbMateria;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlmacenamiento;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnConsultar;
    }
}