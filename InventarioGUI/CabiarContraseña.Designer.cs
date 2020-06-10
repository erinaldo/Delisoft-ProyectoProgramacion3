namespace InventarioGUI
{
    partial class CabiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabiarContraseña));
            this.BtnCambioContrasenia = new System.Windows.Forms.Button();
            this.LblContraseniaActual = new System.Windows.Forms.Label();
            this.LblNuevaContrasenia = new System.Windows.Forms.Label();
            this.LblConfirmacionContrasenia = new System.Windows.Forms.Label();
            this.TxtContraseniaActual = new System.Windows.Forms.TextBox();
            this.TxtContraseniaNueva = new System.Windows.Forms.TextBox();
            this.TxtConfirmacionContrasenia = new System.Windows.Forms.TextBox();
            this.ChkMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCambioContrasenia
            // 
            this.BtnCambioContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(91)))));
            this.BtnCambioContrasenia.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambioContrasenia.Location = new System.Drawing.Point(110, 251);
            this.BtnCambioContrasenia.Name = "BtnCambioContrasenia";
            this.BtnCambioContrasenia.Size = new System.Drawing.Size(259, 40);
            this.BtnCambioContrasenia.TabIndex = 0;
            this.BtnCambioContrasenia.Text = "Cambiar Contraseña";
            this.BtnCambioContrasenia.UseVisualStyleBackColor = false;
            this.BtnCambioContrasenia.Click += new System.EventHandler(this.BtnCambioContrasenia_Click);
            // 
            // LblContraseniaActual
            // 
            this.LblContraseniaActual.AutoSize = true;
            this.LblContraseniaActual.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.LblContraseniaActual.Location = new System.Drawing.Point(23, 76);
            this.LblContraseniaActual.Name = "LblContraseniaActual";
            this.LblContraseniaActual.Size = new System.Drawing.Size(164, 29);
            this.LblContraseniaActual.TabIndex = 1;
            this.LblContraseniaActual.Text = "Contraseña actual:";
            // 
            // LblNuevaContrasenia
            // 
            this.LblNuevaContrasenia.AutoSize = true;
            this.LblNuevaContrasenia.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.LblNuevaContrasenia.Location = new System.Drawing.Point(23, 126);
            this.LblNuevaContrasenia.Name = "LblNuevaContrasenia";
            this.LblNuevaContrasenia.Size = new System.Drawing.Size(161, 29);
            this.LblNuevaContrasenia.TabIndex = 2;
            this.LblNuevaContrasenia.Text = "Nueva contraseña:";
            // 
            // LblConfirmacionContrasenia
            // 
            this.LblConfirmacionContrasenia.AutoSize = true;
            this.LblConfirmacionContrasenia.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.LblConfirmacionContrasenia.Location = new System.Drawing.Point(23, 165);
            this.LblConfirmacionContrasenia.Name = "LblConfirmacionContrasenia";
            this.LblConfirmacionContrasenia.Size = new System.Drawing.Size(242, 29);
            this.LblConfirmacionContrasenia.TabIndex = 3;
            this.LblConfirmacionContrasenia.Text = "Confirmación de contraseña:";
            // 
            // TxtContraseniaActual
            // 
            this.TxtContraseniaActual.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtContraseniaActual.Location = new System.Drawing.Point(271, 82);
            this.TxtContraseniaActual.Name = "TxtContraseniaActual";
            this.TxtContraseniaActual.Size = new System.Drawing.Size(177, 22);
            this.TxtContraseniaActual.TabIndex = 4;
            // 
            // TxtContraseniaNueva
            // 
            this.TxtContraseniaNueva.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtContraseniaNueva.Location = new System.Drawing.Point(271, 132);
            this.TxtContraseniaNueva.Name = "TxtContraseniaNueva";
            this.TxtContraseniaNueva.Size = new System.Drawing.Size(177, 22);
            this.TxtContraseniaNueva.TabIndex = 5;
            // 
            // TxtConfirmacionContrasenia
            // 
            this.TxtConfirmacionContrasenia.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtConfirmacionContrasenia.Location = new System.Drawing.Point(271, 170);
            this.TxtConfirmacionContrasenia.Name = "TxtConfirmacionContrasenia";
            this.TxtConfirmacionContrasenia.Size = new System.Drawing.Size(176, 22);
            this.TxtConfirmacionContrasenia.TabIndex = 6;
            // 
            // ChkMostrarContraseña
            // 
            this.ChkMostrarContraseña.AutoSize = true;
            this.ChkMostrarContraseña.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMostrarContraseña.Location = new System.Drawing.Point(176, 200);
            this.ChkMostrarContraseña.Name = "ChkMostrarContraseña";
            this.ChkMostrarContraseña.Size = new System.Drawing.Size(125, 19);
            this.ChkMostrarContraseña.TabIndex = 7;
            this.ChkMostrarContraseña.Text = "Mostrar contraseñas";
            this.ChkMostrarContraseña.UseVisualStyleBackColor = true;
            this.ChkMostrarContraseña.CheckedChanged += new System.EventHandler(this.ChkMostrarContraseña_CheckedChanged);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtNombreUsuario.Location = new System.Drawing.Point(271, 44);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(177, 22);
            this.TxtNombreUsuario.TabIndex = 10;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.LblNombreUsuario.Location = new System.Drawing.Point(23, 38);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(169, 29);
            this.LblNombreUsuario.TabIndex = 9;
            this.LblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // CabiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 323);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.LblNombreUsuario);
            this.Controls.Add(this.ChkMostrarContraseña);
            this.Controls.Add(this.TxtConfirmacionContrasenia);
            this.Controls.Add(this.TxtContraseniaNueva);
            this.Controls.Add(this.TxtContraseniaActual);
            this.Controls.Add(this.LblConfirmacionContrasenia);
            this.Controls.Add(this.LblNuevaContrasenia);
            this.Controls.Add(this.LblContraseniaActual);
            this.Controls.Add(this.BtnCambioContrasenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CabiarContraseña";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCambioContrasenia;
        private System.Windows.Forms.Label LblContraseniaActual;
        private System.Windows.Forms.Label LblNuevaContrasenia;
        private System.Windows.Forms.Label LblConfirmacionContrasenia;
        private System.Windows.Forms.TextBox TxtContraseniaActual;
        private System.Windows.Forms.TextBox TxtContraseniaNueva;
        private System.Windows.Forms.TextBox TxtConfirmacionContrasenia;
        private System.Windows.Forms.CheckBox ChkMostrarContraseña;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label LblNombreUsuario;
    }
}