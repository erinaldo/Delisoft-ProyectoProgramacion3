namespace InventarioGUI
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.BtnPqrs = new System.Windows.Forms.Button();
            this.BtnCrearModificar = new System.Windows.Forms.Button();
            this.BtnCambiarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPqrs
            // 
            this.BtnPqrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPqrs.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPqrs.Image = ((System.Drawing.Image)(resources.GetObject("BtnPqrs.Image")));
            this.BtnPqrs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPqrs.Location = new System.Drawing.Point(137, 283);
            this.BtnPqrs.Name = "BtnPqrs";
            this.BtnPqrs.Size = new System.Drawing.Size(358, 57);
            this.BtnPqrs.TabIndex = 7;
            this.BtnPqrs.Text = "ENVIAR PQRS";
            this.BtnPqrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPqrs.UseVisualStyleBackColor = true;
            this.BtnPqrs.Click += new System.EventHandler(this.BtnPqrs_Click);
            // 
            // BtnCrearModificar
            // 
            this.BtnCrearModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearModificar.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrearModificar.Image")));
            this.BtnCrearModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearModificar.Location = new System.Drawing.Point(137, 220);
            this.BtnCrearModificar.Name = "BtnCrearModificar";
            this.BtnCrearModificar.Size = new System.Drawing.Size(358, 57);
            this.BtnCrearModificar.TabIndex = 6;
            this.BtnCrearModificar.Text = "CREAR/MODIFICAR USUARIOS";
            this.BtnCrearModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearModificar.UseVisualStyleBackColor = true;
            this.BtnCrearModificar.Click += new System.EventHandler(this.BtnCrearModificar_Click);
            // 
            // BtnCambiarContraseña
            // 
            this.BtnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarContraseña.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("BtnCambiarContraseña.Image")));
            this.BtnCambiarContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCambiarContraseña.Location = new System.Drawing.Point(137, 157);
            this.BtnCambiarContraseña.Name = "BtnCambiarContraseña";
            this.BtnCambiarContraseña.Size = new System.Drawing.Size(358, 57);
            this.BtnCambiarContraseña.TabIndex = 5;
            this.BtnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            this.BtnCambiarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCambiarContraseña.UseVisualStyleBackColor = true;
            this.BtnCambiarContraseña.Click += new System.EventHandler(this.BtnCambiarContraseña_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 496);
            this.Controls.Add(this.BtnPqrs);
            this.Controls.Add(this.BtnCrearModificar);
            this.Controls.Add(this.BtnCambiarContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguracion";
            this.Text = "FrmConfiguracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPqrs;
        private System.Windows.Forms.Button BtnCrearModificar;
        private System.Windows.Forms.Button BtnCambiarContraseña;
    }
}