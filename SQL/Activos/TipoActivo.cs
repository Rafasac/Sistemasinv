using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Activos
{
    class TipoActivo
    {
        public String CategoriaActivo(String activoVp)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String consulta = "select tipo from activos where vpActivo ='" +activoVp+ "' LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    return reader.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {
                return "No hay coincidencia";
            }
        } 
    }
}
