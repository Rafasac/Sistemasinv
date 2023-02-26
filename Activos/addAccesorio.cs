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
    public partial class addAccesorio : Form
    {
        public addAccesorio()
        {
            InitializeComponent();
        }
        public addAccesorio(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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

        private void BtnAgregarAccesorios_Click(object sender, EventArgs e)
        {
            SQL.ConsultarUltimoVP obtener = new SQL.ConsultarUltimoVP();
            String claveActivo = obtener.consultarActivo();

            SQL.Inserts.AddActivos ver = new SQL.Inserts.AddActivos();
            ver.agregarAccesorio(claveActivo, txtMarca.Text, txtModelo.Text, txtSerie.Text, comboBox1.Text);
            ver.agregaraActivo(vp, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
            ver.agregarStock(claveActivo);
            limpieza();
        }
        private void limpieza() {
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
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
                comboBox1.Focus();
            }
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarAccesorios.Focus();
            }
        }
    }
}
