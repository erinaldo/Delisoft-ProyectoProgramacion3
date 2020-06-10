namespace InventarioGUI
{
    partial class ConsultarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEmpleado));
            this.TblEmpleados = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.TxtIdentificaicon = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGenerarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // TblEmpleados
            // 
            this.TblEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblEmpleados.Location = new System.Drawing.Point(86, 20);
            this.TblEmpleados.Name = "TblEmpleados";
            this.TblEmpleados.Size = new System.Drawing.Size(246, 272);
            this.TblEmpleados.TabIndex = 0;
            this.TblEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblEmpleados_CellDoubleClick);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblNombre.Location = new System.Drawing.Point(514, 168);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 23);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtNombre.Location = new System.Drawing.Point(619, 170);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(220, 22);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.LblIdentificacion.Location = new System.Drawing.Point(514, 134);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(99, 23);
            this.LblIdentificacion.TabIndex = 3;
            this.LblIdentificacion.Text = "Identificacion:";
            // 
            // TxtIdentificaicon
            // 
            this.TxtIdentificaicon.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtIdentificaicon.Location = new System.Drawing.Point(619, 136);
            this.TxtIdentificaicon.Name = "TxtIdentificaicon";
            this.TxtIdentificaicon.Size = new System.Drawing.Size(220, 22);
            this.TxtIdentificaicon.TabIndex = 4;
            this.TxtIdentificaicon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentificaicon_KeyPress);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(395, 20);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(117, 62);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(395, 230);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 62);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.Location = new System.Drawing.Point(395, 126);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(117, 62);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGenerarPDF
            // 
            this.BtnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.BtnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarPDF.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarPDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGenerarPDF.Location = new System.Drawing.Point(600, 245);
            this.BtnGenerarPDF.Name = "BtnGenerarPDF";
            this.BtnGenerarPDF.Size = new System.Drawing.Size(142, 38);
            this.BtnGenerarPDF.TabIndex = 8;
            this.BtnGenerarPDF.Text = "Generar PDF";
            this.BtnGenerarPDF.UseVisualStyleBackColor = false;
            this.BtnGenerarPDF.Click += new System.EventHandler(this.BtnGenerarPDF_Click);
            // 
            // ConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 326);
            this.Controls.Add(this.BtnGenerarPDF);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtIdentificaicon);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TblEmpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarEmpleado";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.TblEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TblEmpleados;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.TextBox TxtIdentificaicon;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGenerarPDF;
    }
}