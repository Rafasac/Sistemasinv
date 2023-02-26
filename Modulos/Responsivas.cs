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


namespace SistemasInv.Modulos
{
    public partial class Responsivas : Form
    {
        public Responsivas()
        {
            InitializeComponent();
        }

        private void TxtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dgvEmpleado.Rows.Clear();
                try
                {
                    using (MySqlConnection Conexion = new MySqlConnection(sql))
                    {
                        Conexion.Open();
                        //Query.CommandText = "SELECT empleados.idEmpleado, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, departamento.nombre FROM empleados, departamento WHERE empleados.idEmpleado=departamento.fkEmpleado MATCH(nombre, apellidoPaterno, apellidoMaterno) AGAINST('" + txtEmpleado.Text + "' IN BOOLEAN MODE)";
                        Query.CommandText = "SELECT empleados.idEmpleado, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, departamento.nombre, puestos.nombrePuesto FROM empleados, departamento, puestos WHERE empleados.idEmpleado=departamento.fkEmpleado AND empleados.idEmpleado=puestos.fkEmpleado AND MATCH(empleados.nombre, apellidoPaterno, apellidoMaterno) AGAINST('" + txtEmpleado.Text + "' IN BOOLEAN MODE)";

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
                            dgvEmpleado.Rows.Add(numE + "","" + nombre + "", "" + apellidopat + "", "" + apellidomat + "", "" + depa+ "", "" + puesto);
                           
                        }
                        Conexion.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error"+ ex);
                }
                txtEmpleado.Clear();
                dgvEmpleado.Focus();
            }
        }

        
        private void txtVpActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    //Aqui comprobar si esta disponible el activo o si esta en uso
                    SQL.VerificarEstado check = new SQL.VerificarEstado();
                    if (check.status(txtClaveVP.Text).Equals("ASIGNADO"))
                    {
                        MessageBox.Show("El equipo ya esta asignado a otro usuario");
                    }
                    else
                    if (check.status(txtClaveVP.Text).Equals(""))
                    {
                        MessageBox.Show("El activo no esta dado de alta en la base de datos");
                    }
                    else
                    {
                        using (MySqlConnection Conexion = new MySqlConnection(sql))
                        {
                            btnGenerarResponsiva.Enabled = true;
                            Conexion.Open();
                            Query.CommandText = "SELECT tipo FROM activos WHERE vpActivo='" + txtClaveVP.Text + "'";

                            Query.Connection = Conexion;
                            consultar = Query.ExecuteReader();
                            while (consultar.Read())
                            {
                                TIPO = consultar.GetString(0);
                                txtClaveVP.Focus();
                                if (TIPO.Equals("IMPRESORA"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarImpresora('" + txtClaveVP.Text + "');";

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
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarTelefono('" + txtClaveVP.Text + "');";

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
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarLaptop('" + txtClaveVP.Text + "');";

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
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarMovil('" + txtClaveVP.Text + "');";

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
                                if (TIPO.Equals("BOCINAS"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarBocinas('" + txtClaveVP.Text + "');";

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
                                if (TIPO.Equals("PC"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarPc('" + txtClaveVP.Text + "');";

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
                                        n = dgvAsignaciones.Rows.Add();
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarAccesorio('" + txtClaveVP.Text + "');";

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
                                if (TIPO.Equals("CAMARAS"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarCamaras('" + txtClaveVP.Text + "');";

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
                                if (TIPO.Equals("HERRAMIENTAS"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            n = dgvAsignaciones.Rows.Add();
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarHerramientas('" + txtClaveVP.Text + "');";

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
                                if (TIPO.Equals("CONSUMIBLE"))
                                {
                                    try
                                    {
                                        using (MySqlConnection Conexion1 = new MySqlConnection(sql))
                                        {
                                            Conexion1.Open();
                                            Query.CommandText = "CALL cargarConsumible('" + txtClaveVP.Text + "');";

                                            Query.Connection = Conexion1;
                                            consultar = Query.ExecuteReader();
                                            /*while (consultar.Read())
                                            {
                                                dgvAsignaciones.Rows[n].Cells[0].Value = consultar.GetString(0);
                                                dgvAsignaciones.Rows[n].Cells[1].Value = consultar.GetString(1);
                                                dgvAsignaciones.Rows[n].Cells[2].Value = consultar.GetString(2);
                                                dgvAsignaciones.Rows[n].Cells[3].Value = consultar.GetString(3);
                                                dgvAsignaciones.Rows[n].Cells[4].Value = consultar.GetString(4);
                                            }*/
                                            Conexion.Close();
                                        }
                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show("Los consumibles no se pueden asignar en una responsiva:"+ex);
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
                txtClaveVP.Clear();
                txtClaveVP.Focus();
            }
        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != -1)
                {
                    dgvAsignaciones.Rows.RemoveAt(n);
                    n = n - 1;
                }
            }catch 
            {
                
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SQL.Usuarios.ConsultarDepartamento ver = new SQL.Usuarios.ConsultarDepartamento();
            int n = e.RowIndex;
            if (n!= -1)
            {
                lblEmpleado.Text = (string)dgvEmpleado.Rows[n].Cells[1].Value+" "+dgvEmpleado.Rows[n].Cells[2].Value+" "+ dgvEmpleado.Rows[n].Cells[3].Value;
                //departamento= ver.departamento(numE); //Aqui sustituir por el metodo SQL para obtener el departamento
                departamento = (string)dgvEmpleado.Rows[n].Cells[4].Value;
            }
        }

        private void PdVistaPrevia_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(photo, new Point(25, 25));
                e.Graphics.DrawString("R-"+UltimaResponsiva, new Font("Calibri", 10, FontStyle.Bold), Brushes.Red, 750, 10);
                e.Graphics.DrawString("VALLE DE LA PAZ\nDEPARTAMENTO DE SISTEMAS\nRESPONSIVA DE EQUIPOS", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 450, 100);
                e.Graphics.DrawString("LUGAR:\nFECHA:", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, 250);
                e.Graphics.DrawString("OFICINAS ADMINISTRATIVAS\n" + DateTime.Now + ":", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 150, 250);
                e.Graphics.DrawString("DATOS DE LOS EQUIPOS", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, 350);

                const int DGV_ALTO = 35;
                int left = e.MarginBounds.Left, top = e.MarginBounds.Top + 280;

                foreach (DataGridViewColumn col in dgvAsignaciones.Columns)
                {
                    e.Graphics.DrawString(col.HeaderText, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, left, top);
                    left += col.Width;

                    if (col.Index < dgvAsignaciones.ColumnCount)
                        e.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvAsignaciones.RowCount) * DGV_ALTO);
                }
                left = e.MarginBounds.Left;
                e.Graphics.FillRectangle(Brushes.Black, left, top + 40, e.MarginBounds.Right-left+50, 3);//linea superior
                top += 43;
                foreach (DataGridViewRow row in dgvAsignaciones.Rows)
                {
                    if (row.Index == dgvAsignaciones.RowCount) break;
                    left = e.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        e.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 10), Brushes.Black, left, top + 2);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, top, e.MarginBounds.Right+50, top);//lineas horizontales
                }
                //****************************************
                e.Graphics.DrawString("NOMBRE: " + lblEmpleado.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 650);
                e.Graphics.DrawString("DEPARTAMENTO: " + departamento, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 675);
                e.Graphics.DrawString("POR MEDIO DE LA PRESENTE SE HACE CONSTAR QUE TIENE COMO HERRAMIENTAS DE TRABAJO LOS EQUIPOS CON", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 750);
                e.Graphics.DrawString("CARACTERISTICAS YA REFERIDAS ANTERIORMENTE.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 775);
                e.Graphics.DrawString("ASI MISMO SE COMPROMETE A MANTENERLOS EN BUEN ESTADO Y A EMPLEAR EL EQUIPO UNICAMENTE DE ACUERDO", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 800);
                e.Graphics.DrawString("CON LAS CONDICIONES DE LA EMPRESA, OBLIGANDOSE A NO MODIFICARLO NI EL HARDWARE NI EL  SOFTWARE.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 825);
                e.Graphics.DrawString("SI EL EQUIPO PRESENTA ALGUNA FALLA MENCIONADA ANTERIORMENTE SE RESPONSABILIZA AL EMPLEADO", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 50, 875);
                e.Graphics.DrawString("A CUBRIR LA CANTIDAD DEL DAÑO.", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 50, 900);
                e.Graphics.DrawString("                                                                                                       _______________________", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 975);
                e.Graphics.DrawString("                                                                                                                     FIRMA.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 1000);


            }
            catch
            {
                MessageBox.Show("Ocurrio un error de impresión");
            }
        }

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {
            if (lblEmpleado.Text.Equals("Empleado"))
            {
                MessageBox.Show("No ha seleccionado usuario para la responsiva");
            }
            else
            {
                SQL.ConsultarUltimaResponsiva ver = new SQL.ConsultarUltimaResponsiva();
                SQL.Inserts.AddResponsiva adicionar = new SQL.Inserts.AddResponsiva();
                SQL.Inserts.addAsignaciones relacionUsuarioActivo = new SQL.Inserts.addAsignaciones();

                UltimaResponsiva = ver.consultarActivo() + 1;
                adicionar.agregarResponsiva(UltimaResponsiva, lblEmpleado.Text, Properties.Settings.Default.Usuario);

                SQL.Inserts.AddActivos asignar = new SQL.Inserts.AddActivos();
                

                PrintDialog printdlg = new PrintDialog();
                PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
                ((Form)printPrvDlg).WindowState = FormWindowState.Maximized;
                printPrvDlg.Document = pdVistaPrevia;
                printPrvDlg.ShowDialog();

                //Tomando como parametros los valores almacenados en el datagrid es decir sis vp ejemplo VP1502
                dgvAsignaciones.AllowUserToAddRows = false;
                foreach (DataGridViewRow Row in dgvAsignaciones.Rows)
                {
                    String valor = Convert.ToString(dgvAsignaciones.Rows[r++].Cells[4].Value);
                    asignar.activoAsignado(valor);
                    relacionUsuarioActivo.insertarAsignacion(valor, numE, UltimaResponsiva);
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                limpiar();
            }
        }
        public void limpiar() {
            txtEmpleado.Clear();
            txtClaveVP.Clear();
            dgvEmpleado.Rows.Clear();
            dgvAsignaciones.Rows.Clear();
        }
        private int numeroActivosAsignados = 0;
        private int n = 0;
        private int r = 0;
        private String departamento = "";
        public String CLAVE = "";
        public String TIPO = "";
        public String COMENTARIO = "";
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        //private String activosCargados = "";
        //private String responsable = "";
        Image photo = Properties.Resources.vdlpicono;
        private int numE = 0;
        public string sql = Properties.Settings.Default.cadenaConexion;
        String numeroDeEmpleado = "";
        public String eq, marc, mod, ser, act = "";

        private void BtnAddEmpleado_Click(object sender, EventArgs e)
        {
            Modulos.Usuarios.Usuarios agrega = new Modulos.Usuarios.Usuarios();
            agrega.ShowDialog();
        }

        private void LblEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (lblEmpleado.Text == "")
            {
            }
            else
            if (lblEmpleado.Text == "Empleado")
            {

            }
            else {
                txtClaveVP.Enabled=true;
            }
           
        }

        private int UltimaResponsiva = 0;
    }
}
