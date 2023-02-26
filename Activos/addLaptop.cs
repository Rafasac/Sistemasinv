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
    public partial class addLaptop : Form
    {
        public addLaptop()
        {
            InitializeComponent();
        }
        public addLaptop(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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

        private void BntAgregarLaptop_Click(object sender, EventArgs e)
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
                    ver.agregarLaptop(vp, txtMarca.Text, txtModelo.Text, txtSerie.Text, Convert.ToDouble(txtMemoria.Text), Convert.ToInt32(txtAlmacenamiento.Text), txtSistema.Text, txtProsesador.Text, txtDireccionIP.Text, txtUsuarioAdministrador.Text, txtPasswordAdministrador.Text, dtpUltimoRespaldo.Value.ToString("yyyy-MM-dd"), dtpUltimoMantenimiento.Value.ToString("yyyy-MM-dd"));
                    ver.agregarStock(claveActivo);
                    limpieza();
                    lblEstado.Text = "Informacion almacenada con exito en la base de datos.";
                }
                else
                {
                    claveActivo = obtener.consultarActivo();
                    ver.agregaraActivo(claveActivo, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
                    ver.agregarLaptop(vp, txtMarca.Text, txtModelo.Text, txtSerie.Text, Convert.ToDouble(txtMemoria.Text), Convert.ToInt32(txtAlmacenamiento.Text), txtSistema.Text, txtProsesador.Text, txtDireccionIP.Text, txtUsuarioAdministrador.Text, txtPasswordAdministrador.Text, dtpUltimoRespaldo.Value.ToString("yyyy-MM-dd"), dtpUltimoMantenimiento.Value.ToString("yyyy-MM-dd"));
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
            ver.agregarLaptop(vp, txtMarca.Text, txtModelo.Text, txtSerie.Text, Convert.ToDouble(txtMemoria.Text), Convert.ToInt32(txtAlmacenamiento.Text), txtSistema.Text, txtProsesador.Text, txtDireccionIP.Text, txtUsuarioAdministrador.Text, txtPasswordAdministrador.Text, dtpUltimoRespaldo.Value.ToString("yyyy-MM-dd"), dtpUltimoMantenimiento.Value.ToString("yyyy-MM-dd"));
            ver.agregaraActivo(vp, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
            ver.agregarStock(claveActivo);
            limpieza();
            lblEstado.Text = "Informacion almacenada con exito en la base de datos.";*/
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
    }
}
