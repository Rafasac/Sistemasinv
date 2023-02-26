using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class ConsultarCorreo
    {
        public String email(int numeroEmpleado, string tipo)
        {
            if (tipo.Equals("PC") || tipo.Equals("LAPTOP"))
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(sql))
                    {
                        cnn.Open();
                        String consulta = "select * from correos where fkEmpleado ='" + numeroEmpleado + "'";
                        MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        EMAIL = reader.GetValue(2).ToString();
                        PASS = reader.GetValue(3).ToString();
                        return cadena = cadena + "\n\nCORREOS \nCorreo electrónico:" + EMAIL + "\nContraseña: " + PASS + "\n";
                    }
                }
                catch (Exception)
                {
                    return "";
                }
            }
            else { return ""; }
        }
        public String cadena = "";
        public String EMAIL, PASS = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
