namespace InventarioGUI
{
    partial class Pqrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pqrs));
            this.TxtCuerpo = new System.Windows.Forms.TextBox();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.LblAsunto = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCuerpo
            // 
            this.TxtCuerpo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtCuerpo.Location = new System.Drawing.Point(23, 93);
            this.TxtCuerpo.Multiline = true;
            this.TxtCuerpo.Name = "TxtCuerpo";
            this.TxtCuerpo.Size = new System.Drawing.Size(428, 225);
            this.TxtCuerpo.TabIndex = 0;
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TxtAsunto.Location = new System.Drawing.Point(98, 45);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(353, 22);
            this.TxtAsunto.TabIndex = 1;
            // 
            // LblAsunto
            // 
            this.LblAsunto.AutoSize = true;
            this.LblAsunto.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsunto.Location = new System.Drawing.Point(20, 36);
            this.LblAsunto.Name = "LblAsunto";
            this.LblAsunto.Size = new System.Drawing.Size(72, 29);
            this.LblAsunto.TabIndex = 2;
            this.LblAsunto.Text = "Asunto:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnviar.Image")));
            this.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEnviar.Location = new System.Drawing.Point(191, 324);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(91, 65);
            this.BtnEnviar.TabIndex = 3;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Pqrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 402);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.LblAsunto);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.TxtCuerpo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pqrs";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCuerpo;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label LblAsunto;
        private System.Windows.Forms.Button BtnEnviar;
    }
}