namespace SistemasInv.Activos
{
    partial class modificarActivo
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
            this.txtActivos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoActivo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtActivos
            // 
            this.txtActivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivos.Location = new System.Drawing.Point(195, 15);
            this.txtActivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivos.Name = "txtActivos";
            this.txtActivos.Size = new System.Drawing.Size(358, 30);
            this.txtActivos.TabIndex = 0;
            this.txtActivos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de activo";
            // 
            // lblTipoActivo
            // 
            this.lblTipoActivo.AutoSize = true;
            this.lblTipoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoActivo.Location = new System.Drawing.Point(590, 18);
            this.lblTipoActivo.Name = "lblTipoActivo";
            this.lblTipoActivo.Size = new System.Drawing.Size(17, 25);
            this.lblTipoActivo.TabIndex = 3;
            this.lblTipoActivo.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 568);
            this.panel1.TabIndex = 4;
            // 
            // modificarActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1515, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipoActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "modificarActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarActivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoActivo;
        private System.Windows.Forms.Panel panel1;
    }
}