namespace SistemasInv.Activos
{
    partial class addTelefono
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroDirecto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extensión";
            // 
            // txtExtension
            // 
            this.txtExtension.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExtension.Location = new System.Drawing.Point(85, 42);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(229, 20);
            this.txtExtension.TabIndex = 1;
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExtension_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(85, 68);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(229, 20);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarca_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(85, 94);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(229, 20);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(85, 121);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(229, 20);
            this.txtSerie.TabIndex = 4;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // txtIp
            // 
            this.txtIp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIp.Location = new System.Drawing.Point(85, 147);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(229, 20);
            this.txtIp.TabIndex = 5;
            this.txtIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especificaciones de los Telefonos";
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Location = new System.Drawing.Point(713, 388);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarTelefono.TabIndex = 11;
            this.btnAgregarTelefono.Text = "Agregar";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.BtnAgregarTelefono_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuerto.Location = new System.Drawing.Point(85, 173);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(229, 20);
            this.txtPuerto.TabIndex = 12;
            this.txtPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPuerto_KeyPress);
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(12, 173);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 13;
            this.lblPuerto.Text = "Puerto";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTarjeta.Location = new System.Drawing.Point(85, 199);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(229, 20);
            this.txtTarjeta.TabIndex = 14;
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarjeta_KeyPress);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(12, 199);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.lblTarjeta.TabIndex = 15;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // txtNumeroDirecto
            // 
            this.txtNumeroDirecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDirecto.Location = new System.Drawing.Point(85, 225);
            this.txtNumeroDirecto.Name = "txtNumeroDirecto";
            this.txtNumeroDirecto.Size = new System.Drawing.Size(229, 20);
            this.txtNumeroDirecto.TabIndex = 16;
            this.txtNumeroDirecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDirecto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "No Directo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(8, 407);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(10, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = ".";
            // 
            // addTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNumeroDirecto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.btnAgregarTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addTelefono";
            this.Text = "addTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtNumeroDirecto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEstado;
    }
}