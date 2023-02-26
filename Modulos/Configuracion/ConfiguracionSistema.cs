using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasInv.Modulos.Configuracion
{
    public partial class ConfiguracionSistema : Form
    {
        public ConfiguracionSistema()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
           Properties.Settings.Default.Usuario= @"server="+txtIP.Text+"; Database=sistemasvdlp; Uid =Sistemas; pwd =Valle.28; Port = 3306;";
           Properties.Settings.Default.ValorInicialActivo=Convert.ToInt32(txtActivo.Text);
           Properties.Settings.Default.Save();

            /*Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("cadenaConexion");
            config.AppSettings.Settings.Add("cadenaConexion", "server = "+txtIP.Text+"; Database = sistemasvdlp; Uid = Sistemas; pwd = Valle.28; Port = 3306;");
            config.Save(ConfigurationSaveMode.Modified);*/
        }

        private void ConfiguracionSistema_Load(object sender, EventArgs e)
        {
            Modulos.Soporte.TableroSoporteTecnico ver = new Modulos.Soporte.TableroSoporteTecnico();
             txtIP.Text = ver.obtenerIP();
            txtActivo.Text = Properties.Settings.Default.ValorInicialActivo.ToString();
        }
    }
}
