using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasInv.Activos
{
    public partial class addPC : Form
    {
        public addPC()
        {
            InitializeComponent();
        }
        public addPC(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
        {
            InitializeComponent();
            this.vp = vp;
            this.fechaCompra = fechaCompra;
            this.tiempoGarantia = tiempoGarantia;
            this.numeroFactura = numeroFactura;
            this.clasificacion = clasificacion;
            this.comentario = comentario;
        }
        String vp;
        DateTime fechaCompra;
        int tiempoGarantia;
        String numeroFactura;
        String clasificacion;
        String comentario;
        private String claveActivo = "";
        private void BtnAgregarPC_Click(object sender, EventArgs e)
        {
             try
            {

                SQL.ConsultarUltimoVP obtener = new SQL.ConsultarUltimoVP();
                SQL.VerificarTabla consultar = new SQL.VerificarTabla();
                SQL.Inserts.AddActivos ver = new SQL.Inserts.AddActivos();
                if (consultar.verificarTablaActivos().Equals("VACIA"))
                {
                    claveActivo = "VP" + Properties.Settings.Default.ValorInicialActivo;
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarPC(vp, txtMarca.Text, txtModelo.Text, txtSerie.Text, Convert.ToDouble(txtMemoria.Text), Convert.ToInt32(txtAlmacenamiento.Text), txtSistema.Text, txtProsesador.Text, txtDireccionIP.Text, txtUsuarioAdministrador.Text, txtPasswordAdministrador.Text, dtpUltimoRespaldo.Value.ToString("yyyy-MM-dd"), dtpUltimoMantenimiento.Value.ToString("yyyy-MM-dd"));
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos."; 
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarPC(vp, txtMarca.Text, txtModelo.Text, txtSerie.Text, Convert.ToDouble(txtMemoria.Text), Convert.ToInt32(txtAlmacenamiento.Text), txtSistema.Text, txtProsesador.Text, txtDireccionIP.Text, txtUsuarioAdministrador.Text, txtPasswordAdministrador.Text, dtpUltimoRespaldo.Value.ToString("yyyy-MM-dd"), dtpUltimoMantenimiento.Value.ToString("yyyy-MM-dd"));
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos."; 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error "+err);
            }
        }
        private void limpieza()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtSistema.Clear();
            txtMemoria.Clear();
            txtAlmacenamiento.Clear();
            txtProsesador.Clear();
            txtDireccionIP.Clear();
            txtUsuarioAdministrador.Clear();
            txtPasswordAdministrador.Clear();
        }

        private void TxtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtModelo.Focus();
            }
        }

        private void TxtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSerie.Focus();
            }
        }
        private void TxtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMemoria.Focus();
            }
        }

        private void TxtMemoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAlmacenamiento.Focus();
            }
        }

        private void TxtAlmacenamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSistema.Focus();
            }
        }

        private void TxtSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtProsesador.Focus();
            }
        }

        private void TxtProsesador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccionIP.Focus();
            }
        }

        private void TxtDireccionIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUsuarioAdministrador.Focus();
            }
        }

        private void TxtUsuarioAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPasswordAdministrador.Focus();
            }
        }

        private void TxtPasswordAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpUltimoRespaldo.Focus();
            }
        }

        private void DtpUltimoRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpUltimoMantenimiento.Focus();
            }
        }

        private void DtpUltimoMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarPC.Focus();
            }
        }
    }
}
