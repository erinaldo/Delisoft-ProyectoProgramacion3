namespace InventarioGUI
{
    partial class FrmMateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriaPrima));
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Label();
            this.CmbCategorias = new System.Windows.Forms.ComboBox();
            this.NmbCantidadEnvase = new System.Windows.Forms.NumericUpDown();
            this.LblCantidadEnvase = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmbCantidadEnvase)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblNombre.Location = new System.Drawing.Point(135, 114);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 23);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblCantidad.Location = new System.Drawing.Point(132, 152);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(70, 23);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtNombre.Location = new System.Drawing.Point(229, 117);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // NumCantidad
            // 
            this.NumCantidad.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.NumCantidad.Location = new System.Drawing.Point(229, 155);
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(120, 22);
            this.NumCantidad.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(200, 271);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 61);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.Categoria.Location = new System.Drawing.Point(135, 46);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(74, 23);
            this.Categoria.TabIndex = 7;
            this.Categoria.Text = "Categoria:";
            // 
            // CmbCategorias
            // 
            this.CmbCategorias.FormattingEnabled = true;
            this.CmbCategorias.Location = new System.Drawing.Point(229, 47);
            this.CmbCategorias.Name = "CmbCategorias";
            this.CmbCategorias.Size = new System.Drawing.Size(120, 21);
            this.CmbCategorias.TabIndex = 8;
            // 
            // NmbCantidadEnvase
            // 
            this.NmbCantidadEnvase.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.NmbCantidadEnvase.Location = new System.Drawing.Point(229, 192);
            this.NmbCantidadEnvase.Name = "NmbCantidadEnvase";
            this.NmbCantidadEnvase.Size = new System.Drawing.Size(120, 22);
            this.NmbCantidadEnvase.TabIndex = 10;
            // 
            // LblCantidadEnvase
            // 
            this.LblCantidadEnvase.AutoSize = true;
            this.LblCantidadEnvase.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblCantidadEnvase.Location = new System.Drawing.Point(59, 187);
            this.LblCantidadEnvase.Name = "LblCantidadEnvase";
            this.LblCantidadEnvase.Size = new System.Drawing.Size(143, 23);
            this.LblCantidadEnvase.TabIndex = 9;
            this.LblCantidadEnvase.Text = "Cantidad por envase:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtPrecio.Location = new System.Drawing.Point(229, 230);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(120, 22);
            this.TxtPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.lblPrecio.Location = new System.Drawing.Point(144, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 23);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio:";
            // 
            // FrmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 355);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.NmbCantidadEnvase);
            this.Controls.Add(this.LblCantidadEnvase);
            this.Controls.Add(this.CmbCategorias);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblNombre);
            this.MaximizeBox = false;
            this.Name = "FrmMateriaPrima";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmbCantidadEnvase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ComboBox CmbCategorias;
        private System.Windows.Forms.NumericUpDown NmbCantidadEnvase;
        private System.Windows.Forms.Label LblCantidadEnvase;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}