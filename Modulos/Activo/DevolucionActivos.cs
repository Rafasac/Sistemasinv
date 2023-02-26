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
namespace SistemasInv.Modulos.Activo
{
    public partial class DevolucionActivos : Form
    {
        public DevolucionActivos()
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
                    dgvActivosAsignados.Rows.Clear();
                    dgvDescripcionActivo.Rows.Clear();
                    using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        Conexion.Open();
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
                            dgvEmpleado.Rows.Add(numE + "", "" + nombre + "", "" + apellidopat + "", "" + apellidomat + "", "" + depa + "", "" + puesto);

                        }
                        Conexion.Close();
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                txtEmpleado.Clear();
            }
        }
        

        private void DgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                lblEmpleado.Text = (string)dgvEmpleado.Rows[n].Cells[1].Value + " " + dgvEmpleado.Rows[n].Cells[2].Value + " " + dgvEmpleado.Rows[n].Cells[3].Value;
                nEmpleado=Convert.ToInt32(dgvEmpleado.Rows[n].Cells[0].Value.ToString());
                try
                {
                    dgvActivosAsignados.Rows.Clear();
                    using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                    {
                        Conexion.Open();
                        Query.CommandText = "call EmpleadoActivos("+nEmpleado+")";

                        Query.Connection = Conexion;
                        consultar = Query.ExecuteReader();
                        while (consultar.Read())
                        {
                            string VP = consultar.GetString(0);
                            string TIPO = consultar.GetString(1);
                            string FECHA = consultar.GetString(2);
                           dgvActivosAsignados.Rows.Add(VP + "", "" + TIPO + "", "" + FECHA);

                        }
                        Conexion.Close();
                    }
                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    dgvEmpleado.ClearSelection();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error" + ex);
                }

            }
        }
        public String COMENTARIO = "";
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        private int numE = 0;
        String numeroDeEmpleado = "";
        private int nEmpleado =0;
        Image photo = Properties.Resources.vdlpicono;
        private int r = 0;

        private void BtnDevolucion_Click(object sender, EventArgs e)
        {

            SQL.Inserts.addAsignaciones relacionUsuarioActivo = new SQL.Inserts.addAsignaciones();
            SQL.Inserts.AddActivos asignar = new SQL.Inserts.AddActivos();
            SQL.ConsultarUltimaResponsiva ver = new SQL.ConsultarUltimaResponsiva();
            PrintDialog printdlg = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            ((Form)printPrvDlg).WindowState = FormWindowState.Maximized;
            printPrvDlg.Document = pdFormatoDevolucion;
            printPrvDlg.ShowDialog();
            UltimaResponsiva = ver.ultimaDevolucion() + 1;
            foreach (DataGridViewRow Row in dgvDescripcionActivo.Rows)
            {
                String valor = Convert.ToString(dgvDescripcionActivo.Rows[r++].Cells[0].Value);
                asignar.activoStock(valor);
                relacionUsuarioActivo.insertarDevolucion(valor, numE, UltimaResponsiva);
                relacionUsuarioActivo.quitarAsignacion(valor, nEmpleado);
                //eliminar el activo de la asinacion
            }
        }

        private void DgvActivosAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                String ClasificacionDeActivo=(string)(dgvActivosAsignados.Rows[n].Cells[1].Value);
                if (ClasificacionDeActivo.Equals("IMPRESORA")) {
                    //dgvActivosAsignados.Rows[n].Cells[0].Style.BackColor = Color.Red;
                    //dgvActivosAsignados.Rows[n].Cells[1].Style.BackColor = Color.Red;
                    //dgvActivosAsignados.Rows[n].Cells[2].Style.BackColor = Color.Red;
                    n = e.RowIndex;
                    if (n != -1)
                    {
                        try
                        {
                            using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                            {
                                Conexion.Open();
                                Query.CommandText = "CALL DescripcionImpresoraShort('" + (string)(dgvActivosAsignados.Rows[n].Cells[0].Value) + "')";

                                Query.Connection = Conexion;
                                consultar = Query.ExecuteReader();
                                while (consultar.Read())
                                {
                                    string ACTIVO = consultar.GetString(0);
                                    string MARCA = consultar.GetString(1);
                                    string MODELO = consultar.GetString(2);
                                    string SERIE = consultar.GetString(3);
                                   dgvDescripcionActivo.Rows.Add(ACTIVO + "", "" + MARCA + "", "" + MODELO+"", "" + SERIE);

                                }
                                Conexion.Close();
                            }
                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }

                    }
                    //*************************************************************************************+
                    //Remover item seleccionado
                    try
                    {
                        if (n != -1)
                        {
                            dgvActivosAsignados.Rows.RemoveAt(n);
                            n = n - 1;
                        }
                    }
                    catch
                    {

                    }
                    /////////////////////////////////////////////////////////////////////////////////////////
                    dgvActivosAsignados.ClearSelection();
                }
                else
                if (ClasificacionDeActivo.Equals("MOVIL"))
                {
                    dgvActivosAsignados.Rows[n].Cells[0].Style.BackColor = Color.Red;
                    dgvActivosAsignados.Rows[n].Cells[1].Style.BackColor = Color.Red;
                    dgvActivosAsignados.Rows[n].Cells[2].Style.BackColor = Color.Red;
                    n = e.RowIndex;
                    if (n != -1)
                    {
                        try
                        {
                            using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                            {
                                Conexion.Open();
                                Query.CommandText = "CALL DescripcionMovilShort('" + (string)(dgvActivosAsignados.Rows[n].Cells[0].Value) + "')";

                                Query.Connection = Conexion;
                                consultar = Query.ExecuteReader();
                                while (consultar.Read())
                                {
                                    string MARCA = consultar.GetString(0);
                                    string MODELO = consultar.GetString(1);
                                    string SERIE = consultar.GetString(2);
                                    dgvDescripcionActivo.Rows.Add(MARCA + "", "" + MODELO + "", "" + SERIE);

                                }
                                Conexion.Close();
                            }
                        }

                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }

                    }
                    //*************************************************************************************+
                }
                else
                if (ClasificacionDeActivo.Equals("TELEFONO IP"))
                {
                    MessageBox.Show("SE SELECCIONO TELEFONO IP");
                }else
                if (ClasificacionDeActivo.Equals("LAPTOP"))
                {
                    MessageBox.Show("SE SELECCIONO LAPTOP");
                }else
                if (ClasificacionDeActivo.Equals("PC"))
                {
                    MessageBox.Show("SE SELECCIONO PC");
                }
            }

        }

        private void dgvDescripcionActivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void DevolucionActivos_Load(object sender, EventArgs e)
        {

        }

        private void PdFormatoDevolucion_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                SQL.ConsultarUltimaResponsiva ver = new SQL.ConsultarUltimaResponsiva();
                UltimaDevolucion = ver.ultimaDevolucion() + 1;
                e.Graphics.DrawImage(photo, new Point(25, 25));
                e.Graphics.DrawString("D-" + UltimaDevolucion, new Font("Calibri", 10, FontStyle.Bold), Brushes.Red, 750, 10);
                e.Graphics.DrawString("VALLE DE LA PAZ\nDEPARTAMENTO DE SISTEMAS\nHOJA DE LIBERACION DE SISTEMAS", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 450, 100);
                e.Graphics.DrawString("LUGAR:\nFECHA:", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, 250);
                e.Graphics.DrawString("OFICINAS ADMINISTRATIVAS\n" + DateTime.Now + ":", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 150, 250);
                e.Graphics.DrawString("DATOS DE LOS EQUIPOS QUE ENTREGA", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, 350);

                const int DGV_ALTO = 35;
                int left = e.MarginBounds.Left, top = e.MarginBounds.Top + 280;

                foreach (DataGridViewColumn col in dgvDescripcionActivo.Columns)
                {
                    e.Graphics.DrawString(col.HeaderText, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, left, top);
                    left += col.Width;

                    if (col.Index < dgvDescripcionActivo.ColumnCount)
                        e.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvDescripcionActivo.RowCount ) * DGV_ALTO);
                }
                left = e.MarginBounds.Left;
                e.Graphics.FillRectangle(Brushes.Black, left, top + 40, e.MarginBounds.Right - left, 3);
                top += 43;
                foreach (DataGridViewRow row in dgvDescripcionActivo.Rows)
                {
                    //if (row.Index == dgvDescripcionActivo.RowCount - 1) break;
                    if (row.Index == dgvDescripcionActivo.RowCount) break;
                    left = e.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        e.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 10), Brushes.Black, left, top + 2);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, top, e.MarginBounds.Right, top);
                }
                e.Graphics.DrawString("QUEDANDO COMO PENDIENTE:", new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, 650);
                //****************************************
                e.Graphics.DrawString("NOMBRE: " + lblEmpleado.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 750);
                //e.Graphics.DrawString("DEPARTAMENTO: " + departamento, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 675);
                e.Graphics.DrawString("POR MEDIO DE LA PRESENTE SE HACE CONSTAR QUE ENTREGO LOS ACTIVOS A SU CARGO", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 850);
                e.Graphics.DrawString("CARACTERISTICAS YA REFERIDAS ANTERIORMENTE.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 975);
                e.Graphics.DrawString("SE LE LIBERA DE TODA RESPONSAVILIDAD UNA VEZ EVALUADO EL ESTADO DE LOS EQUIPOS", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 950);
                e.Graphics.DrawString("A CUBRIR LA CANTIDAD DEL DAÑO.", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, 50, 900);
                e.Graphics.DrawString("                                                                                                       _______________________", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 975);
                e.Graphics.DrawString("                                                                                                                     FIRMA.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 1000);


            }
            catch
            {
                MessageBox.Show("Ocurrio un error de impresión");
            }
        }
        private int UltimaDevolucion = 0;
        private int UltimaResponsiva = 0;
    }
}
