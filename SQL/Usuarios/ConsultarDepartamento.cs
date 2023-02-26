using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Usuarios
{
    class ConsultarDepartamento
    {
        public string departamento(int usuario)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "SELECT nombre FROM departamento WHERE fkEmpleado="+usuario;
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    DEPARTAMENTO = reader.GetValue(0).ToString();
                    return DEPARTAMENTO;

                }
            }
            catch (Exception exc)
            {
                return "Error "+ exc;
            }
        }
        public String DEPARTAMENTO = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}