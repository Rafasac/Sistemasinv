using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Usuarios
{
    class ConsultarUltimoUsuario
    {
        public int ultimoEmpleado()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "CALL ultimoEmpleado()";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int numeroActivo = (reader.GetInt32(0) + 1);
                    return  numeroActivo;

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
