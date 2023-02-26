namespace SistemasInv.Activos
{
    partial class DevolucionAS
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.EQUIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDevolucion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba objeto de busqueda:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(229, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(305, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
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
            this.dgvAsignaciones.Location = new System.Drawing.Point(16, 89);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.Size = new System.Drawing.Size(790, 174);
            this.dgvAsignaciones.TabIndex = 3;
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
            // btnDevolucion
            // 
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Location = new System.Drawing.Point(1103, 618);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(169, 31);
            this.btnDevolucion.TabIndex = 4;
            this.btnDevolucion.Text = "Devolver a sistemas";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.BtnDevolucion_Click);
            // 
            // DevolucionAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de activos a sistemas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VP;
        private System.Windows.Forms.Button btnDevolucion;
    }
}