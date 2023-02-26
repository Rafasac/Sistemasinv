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
    public partial class addMovil : Form
    {
        public addMovil()
        {
            InitializeComponent();
        }
        public addMovil(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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

        private void BtnAgregarMovil_Click(object sender, EventArgs e)
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
                    ver.agregarMovil(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIP.Text, txtCuenta.Text, txtPassCuenta.Text, txtPassSistema.Text, txtImei.Text, txtNumeroTelefono.Text, txtMemoriaRam.Text, txtMemoriaRom.Text, txtSistemaOperativo.Text, txtCamara.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos.";
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarMovil(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIP.Text, txtCuenta.Text, txtPassCuenta.Text, txtPassSistema.Text, txtImei.Text, txtNumeroTelefono.Text, txtMemoriaRam.Text, txtMemoriaRom.Text, txtSistemaOperativo.Text, txtCamara.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos.";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err);
            }
            /*SQL.ConsultarUltimoVP obtener = new SQL.ConsultarUltimoVP();
            String claveActivo = obtener.consultarActivo();

            SQL.Inserts.AddActivos ver = new SQL.Inserts.AddActivos();
            ver.agregarMovil(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIP.Text, txtCuenta.Text, txtPassCuenta.Text, txtPassSistema.Text, txtImei.Text, txtNumeroTelefono.Text, txtMemoriaRam.Text, txtMemoriaRom.Text, txtSistemaOperativo.Text, txtCamara.Text);
            ver.agregaraActivo(vp, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
            ver.agregarStock(claveActivo);
            limpieza();
            lblEstado.Text = "Informacion almacenada con exito en la base de datos*/
        }
        private void limpieza()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtIP.Clear();
            txtCuenta.Clear();
            txtPassCuenta.Clear();
            txtPassSistema.Clear();
            txtImei.Clear();
            txtNumeroTelefono.Clear();
            txtMemoriaRam.Clear();
            txtMemoriaRom.Clear();
            txtSistemaOperativo.Clear();
            txtCamara.Clear();
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
                txtIP.Focus();
            }
        }

        private void TxtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCuenta.Focus();
            }
        }

        private void TxtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassCuenta.Focus();
            }
        }

        private void TxtPassCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassSistema.Focus();
            }
        }

        private void TxtPassSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtImei.Focus();
            }
        }

        private void TxtImei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumeroTelefono.Focus();
            }
        }
        private void TxtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMemoriaRam.Focus();
            }
        }

        private void TxtMemoriaRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMemoriaRom.Focus();
            }
        }

        private void TxtMemoriaRom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtSistemaOperativo.Focus();
            }
        }

        private void TxtSistemaOperativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCamara.Focus();
            }
        }

        private void TxtCamara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarMovil.Focus();
            }
        }

        
    }
}
