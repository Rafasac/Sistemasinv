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
    public partial class addCamaras : Form
    {
        public addCamaras()
        {
            InitializeComponent();
        }
        public addCamaras(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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
                 cbTipoCamara.Focus();
                 cbTipoCamara.DroppedDown = true;
            }
        }

        private void CbTipoCamara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarCamara.Focus();
            }
        }

        private void BtnAgregarCamara_Click(object sender, EventArgs e)
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
                    //ver.agregarImpresora(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtDireccionIP.Text, txtDireccionMAC.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    //ver.agregarImpresora(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtDireccionIP.Text, txtDireccionMAC.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err);
            }
        }
        private void limpieza()
        {

            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
        }
    }
}
