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

namespace SistemasInv
{
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
        }

        private void BtnConsultaGeneralActivo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnResponsiva_Click(object sender, EventArgs e)
        {
            Modulos.Responsivas ver = new Modulos.Responsivas();
            ver.ShowDialog();
        }

        private void ReportesDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ConsultaGeneralActivocs ver = new Modulos.ConsultaGeneralActivocs();
            ver.ShowDialog();
        }

        private void ResponsivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Responsivas ver = new Modulos.Responsivas();
            ver.ShowDialog();
        }

        private void AltaDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.AltaActivos ver = new Modulos.AltaActivos();
            ver.ShowDialog();
        }

        private void ModificaciónDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos.modificarActivo ver = new Activos.modificarActivo();
            ver.ShowDialog();
        }

        private void empleadoResponsivaActivo_Click(object sender, EventArgs e)
        {
            Reportes.consultaEmpleadoResponsivaActivo ver = new Reportes.consultaEmpleadoResponsivaActivo();
            ver.ShowDialog();
        }

        private void ListaDeUsuariosVDLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Usuarios.Usuarios ver = new Modulos.Usuarios.Usuarios();
            ver.ShowDialog();
        }

        private void DevoluciónActivoASistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos.DevolucionAS ver = new Activos.DevolucionAS();
            ver.ShowDialog();
        }

        private void BajaDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activos.BajaActivo ver = new Activos.BajaActivo();
            ver.ShowDialog();
        }

        private void EmpleadoActivosAsignadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Usuarios.UsuarioActivos ver = new Modulos.Usuarios.UsuarioActivos();
            ver.Show();
        }

        private void WebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://189.206.184.210/ng/system/dashboard/1");
            Clipboard.SetText("P4ssD31V4LL3");
        }

        private void HistorialDeSoportePorActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Soporte.HistorialSoporte mostrar = new Modulos.Soporte.HistorialSoporte();
            mostrar.ShowDialog();
        }

        private void TableroDeSoporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Soporte.TableroSoporteTecnico mostrar = new Modulos.Soporte.TableroSoporteTecnico();
            mostrar.ShowDialog();
        }

        private void ResponsivaPorCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ActualizaciónDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdministraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Correos.Correos ver = new Modulos.Correos.Correos();
            ver.Show();
        }

        private void ConfiguraciónDeSistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Configuracion.ConfiguracionSistema mostrar = new Modulos.Configuracion.ConfiguracionSistema();
            mostrar.ShowDialog();
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            Login Acceso = new Login();
            Acceso.ShowDialog();
            toolStripLabel1.Text = Properties.Settings.Default.Usuario;
            if (toolStripLabel1.Text.Equals("USUARIO NO AUTENTICADO"))
            {
                controlDeSistemasToolStripMenuItem.Enabled = false;
            }
        }

        private void DevolucionDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Activo.DevolucionActivos ver = new Modulos.Activo.DevolucionActivos();
            ver.ShowDialog();
        }

        private void ConfigurarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.Configuracion.ConfiguracionSistema acceder = new Modulos.Configuracion.ConfiguracionSistema();
            acceder.ShowDialog();
        }
    }
}
