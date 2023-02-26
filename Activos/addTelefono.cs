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
    public partial class addTelefono : Form
    {
        public addTelefono()
        {
            InitializeComponent();
        }
        public addTelefono(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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

        private void BtnAgregarTelefono_Click(object sender, EventArgs e)
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
                    ver.agregarTelefono(vp, txtExtension.Text, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIp.Text, txtPuerto.Text, txtTarjeta.Text, txtNumeroDirecto.Text);
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos.";
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarTelefono(vp, txtExtension.Text, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIp.Text, txtPuerto.Text, txtTarjeta.Text, txtNumeroDirecto.Text);
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
            ver.agregarTelefono(vp, txtExtension.Text, txtMarca.Text, txtModelo.Text, txtSerie.Text, txtIp.Text, txtPuerto.Text, txtTarjeta.Text, txtNumeroDirecto.Text);
            ver.agregaraActivo(vp, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
            ver.agregarStock(claveActivo);
            limpieza();
            lblEstado.Text = "Informacion almacenada con exito en la base de datos.";*/

        }
        private void limpieza() {
            txtExtension.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtIp.Clear();
            txtExtension.Clear();
            txtPuerto.Clear();
            txtTarjeta.Clear();
            txtNumeroDirecto.Clear();

        }

        private void TxtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMarca.Focus();
            }
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
                txtIp.Focus();
            }
        }

        private void TxtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPuerto.Focus();
            }
        }

        private void TxtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTarjeta.Focus();
            }
        }

        private void TxtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumeroDirecto.Focus();
            }
        }

        private void TxtNumeroDirecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarTelefono.Focus();
            }
        }

        
    }
}
