namespace InventarioGUI
{
    partial class FrmOperacionesProductos
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblContenido = new System.Windows.Forms.Label();
            this.DgvContenido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblCodigo.Location = new System.Drawing.Point(122, 48);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(55, 23);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtCodigo.Location = new System.Drawing.Point(190, 52);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(181, 22);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblNombre.Location = new System.Drawing.Point(116, 92);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 23);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtNombre.Location = new System.Drawing.Point(190, 92);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(181, 22);
            this.TxtNombre.TabIndex = 3;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblPrecio.Location = new System.Drawing.Point(125, 130);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(52, 23);
            this.LblPrecio.TabIndex = 4;
            this.LblPrecio.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtPrecio.Location = new System.Drawing.Point(190, 130);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(181, 22);
            this.TxtPrecio.TabIndex = 5;
            // 
            // LblContenido
            // 
            this.LblContenido.AutoSize = true;
            this.LblContenido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblContenido.Location = new System.Drawing.Point(32, 192);
            this.LblContenido.Name = "LblContenido";
            this.LblContenido.Size = new System.Drawing.Size(75, 23);
            this.LblContenido.TabIndex = 6;
            this.LblContenido.Text = "Contenido:";
            // 
            // DgvContenido
            // 
            this.DgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContenido.Location = new System.Drawing.Point(77, 233);
            this.DgvContenido.Name = "DgvContenido";
            this.DgvContenido.Size = new System.Drawing.Size(358, 150);
            this.DgvContenido.TabIndex = 7;
            // 
            // FrmOperacionesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 471);
            this.Controls.Add(this.DgvContenido);
            this.Controls.Add(this.LblContenido);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Name = "FrmOperacionesProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblContenido;
        private System.Windows.Forms.DataGridView DgvContenido;
    }
}