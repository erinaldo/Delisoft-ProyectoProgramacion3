namespace InventarioGUI
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnMateriaPrima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductos
            // 
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProductos.Location = new System.Drawing.Point(140, 207);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(146, 101);
            this.BtnProductos.TabIndex = 0;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnMateriaPrima
            // 
            this.BtnMateriaPrima.FlatAppearance.BorderSize = 0;
            this.BtnMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMateriaPrima.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.BtnMateriaPrima.Image = ((System.Drawing.Image)(resources.GetObject("BtnMateriaPrima.Image")));
            this.BtnMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMateriaPrima.Location = new System.Drawing.Point(347, 207);
            this.BtnMateriaPrima.Name = "BtnMateriaPrima";
            this.BtnMateriaPrima.Size = new System.Drawing.Size(146, 101);
            this.BtnMateriaPrima.TabIndex = 2;
            this.BtnMateriaPrima.Text = "Materia Prima";
            this.BtnMateriaPrima.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMateriaPrima.UseVisualStyleBackColor = true;
            this.BtnMateriaPrima.Click += new System.EventHandler(this.BtnMateriaPrima_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 514);
            this.Controls.Add(this.BtnMateriaPrima);
            this.Controls.Add(this.BtnProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnMateriaPrima;
    }
}