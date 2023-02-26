namespace SistemasInv.Activos
{
    partial class addBocinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBocinas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarBocina = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoAudio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Especificaciones de bocinas";
            // 
            // btnAgregarBocina
            // 
            this.btnAgregarBocina.Location = new System.Drawing.Point(436, 179);
            this.btnAgregarBocina.Name = "btnAgregarBocina";
            this.btnAgregarBocina.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarBocina.TabIndex = 34;
            this.btnAgregarBocina.Text = "Agregar";
            this.btnAgregarBocina.UseVisualStyleBackColor = true;
            this.btnAgregarBocina.Click += new System.EventHandler(this.BtnAgregarBocina_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(185, 160);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(210, 20);
            this.txtSerie.TabIndex = 32;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(185, 134);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(210, 20);
            this.txtModelo.TabIndex = 30;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModelo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(185, 108);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 20);
            this.txtMarca.TabIndex = 29;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarca_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Marca";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(73, 198);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(95, 13);
            this.lblTipo.TabIndex = 38;
            this.lblTipo.Text = "Tipo de dispositivo";
            // 
            // cbTipoAudio
            // 
            this.cbTipoAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAudio.FormattingEnabled = true;
            this.cbTipoAudio.Items.AddRange(new object[] {
            "BOCINA",
            "AMPLIFICADOR",
            "PROCESADOR",
            "PREAMPLIFICADOR",
            "SWITCH"});
            this.cbTipoAudio.Location = new System.Drawing.Point(185, 190);
            this.cbTipoAudio.Name = "cbTipoAudio";
            this.cbTipoAudio.Size = new System.Drawing.Size(210, 21);
            this.cbTipoAudio.TabIndex = 39;
            this.cbTipoAudio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTipoAudio_KeyPress);
            // 
            // addBocinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipoAudio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarBocina);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addBocinas";
            this.Text = "addBocinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarBocina;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoAudio;
    }
}