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

namespace SistemasInv.Activos
{
    public partial class modificarActivo : Form
    {
        public modificarActivo()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SQL.Activos.TipoActivo mostrar = new SQL.Activos.TipoActivo();
                lblTipoActivo.Text= mostrar.CategoriaActivo(txtActivos.Text);
                if (lblTipoActivo.Text.Equals("IMPRESORA"))
                {
                    AbrirFormHija(new Modulos.addImpresora());
                }
            }
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
    }
}
