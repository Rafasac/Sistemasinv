namespace SistemasInv.Modulos.Usuarios
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.btnExportarListaEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 25;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.nombreEmpleado,
            this.apellidoPaternoEmpleado,
            this.apellidoMaternoEmpleado,
            this.Departamento,
            this.Puesto});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 221);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(1260, 426);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // idEmpleado
            // 
            this.idEmpleado.FillWeight = 21.18419F;
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.Name = "idEmpleado";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.FillWeight = 124.9403F;
            this.nombreEmpleado.HeaderText = "NOMBRE";
            this.nombreEmpleado.Name = "nombreEmpleado";
            // 
            // apellidoPaternoEmpleado
            // 
            this.apellidoPaternoEmpleado.FillWeight = 121.8274F;
            this.apellidoPaternoEmpleado.HeaderText = "APELLIDO PATERNO";
            this.apellidoPaternoEmpleado.Name = "apellidoPaternoEmpleado";
            // 
            // apellidoMaternoEmpleado
            // 
            this.apellidoMaternoEmpleado.FillWeight = 132.0481F;
            this.apellidoMaternoEmpleado.HeaderText = "APELLIDO MATERNO";
            this.apellidoMaternoEmpleado.Name = "apellidoMaternoEmpleado";
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "DEPARTAMENTO";
            this.Departamento.Name = "Departamento";
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "PUESTO";
            this.Puesto.Name = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "ADMINISTRACION",
            "COMPRAS",
            "MANTENIMIENTO",
            "LABORATORIO EMBALSAMIENTO",
            "SISTEMAS",
            "COBRANZA",
            "CAPILLA SAN NICOLAS",
            "CAPILLA SAN PEDRO",
            "SEGURIDAD",
            "VENTAS",
            "DISEÑO Y PUBLICIDAD",
            "RH NOMINAS",
            "TELEMARKETING",
            "CONTABILIDAD"});
            this.cbDepartamento.Location = new System.Drawing.Point(106, 98);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(251, 21);
            this.cbDepartamento.TabIndex = 14;
            this.cbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbDepartamento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido materno";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(106, 72);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(251, 20);
            this.txtApellidoMaterno.TabIndex = 12;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMaterno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido paterno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(106, 46);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(251, 20);
            this.txtApellidoPaterno.TabIndex = 10;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPaterno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(106, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(282, 166);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Puesto";
            // 
            // cbPuesto
            // 
            this.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "ALBAÑIL",
            "ALMACEN",
            "ASESOR TELEFONICO",
            "AUDITORIA Y ARCHIVO",
            "AUXILIAR DE ADMINISTRACION",
            "AUXILIAR EMBALSAMADOR",
            "AUXILIAR DE PROYECTOS",
            "AUXILIAR DE DIRECTOR",
            "AUXILIAR DE DISEÑO Y PUBLICIDAD",
            "AUXILIAR ELECTRICO",
            "AUXILIAR RH Y NOMINAS",
            "AUXILIAR",
            "AUXILIAR CONTABLE",
            "AUXILIAR DE DISEÑO GRAFICO",
            "AUXILIAR DE MERCADOTECNIA",
            "CHOFER",
            "CHOFER DE CAPILLA",
            "COORDINADOR DE LOGISTICA",
            "COORDINADOR DE COMPRA",
            "COORDINADOR DE SEGURIDAD",
            "COORDINADOR DE SISTEMAS",
            "COORDINADOR DE VENTAS",
            "COORDINADOR DE CAPILLAS",
            "CREMADOR",
            "CUENTAS POR COBRAR",
            "DIRECTOR FUNERARIO",
            "ELECTRICISTA",
            "EMBALSAMADOR",
            "ENCARGADO DE CAPILLA",
            "GUARDIA",
            "JARDINERO",
            "JEFE DE MANTENIMIENTO",
            "LOGISTICA",
            "MANTENIMIENTO DE CAPILLAS",
            "MANTENIMIENTO DE OFICINAS",
            "MENSAJERO",
            "OFICIAL ALBAÑIL",
            "RECEPCION",
            "RECEPCION DE VENTAS",
            "REPRESENTANTE DE VENTAS",
            "RESPONSABLE DE PUBLICIDAD",
            "RH NOMINAS",
            "SISTEMAS",
            "SUPERVISOR DE TELEMARKETING",
            "VENTAS"});
            this.cbPuesto.Location = new System.Drawing.Point(106, 130);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(251, 21);
            this.cbPuesto.TabIndex = 17;
            this.cbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbPuesto_KeyPress);
            // 
            // btnExportarListaEmpleados
            // 
            this.btnExportarListaEmpleados.BackgroundImage = global::SistemasInv.Properties.Resources.Excel2019;
            this.btnExportarListaEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarListaEmpleados.Location = new System.Drawing.Point(15, 166);
            this.btnExportarListaEmpleados.Name = "btnExportarListaEmpleados";
            this.btnExportarListaEmpleados.Size = new System.Drawing.Size(50, 50);
            this.btnExportarListaEmpleados.TabIndex = 19;
            this.btnExportarListaEmpleados.UseVisualStyleBackColor = true;
            this.btnExportarListaEmpleados.Click += new System.EventHandler(this.BtnExportarListaEmpleados_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 661);
            this.Controls.Add(this.btnExportarListaEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Button btnExportarListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}