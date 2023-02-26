using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class VerificarEstado
    {
        public string status(String status)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "SELECT  estado FROM estado WHERE vp='"+status+"'";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    return reader.GetValue(0).ToString();

                }
            }
            catch (Exception)
            {
                return "";
            }
        }
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
