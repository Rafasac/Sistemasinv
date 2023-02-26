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
    public partial class addConsumibles : Form
    {
        public addConsumibles()
        {
            InitializeComponent();
        }
        public addConsumibles(String vp, DateTime fechaCompra, int tiempoGarantia, String numeroFactura, String clasificacion, String comentario)
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

        private void BtnAgregarConsumibles_Click(object sender, EventArgs e)
        {
            SQL.ConsultarUltimoVP obtener = new SQL.ConsultarUltimoVP();
            String claveActivo = obtener.consultarActivo();

            SQL.Inserts.AddActivos ver = new SQL.Inserts.AddActivos();
            ver.agregarConsumibles(claveActivo, txtNombre.Text, txtUnidades.Text);
            ver.agregaraActivo(vp, fechaCompra.ToString("yyyy-MM-dd HH:mm:ss"), tiempoGarantia.ToString(), numeroFactura, clasificacion, comentario);
            ver.agregarStock(claveActivo);
        }
    }
}
