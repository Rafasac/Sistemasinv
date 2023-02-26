namespace SistemasInv.Activos
{
    partial class addCamaras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCamaras));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCamara = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCamara = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Especificaciones de las camaras";
            // 
            // btnAgregarCamara
            // 
            this.btnAgregarCamara.Location = new System.Drawing.Point(406, 166);
            this.btnAgregarCamara.Name = "btnAgregarCamara";
            this.btnAgregarCamara.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarCamara.TabIndex = 23;
            this.btnAgregarCamara.Text = "Agregar";
            this.btnAgregarCamara.UseVisualStyleBackColor = true;
            this.btnAgregarCamara.Click += new System.EventHandler(this.BtnAgregarCamara_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tipo";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(138, 147);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(210, 20);
            this.txtSerie.TabIndex = 19;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(138, 121);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(210, 20);
            this.txtModelo.TabIndex = 17;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(138, 95);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 20);
            this.txtMarca.TabIndex = 16;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarca_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marca";
            // 
            // cbTipoCamara
            // 
            this.cbTipoCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCamara.FormattingEnabled = true;
            this.cbTipoCamara.Items.AddRange(new object[] {
            "DOMO",
            "BALA",
            "IP",
            "360°"});
            this.cbTipoCamara.Location = new System.Drawing.Point(138, 173);
            this.cbTipoCamara.Name = "cbTipoCamara";
            this.cbTipoCamara.Size = new System.Drawing.Size(210, 21);
            this.cbTipoCamara.TabIndex = 28;
            this.cbTipoCamara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTipoCamara_KeyPress);
            // 
            // addCamaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipoCamara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarCamara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addCamaras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addCamaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCamara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoCamara;
    }
}