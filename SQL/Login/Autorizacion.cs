using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Login
{
    class Autorizacion
    {
        public String logueo(String usuario, String contrasenia)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String consulta = "select nombre from usuariosdesistema where username ='" + usuario + "'"+" AND password='"+contrasenia+"'" ;
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    return u = reader.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {
                return "USUARIO NO AUTENTICADO";
            }
        }
        private String u = "";
    }
}
