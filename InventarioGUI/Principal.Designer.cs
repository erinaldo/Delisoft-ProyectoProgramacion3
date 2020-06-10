namespace InventarioGUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.PnlMenu.Controls.Add(this.label1);
            this.PnlMenu.Controls.Add(this.panel1);
            this.PnlMenu.Controls.Add(this.BtnMenu);
            this.PnlMenu.Controls.Add(this.BtnConfiguracion);
            this.PnlMenu.Controls.Add(this.BtnEmpleados);
            this.PnlMenu.Controls.Add(this.BtnVenta);
            this.PnlMenu.Controls.Add(this.BtnInventario);
            this.PnlMenu.Location = new System.Drawing.Point(-1, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(298, 565);
            this.PnlMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 9);
            this.panel1.TabIndex = 5;
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenu.Location = new System.Drawing.Point(24, 22);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(240, 74);
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.Text = "DELISOFT V 1.0";
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracion.Image")));
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfiguracion.Location = new System.Drawing.Point(24, 422);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(240, 85);
            this.BtnConfiguracion.TabIndex = 3;
            this.BtnConfiguracion.Text = "CONFIGURACIÓN";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleados.Image")));
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpleados.Location = new System.Drawing.Point(24, 320);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(240, 85);
            this.BtnEmpleados.TabIndex = 2;
            this.BtnEmpleados.Text = "EMPLEADOS";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.FlatAppearance.BorderSize = 0;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnVenta.ForeColor = System.Drawing.Color.White;
            this.BtnVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnVenta.Image")));
            this.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVenta.Location = new System.Drawing.Point(24, 218);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(240, 85);
            this.BtnVenta.TabIndex = 1;
            this.BtnVenta.Text = "VENTA";
            this.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventario.Location = new System.Drawing.Point(24, 113);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(240, 85);
            this.BtnInventario.TabIndex = 0;
            this.BtnInventario.Text = "INVENTARIO";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Location = new System.Drawing.Point(298, 22);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(633, 543);
            this.PnlPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "CERRAR SESION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(929, 562);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

