namespace SistemasInv.Modulos.Activo
{
    partial class DevolucionActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucionActivos));
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvActivosAsignados = new System.Windows.Forms.DataGridView();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDescripcionActivo = new System.Windows.Forms.DataGridView();
            this.VPACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.pdFormatoDevolucion = new System.Drawing.Printing.PrintDocument();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcionActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleado.Location = new System.Drawing.Point(12, 12);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(598, 20);
            this.txtEmpleado.TabIndex = 0;
            this.txtEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpleado_KeyPress);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToResizeColumns = false;
            this.dgvEmpleado.AllowUserToResizeRows = false;
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleado.ColumnHeadersHeight = 30;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.APELLIDOPATERNO,
            this.APELLIDOMATERNO,
            this.DEPARTAMENTO,
            this.PUESTO});
            this.dgvEmpleado.EnableHeadersVisualStyles = false;
            this.dgvEmpleado.GridColor = System.Drawing.Color.White;
            this.dgvEmpleado.Location = new System.Drawing.Point(12, 61);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersVisible = false;
            this.dgvEmpleado.Size = new System.Drawing.Size(644, 162);
            this.dgvEmpleado.TabIndex = 1;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleado_CellClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68529F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.FillWeight = 110.863F;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // APELLIDOPATERNO
            // 
            this.APELLIDOPATERNO.FillWeight = 110.863F;
            this.APELLIDOPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APELLIDOPATERNO.Name = "APELLIDOPATERNO";
            this.APELLIDOPATERNO.ReadOnly = true;
            // 
            // APELLIDOMATERNO
            // 
            this.APELLIDOMATERNO.FillWeight = 110.863F;
            this.APELLIDOMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APELLIDOMATERNO.Name = "APELLIDOMATERNO";
            this.APELLIDOMATERNO.ReadOnly = true;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.FillWeight = 110.863F;
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.ReadOnly = true;
            // 
            // PUESTO
            // 
            this.PUESTO.FillWeight = 110.863F;
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(681, 15);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(79, 17);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dgvActivosAsignados
            // 
            this.dgvActivosAsignados.AllowUserToAddRows = false;
            this.dgvActivosAsignados.AllowUserToResizeColumns = false;
            this.dgvActivosAsignados.AllowUserToResizeRows = false;
            this.dgvActivosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivosAsignados.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivosAsignados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivosAsignados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivosAsignados.ColumnHeadersHeight = 25;
            this.dgvActivosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActivosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTIVO,
            this.TIPO,
            this.FECHA});
            this.dgvActivosAsignados.EnableHeadersVisualStyles = false;
            this.dgvActivosAsignados.GridColor = System.Drawing.Color.White;
            this.dgvActivosAsignados.Location = new System.Drawing.Point(12, 259);
            this.dgvActivosAsignados.Name = "dgvActivosAsignados";
            this.dgvActivosAsignados.ReadOnly = true;
            this.dgvActivosAsignados.RowHeadersVisible = false;
            this.dgvActivosAsignados.Size = new System.Drawing.Size(644, 167);
            this.dgvActivosAsignados.TabIndex = 3;
            this.dgvActivosAsignados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActivosAsignados_CellClick);
            // 
            // ACTIVO
            // 
            this.ACTIVO.HeaderText = "ACTIVO";
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.ReadOnly = true;
            this.ACTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA ASIGNACION";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar articulo a devolución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion del articulo a devolver";
            // 
            // dgvDescripcionActivo
            // 
            this.dgvDescripcionActivo.AllowUserToAddRows = false;
            this.dgvDescripcionActivo.AllowUserToResizeColumns = false;
            this.dgvDescripcionActivo.AllowUserToResizeRows = false;
            this.dgvDescripcionActivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescripcionActivo.BackgroundColor = System.Drawing.Color.White;
            this.dgvDescripcionActivo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescripcionActivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDescripcionActivo.ColumnHeadersHeight = 25;
            this.dgvDescripcionActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDescripcionActivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VPACTIVO,
            this.MARCA,
            this.MODELO,
            this.SERIE});
            this.dgvDescripcionActivo.EnableHeadersVisualStyles = false;
            this.dgvDescripcionActivo.Location = new System.Drawing.Point(12, 454);
            this.dgvDescripcionActivo.Name = "dgvDescripcionActivo";
            this.dgvDescripcionActivo.ReadOnly = true;
            this.dgvDescripcionActivo.RowHeadersVisible = false;
            this.dgvDescripcionActivo.Size = new System.Drawing.Size(644, 167);
            this.dgvDescripcionActivo.TabIndex = 7;
            this.dgvDescripcionActivo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescripcionActivo_CellClick);
            // 
            // VPACTIVO
            // 
            this.VPACTIVO.HeaderText = "ACTIVO";
            this.VPACTIVO.Name = "VPACTIVO";
            this.VPACTIVO.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // SERIE
            // 
            this.SERIE.HeaderText = "SERIE";
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.Green;
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.Location = new System.Drawing.Point(947, 61);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(189, 52);
            this.btnDevolucion.TabIndex = 8;
            this.btnDevolucion.Text = "Generar formato de devolución";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.BtnDevolucion_Click);
            // 
            // pdFormatoDevolucion
            // 
            this.pdFormatoDevolucion.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdFormatoDevolucion_PrintPage);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Green;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(669, 61);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(189, 52);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar de la lista";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DevolucionActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 657);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.dgvDescripcionActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActivosAsignados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DevolucionActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dgvDescripcionActivo";
            this.Load += new System.EventHandler(this.DevolucionActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcionActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvActivosAsignados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDescripcionActivo;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Drawing.Printing.PrintDocument pdFormatoDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn VPACTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
    }
}