using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class VerificarTabla
    {
        public String verificarTablaDepartamento()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "SELECT * FROM departamento";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                            return "NO VACIA";
                    }
                    return "VACIA";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
        public String verificarTablaPuesto()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "SELECT * FROM puesto";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return "NO VACIA";
                    }
                    return "VACIA";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        public String verificarTablaActivos()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "SELECT * FROM activos";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return "NO VACIA";
                    }
                    return "VACIA";
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
