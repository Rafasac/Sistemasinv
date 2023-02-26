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

namespace SistemasInv.Modulos
{
    public partial class ConsultaGeneralActivocs : Form
    {
        public ConsultaGeneralActivocs()
        {
            InitializeComponent();
        }


        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SQL.ConsultaGeneralVP procesa = new SQL.ConsultaGeneralVP();
                SQL.ConsultarEspecificaciones especificar= new SQL.ConsultarEspecificaciones();
                SQL.ConsultarEmpleado consultaEmpleado = new SQL.ConsultarEmpleado();
                //SQL.ConsultarCorreo consultar = new SQL.ConsultarCorreo();

                richTextBox1.Text= procesa.consultarActivo(txtVPActivo.Text);
                richTextBox1.Text=richTextBox1.Text + especificar.especificacionesTecnicas(procesa.clasificacionActivo, txtVPActivo.Text);
                richTextBox1.Text = richTextBox1.Text + consultaEmpleado.nombreDelEmpleado(consultaEmpleado.empleado(txtVPActivo.Text));
            }
        }
    }
}
