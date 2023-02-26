using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasInv
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SQL.Login.Autorizacion acceder = new SQL.Login.Autorizacion();
            Properties.Settings.Default.Usuario=acceder.logueo(txtUsuario.Text, mtxPassword.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                mtxPassword.Focus();
            }
        }

        private void MtxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lblEstadoDeConexion.Text.Equals("Conectado al servidor"))
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    BtnLogin_Click(sender, e);
                }
            }
            else {
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQL.Conexion checar = new SQL.Conexion();
            lblEstadoDeConexion.Text = checar.validar();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text)|| string.IsNullOrEmpty(mtxPassword.Text))
            {
                Properties.Settings.Default.Usuario = "USUARIO NO AUTENTICADO";
                Properties.Settings.Default.Save();
            }
            else { }
        }
    }
}
