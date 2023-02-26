namespace SistemasInv.Modulos
{
    partial class Responsivas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Responsivas));
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.numeroEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveVP = new System.Windows.Forms.TextBox();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnGenerarResponsiva = new System.Windows.Forms.Button();
            this.pdVistaPrevia = new System.Drawing.Printing.PrintDocument();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnAddEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Location = new System.Drawing.Point(153, 13);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(325, 23);
            this.txtEmpleado.TabIndex = 0;
            this.txtEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpleado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar empleado";
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.AllowUserToResizeColumns = false;
            this.dgvEmpleado.AllowUserToResizeRows = false;
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroEmpleado,
            this.NOMBRE,
            this.APELLIDOPATERNO,
            this.APELLIDOMATERNO,
            this.Dep,
            this.Puesto});
            this.dgvEmpleado.EnableHeadersVisualStyles = false;
            this.dgvEmpleado.GridColor = System.Drawing.Color.White;
            this.dgvEmpleado.Location = new System.Drawing.Point(15, 55);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersVisible = false;
            this.dgvEmpleado.Size = new System.Drawing.Size(1201, 150);
            this.dgvEmpleado.TabIndex = 2;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // numeroEmpleado
            // 
            this.numeroEmpleado.HeaderText = "ID Empleado";
            this.numeroEmpleado.Name = "numeroEmpleado";
            this.numeroEmpleado.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // APELLIDOPATERNO
            // 
            this.APELLIDOPATERNO.HeaderText = "Apellido paterno";
            this.APELLIDOPATERNO.Name = "APELLIDOPATERNO";
            this.APELLIDOPATERNO.ReadOnly = true;
            // 
            // APELLIDOMATERNO
            // 
            this.APELLIDOMATERNO.HeaderText = "Apellido materno";
            this.APELLIDOMATERNO.Name = "APELLIDOMATERNO";
            this.APELLIDOMATERNO.ReadOnly = true;
            // 
            // Dep
            // 
            this.Dep.HeaderText = "Departamento";
            this.Dep.Name = "Dep";
            this.Dep.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave interna del equipo";
            // 
            // txtClaveVP
            // 
            this.txtClaveVP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveVP.Enabled = false;
            this.txtClaveVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveVP.Location = new System.Drawing.Point(175, 240);
            this.txtClaveVP.Name = "txtClaveVP";
            this.txtClaveVP.Size = new System.Drawing.Size(314, 23);
            this.txtClaveVP.TabIndex = 3;
            this.txtClaveVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpActivo_KeyPress);
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.AllowUserToAddRows = false;
            this.dgvAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipo,
            this.marca,
            this.Modelo,
            this.serie,
            this.activo});
            this.dgvAsignaciones.Location = new System.Drawing.Point(11, 279);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.ReadOnly = true;
            this.dgvAsignaciones.RowHeadersVisible = false;
            this.dgvAsignaciones.Size = new System.Drawing.Size(760, 150);
            this.dgvAsignaciones.TabIndex = 5;
            // 
            // equipo
            // 
            this.equipo.FillWeight = 40F;
            this.equipo.HeaderText = "Equipo";
            this.equipo.Name = "equipo";
            this.equipo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.FillWeight = 70F;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.FillWeight = 70F;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // serie
            // 
            this.serie.FillWeight = 70F;
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.FillWeight = 40F;
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btnEliminarItem.Location = new System.Drawing.Point(793, 279);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(194, 49);
            this.btnEliminarItem.TabIndex = 6;
            this.btnEliminarItem.Text = "Eliminar activo";
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click);
            // 
            // btnGenerarResponsiva
            // 
            this.btnGenerarResponsiva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarResponsiva.Enabled = false;
            this.btnGenerarResponsiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarResponsiva.ForeColor = System.Drawing.Color.White;
            this.btnGenerarResponsiva.Location = new System.Drawing.Point(793, 336);
            this.btnGenerarResponsiva.Name = "btnGenerarResponsiva";
            this.btnGenerarResponsiva.Size = new System.Drawing.Size(194, 49);
            this.btnGenerarResponsiva.TabIndex = 7;
            this.btnGenerarResponsiva.Text = "Generar Responsiva";
            this.btnGenerarResponsiva.UseVisualStyleBackColor = false;
            this.btnGenerarResponsiva.Click += new System.EventHandler(this.btnPrevisualizar_Click);
            // 
            // pdVistaPrevia
            // 
            this.pdVistaPrevia.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdVistaPrevia_PrintPage);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(12, 221);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 8;
            this.lblEmpleado.Text = "Empleado";
            this.lblEmpleado.TextChanged += new System.EventHandler(this.LblEmpleado_TextChanged);
            // 
            // btnAddEmpleado
            // 
            this.btnAddEmpleado.Location = new System.Drawing.Point(484, 11);
            this.btnAddEmpleado.Name = "btnAddEmpleado";
            this.btnAddEmpleado.Size = new System.Drawing.Size(75, 38);
            this.btnAddEmpleado.TabIndex = 9;
            this.btnAddEmpleado.Text = "Nuevo Empleado";
            this.btnAddEmpleado.UseVisualStyleBackColor = true;
            this.btnAddEmpleado.Click += new System.EventHandler(this.BtnAddEmpleado_Click);
            // 
            // Responsivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 579);
            this.Controls.Add(this.btnAddEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.btnGenerarResponsiva);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveVP);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Responsivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsivas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveVP;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnGenerarResponsiva;
        private System.Drawing.Printing.PrintDocument pdVistaPrevia;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnAddEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}