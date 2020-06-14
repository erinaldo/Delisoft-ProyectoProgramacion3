namespace InventarioGUI
{
    partial class FrmConsultaMateriaPrima
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
            this.DtpFechaAlmacenamiento = new System.Windows.Forms.DateTimePicker();
            this.LblFechaAlmacenamiento = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.DgvMateriaPrima = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFechaAlmacenamiento
            // 
            this.DtpFechaAlmacenamiento.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.DtpFechaAlmacenamiento.Location = new System.Drawing.Point(242, 54);
            this.DtpFechaAlmacenamiento.Name = "DtpFechaAlmacenamiento";
            this.DtpFechaAlmacenamiento.Size = new System.Drawing.Size(233, 22);
            this.DtpFechaAlmacenamiento.TabIndex = 0;
            // 
            // LblFechaAlmacenamiento
            // 
            this.LblFechaAlmacenamiento.AutoSize = true;
            this.LblFechaAlmacenamiento.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblFechaAlmacenamiento.Location = new System.Drawing.Point(58, 51);
            this.LblFechaAlmacenamiento.Name = "LblFechaAlmacenamiento";
            this.LblFechaAlmacenamiento.Size = new System.Drawing.Size(178, 23);
            this.LblFechaAlmacenamiento.TabIndex = 1;
            this.LblFechaAlmacenamiento.Text = "Fecha de almacenamiento:";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblCategoria.Location = new System.Drawing.Point(162, 90);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(74, 23);
            this.LblCategoria.TabIndex = 2;
            this.LblCategoria.Text = "Categoria:";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(242, 95);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(233, 24);
            this.CmbCategoria.TabIndex = 3;
            this.CmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // DgvMateriaPrima
            // 
            this.DgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMateriaPrima.Location = new System.Drawing.Point(62, 160);
            this.DgvMateriaPrima.Name = "DgvMateriaPrima";
            this.DgvMateriaPrima.Size = new System.Drawing.Size(413, 150);
            this.DgvMateriaPrima.TabIndex = 4;
            // 
            // FrmConsultaMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.DgvMateriaPrima);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblFechaAlmacenamiento);
            this.Controls.Add(this.DtpFechaAlmacenamiento);
            this.Name = "FrmConsultaMateriaPrima";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMateriaPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFechaAlmacenamiento;
        private System.Windows.Forms.Label LblFechaAlmacenamiento;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.DataGridView DgvMateriaPrima;
    }
}