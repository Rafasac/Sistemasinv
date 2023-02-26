namespace SistemasInv.Modulos
{
    partial class addImpresora
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionMAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarImpresora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(110, 49);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 20);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarca_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(110, 75);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(210, 20);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(110, 101);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(210, 20);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serie";
            // 
            // txtDireccionIP
            // 
            this.txtDireccionIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionIP.Location = new System.Drawing.Point(110, 127);
            this.txtDireccionIP.Name = "txtDireccionIP";
            this.txtDireccionIP.Size = new System.Drawing.Size(210, 20);
            this.txtDireccionIP.TabIndex = 4;
            this.txtDireccionIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionIP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección IP";
            // 
            // txtDireccionMAC
            // 
            this.txtDireccionMAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionMAC.Location = new System.Drawing.Point(110, 153);
            this.txtDireccionMAC.Name = "txtDireccionMAC";
            this.txtDireccionMAC.Size = new System.Drawing.Size(210, 20);
            this.txtDireccionMAC.TabIndex = 5;
            this.txtDireccionMAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionMAC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección M.A.C.";
            // 
            // btnAgregarImpresora
            // 
            this.btnAgregarImpresora.Location = new System.Drawing.Point(378, 120);
            this.btnAgregarImpresora.Name = "btnAgregarImpresora";
            this.btnAgregarImpresora.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarImpresora.TabIndex = 6;
            this.btnAgregarImpresora.Text = "Agregar";
            this.btnAgregarImpresora.UseVisualStyleBackColor = true;
            this.btnAgregarImpresora.Click += new System.EventHandler(this.btnAgregarImpresora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Especificaciones de las impresoras";
            // 
            // addImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarImpresora);
            this.Controls.Add(this.txtDireccionMAC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccionIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addImpresora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especificaciones de las impresoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionMAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarImpresora;
        private System.Windows.Forms.Label label1;
    }
}