using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace SistemasInv.Modulos.Soporte
{
    public partial class TableroSoporteTecnico : Form
    {
        public TableroSoporteTecnico()
        {
            InitializeComponent();
        }

        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "ftp://"+direccion+"/");
        }
        private void BtnServiciosWeb_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", direccion);
        }
        private void TableroSoporteTecnico_Load(object sender, EventArgs e)
        {
            lblIP.Text = obtenerIP();
            direccion = obtenerIP();
        }

        private void BtnServidorMySQL_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", direccion+ "/phpmyadmin/");
        }

        private void BtnHosting_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Chrome.exe", "https://dns20.sysop20.com:8443/login_up.php3?login_name=valledelapaz.com.mx&passwd=#vallesistemas.28#");
                Clipboard.SetText("#vallesistemas.28#");
            }
            catch (Exception) {
                MessageBox.Show("Error al ejecutar acceder al portal");
            }
            
        }

        private void BtnClaveWifi_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ncpa.cpl");
                Clipboard.SetText("VALLE.123#");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar acceder a la herramienta del panel de control");
            }
        }

        private void BtnRdvGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ftp://rafael@192.168.215.40/DEPARTAMENTO DE SISTEMAS/SOFTWARE/chromeremotedesktophost.msi");
            }
            catch (Exception) {
                MessageBox.Show("No se establecio comunicación con el servidor remoto");
            }
        }

        private void BtnManuales_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Users\RAFAEL\Dropbox\Sistemas\Manuales");
            }
            catch (Exception) {
                MessageBox.Show("No se encuentra la carpeta o no esta conectado al servicio de Dropbox");
            }
        }

        private void BtnXampp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("xampp-control.exe");
            }
            catch (Exception) {
                MessageBox.Show("No se puede localizar el elemento:");
            }
        }

        private void BtnDirecionIP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obtenerIP());
        }
        public String obtenerIP() {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        public String direccion = "";
    }
}
