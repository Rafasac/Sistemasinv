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

namespace SistemasInv.Modulos
{
    public partial class AltaActivos : Form
    {
        public AltaActivos()
        {
            InitializeComponent();
        }

        private void AltaActivos_Load(object sender, EventArgs e)
        {
            SQL.ConsultarUltimoVP obtener = new SQL.ConsultarUltimoVP();
            SQL.VerificarTabla consultar = new SQL.VerificarTabla();
            if (consultar.verificarTablaActivos().Equals("VACIA"))
            {
                lbNumeroActivo.Text = "VP"+Properties.Settings.Default.ValorInicialActivo;
            }
            else {
                lbNumeroActivo.Text = obtener.consultarActivo();
            }
            dtpFechaDeCompra.Focus();
            SendKeys.Send("{F4}");
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
            this.panel1.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            fh.Show();

        }

        private void CbbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTiempoGarantia.Text) || string.IsNullOrEmpty(txtNumeroDeFactura.Text) || string.IsNullOrEmpty(rtbComentario.Text))
            {
            }
            else
            {
                if (cbbClasificacion.Text.Equals("IMPRESORA"))
                {
                    AbrirFormHija(new addImpresora(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("PC"))
                {
                    AbrirFormHija(new Activos.addPC(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("LAPTOP"))
                {
                    AbrirFormHija(new Activos.addLaptop(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("MOVIL"))
                {
                    AbrirFormHija(new Activos.addMovil(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("ACCESORIO"))
                {
                    AbrirFormHija(new Activos.addAccesorio(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("CONSUMIBLE"))
                {
                    AbrirFormHija(new Activos.addConsumibles(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("TELEFONO IP"))
                {
                    AbrirFormHija(new Activos.addTelefono(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("CAMARAS"))
                {
                    AbrirFormHija(new Activos.addCamaras(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("AUDIO"))
                {
                    AbrirFormHija(new Activos.addBocinas(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("DVR"))
                {
                    AbrirFormHija(new Activos.addDvr(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
                else
                if (cbbClasificacion.Text.Equals("RELOJES"))
                {
                    AbrirFormHija(new Activos.addRelojes(lbNumeroActivo.Text, dtpFechaDeCompra.Value, Convert.ToInt32(txtTiempoGarantia.Text), txtNumeroDeFactura.Text, cbbClasificacion.Text, rtbComentario.Text));
                }
            }
        }

        private void TxtTiempoGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNumeroDeFactura.Focus();
            }else
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }


        private void TxtNumeroDeFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                rtbComentario.Focus();
            }
        }

        private void RtbComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbbClasificacion.Focus();
                cbbClasificacion.DroppedDown = true;
            }
        }

        private void DtpFechaDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTiempoGarantia.Focus();
            }
        }
    }
}