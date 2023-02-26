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

namespace SistemasInv.Activos
{
    public partial class DevolucionAS : Form
    {
        public DevolucionAS()
        {
            InitializeComponent();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SQL.Inserts.AddActivos ver = new SQL.Inserts.AddActivos();
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    //Aqui comprobar si esta disponible el activo o si esta en uso
                    SQL.VerificarEstado check = new SQL.VerificarEstado();
                    if (check.status(txtBuscar.Text).Equals("STOCK"))
                    {
                        MessageBox.Show("El activo esta en stock");
                    }
                    else
                    {
                        using (MySqlConnection Conexion = new MySqlConnection(sql))
                        {

                            Conexion.Open();
                            Query.CommandText = "SELECT tipo FROM activos WHERE vpActivo='" + txtBuscar.Text + "'";

                            Query.Connection = Conexion;
                            consultar = Query.ExecuteReader();
                            n = dgvAsignaciones.Rows.Add();
                            while (consultar.Read())
                            {

                                TIPO = consultar.GetString(0);
                                txtBuscar.Focus();
                                if (TIPO.Equals("IMPRESORA"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarImpresora('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }
                                else
                                if (TIPO.Equals("TELEFONO IP"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarTelefono('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }
                                else
                                if (TIPO.Equals("LAPTOP"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarLaptop('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }
                                else
                                if (TIPO.Equals("MOVIL"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarMovil('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }
                                else
                                if (TIPO.Equals("ACCESORIO"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarAccesorio('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }else
                                if (TIPO.Equals("PC"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarPc('" + txtBuscar.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Error: " + ex);
                                    }

                                }

                            }
                            Conexion.Close();
                        }
                    }
                }
                catch (MySqlException)
                {
                    //MessageBox.Show("Error");
                }
            }
        }
        public String sql = Properties.Settings.Default.cadenaConexion;
        //private int numeroActivosAsignados = 0;
        private int n = 0;
        private int r = 0;
        //private String departamento = "";
        public String CLAVE = "";
        public String TIPO = "";
        public String COMENTARIO = "";
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        Image photo = Properties.Resources.vdlpicono;
        public String eq, marc, mod, ser, act = "";

        private void BtnDevolucion_Click(object sender, EventArgs e)
        {
            SQL.Inserts.AddActivos asignar = new SQL.Inserts.AddActivos();
            foreach (DataGridViewRow Row in dgvAsignaciones.Rows)
            {
                asignar.activoStock(Convert.ToString(dgvAsignaciones.Rows[r++].Cells[4].Value));
            }
            txtBuscar.Clear();
            dgvAsignaciones.Refresh();
        }
    }
}
