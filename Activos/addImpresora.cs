using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasInv.Modulos
{
    public partial class addImpresora : Form
    {
        public addImpresora()
        {
            InitializeComponent();
        }
        public addImpresora(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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
        private void btnAgregarImpresora_Click(object sender, EventArgs e)
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
                    ver.agregarImpresora(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtDireccionIP.Text, txtDireccionMAC.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarImpresora(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtDireccionIP.Text, txtDireccionMAC.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error "+err);
            }
        }
        public void limpieza()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtDireccionIP.Clear();
            txtDireccionMAC.Clear();
        }
        public String fechaIngreso = "";

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
                txtDireccionIP.Focus();
            }
        }

        private void TxtDireccionIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccionMAC.Focus();
            }
        }

        private void TxtDireccionMAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarImpresora.Focus();
            }
        }
    }
}
