using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;

namespace SistemasInv.Modulos.Usuarios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    Conexion.Open();
                    Query.CommandText = "ConsultaEmpleados()";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        int id = consultar.GetInt32(0);
                        string nombre = consultar.GetString(1);
                        string apellidoPaterno = consultar.GetString(2);
                        string apellidoMaterno = consultar.GetString(3);
                        string departamento = consultar.GetString(4);
                        string puesto = consultar.GetString(5);
                        dgvUsuarios.Rows.Add(id + "", "" + nombre + "", "" + apellidoPaterno + "", "" + apellidoMaterno + "",""+departamento+"",""+puesto);
                    }
                    Conexion.Close();
                }
                alternarColor(dgvUsuarios);// se llama al metodo que realiza la cambio de colores entre filas del datagridview 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        //variables
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        private int PrimerValor = 1;

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidoPaterno.Text) || string.IsNullOrEmpty(txtApellidoPaterno.Text))
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (cbDepartamento.SelectedIndex.Equals(-1))
            {

                MessageBox.Show("SELECCIONE EL DEPARTAMENTO AL QUE PERTENECE EL EMPLEADO");
                return;
            }
            if (cbPuesto.SelectedIndex.Equals(-1))
            {

                MessageBox.Show("SELECCIONE EL PUESTO DEL EMPLEADO");
                return;
            }
            else
            {
                SQL.Usuarios.ConsultarUltimoUsuario consulta = new SQL.Usuarios.ConsultarUltimoUsuario();
                SQL.Inserts.addUsuario insertarUsuario = new SQL.Inserts.addUsuario();
                SQL.Inserts.AddDepartamento insertarDepartamento = new SQL.Inserts.AddDepartamento();
                SQL.Inserts.addPuesto insertarPuesto = new SQL.Inserts.addPuesto();
                SQL.VerificarTabla consultar = new SQL.VerificarTabla();
                if (consultar.verificarTablaDepartamento().Equals("VACIA")) {
                    int ultimoEmpleado = consulta.ultimoEmpleado();
                    insertarUsuario.usuario(ultimoEmpleado, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text);
                    insertarPuesto.puesto(cbPuesto.Text, 1);
                    insertarDepartamento.departamento(cbDepartamento.Text, 1);
                }
                else
                {
                    int ultimoEmpleado = consulta.ultimoEmpleado();
                    insertarUsuario.usuario(ultimoEmpleado, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text);
                    insertarDepartamento.departamento(cbDepartamento.Text, ultimoEmpleado);
                    insertarPuesto.puesto(cbPuesto.Text, ultimoEmpleado);
                }
                dgvUsuarios.Rows.Clear();
                Usuarios_Load(sender, e);
                limpieza();
            }
        }
        private void limpieza()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
        }
        //Este metodo es para alternar el color en la datagridview de los empleados
        public void alternarColor(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Teal;
            //dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
        }

        private void BtnExportarListaEmpleados_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvUsuarios);
        }

        //Metodo para exportar la informacion del datagridview a Excel
        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoPaterno.Focus();
            }
        }

        private void TxtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void TxtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDepartamento.Focus();
                cbDepartamento.DroppedDown = true;
            }
        }

        private void CbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbPuesto.Focus();
                cbPuesto.DroppedDown = true;
            }
        }

        private void CbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarUsuario.Focus();
            }
        }
    }
}
