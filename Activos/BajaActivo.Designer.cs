namespace SistemasInv.Activos
{
    partial class BajaActivo
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
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.EQUIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EQUIPO,
            this.MARCA,
            this.MODELP,
            this.SERIE,
            this.VP});
            this.dgvAsignaciones.Location = new System.Drawing.Point(22, 151);
            this.dgvAsignaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.Size = new System.Drawing.Size(1886, 388);
            this.dgvAsignaciones.TabIndex = 6;
            // 
            // EQUIPO
            // 
            this.EQUIPO.HeaderText = "Equipo";
            this.EQUIPO.Name = "EQUIPO";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "Marca";
            this.MARCA.Name = "MARCA";
            // 
            // MODELP
            // 
            this.MODELP.HeaderText = "Modelo";
            this.MODELP.Name = "MODELP";
            // 
            // SERIE
            // 
            this.SERIE.HeaderText = "Serie";
            this.SERIE.Name = "SERIE";
            // 
            // VP
            // 
            this.VP.HeaderText = "Vp";
            this.VP.Name = "VP";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(255, 34);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(301, 26);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escriba objeto de busqueda";
            // 
            // BajaActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1912, 1017);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BajaActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de activos por equipo obsoleto o dañado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VP;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
    }
}