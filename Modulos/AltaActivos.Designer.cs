namespace SistemasInv.Modulos
{
    partial class AltaActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaActivos));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumeroActivo = new System.Windows.Forms.Label();
            this.dtpFechaDeCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempoGarantia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDeFactura = new System.Windows.Forms.TextBox();
            this.cbbClasificacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTIVO:";
            // 
            // lbNumeroActivo
            // 
            this.lbNumeroActivo.AutoSize = true;
            this.lbNumeroActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroActivo.ForeColor = System.Drawing.Color.White;
            this.lbNumeroActivo.Location = new System.Drawing.Point(12, 36);
            this.lbNumeroActivo.Name = "lbNumeroActivo";
            this.lbNumeroActivo.Size = new System.Drawing.Size(213, 13);
            this.lbNumeroActivo.TabIndex = 1;
            this.lbNumeroActivo.Text = "SIN CONEXIÓN CON EL SERVIDOR";
            // 
            // dtpFechaDeCompra
            // 
            this.dtpFechaDeCompra.Location = new System.Drawing.Point(143, 60);
            this.dtpFechaDeCompra.Name = "dtpFechaDeCompra";
            this.dtpFechaDeCompra.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaDeCompra.TabIndex = 0;
            this.dtpFechaDeCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaDeCompra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo de garantia (años):";
            // 
            // txtTiempoGarantia
            // 
            this.txtTiempoGarantia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTiempoGarantia.Location = new System.Drawing.Point(143, 89);
            this.txtTiempoGarantia.Name = "txtTiempoGarantia";
            this.txtTiempoGarantia.Size = new System.Drawing.Size(99, 20);
            this.txtTiempoGarantia.TabIndex = 1;
            this.txtTiempoGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTiempoGarantia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de factura";
            // 
            // txtNumeroDeFactura
            // 
            this.txtNumeroDeFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDeFactura.Location = new System.Drawing.Point(143, 117);
            this.txtNumeroDeFactura.Name = "txtNumeroDeFactura";
            this.txtNumeroDeFactura.Size = new System.Drawing.Size(99, 20);
            this.txtNumeroDeFactura.TabIndex = 2;
            this.txtNumeroDeFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDeFactura_KeyPress);
            // 
            // cbbClasificacion
            // 
            this.cbbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClasificacion.FormattingEnabled = true;
            this.cbbClasificacion.Items.AddRange(new object[] {
            "IMPRESORA",
            "LAPTOP",
            "PC",
            "MOVIL",
            "TELEFONO IP",
            "ACCESORIO",
            "CONSUMIBLE",
            "CAMARAS",
            "AUDIO",
            "DVR",
            "RELOJES"});
            this.cbbClasificacion.Location = new System.Drawing.Point(143, 262);
            this.cbbClasificacion.Name = "cbbClasificacion";
            this.cbbClasificacion.Size = new System.Drawing.Size(99, 21);
            this.cbbClasificacion.TabIndex = 4;
            this.cbbClasificacion.SelectedIndexChanged += new System.EventHandler(this.CbbClasificacion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clasificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Comentario:";
            // 
            // rtbComentario
            // 
            this.rtbComentario.Location = new System.Drawing.Point(15, 163);
            this.rtbComentario.MaxLength = 250;
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(227, 80);
            this.rtbComentario.TabIndex = 3;
            this.rtbComentario.Text = "";
            this.rtbComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbComentario_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 649);
            this.panel1.TabIndex = 12;
            // 
            // AltaActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbComentario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbClasificacion);
            this.Controls.Add(this.txtNumeroDeFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempoGarantia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaDeCompra);
            this.Controls.Add(this.lbNumeroActivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaActivos";
            this.Load += new System.EventHandler(this.AltaActivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumeroActivo;
        private System.Windows.Forms.DateTimePicker dtpFechaDeCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempoGarantia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDeFactura;
        private System.Windows.Forms.ComboBox cbbClasificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbComentario;
        private System.Windows.Forms.Panel panel1;
    }
}