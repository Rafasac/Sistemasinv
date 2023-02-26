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
using System.Drawing.Printing;

namespace SistemasInv.Activos
{
    public partial class BajaActivo : Form
    {
        public BajaActivo()
        {
            InitializeComponent();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dgvAsignaciones.Rows.Clear();
                try
                {
                    using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        Conexion.Open();
                        Query.CommandText = "SELECT empleados.idEmpleado, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, departamento.nombre, puestos.nombrePuesto FROM empleados, departamento, puestos WHERE empleados.idEmpleado=departamento.fkEmpleado AND empleados.idEmpleado=puestos.fkEmpleado AND MATCH(empleados.nombre, apellidoPaterno, apellidoMaterno) AGAINST('" + txtBuscar.Text + "' IN BOOLEAN MODE)";
                        Query.Connection = Conexion;
                        consultar = Query.ExecuteReader();
                        while (consultar.Read())
                        {
                            numeroDeEmpleado = consultar.GetString(0);//VARIABLE PARA OBTENER NUMERO EMPLEADO
                            numE = consultar.GetInt32(0);
                            string nombre = consultar.GetString(1);
                            string apellidopat = consultar.GetString(2);
                            string apellidomat = consultar.GetString(3);
                            string depa = consultar.GetString(4);
                            string puesto = consultar.GetString(5);
                            dgvAsignaciones.Rows.Add(numE + "", "" + nombre + "", "" + apellidopat + "", "" + apellidomat + "", "" + depa + "", "" + puesto);

                        }
                        Conexion.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        private int numE = 0;
        public string sql = Properties.Settings.Default.cadenaConexion;
        String numeroDeEmpleado = "";
    }
}
