using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class Conexion
    {
        public String validar()
        {

            using (MySqlConnection Conexion = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
            {
                try
                {
                    Conexion.Open();
                    return "Conectado al servidor";
                }
                catch (Exception e)
                {
                    return "No se pudo conectar al servidor";
                }
            }
        }
    }
}
