using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class ConsultarUltimoVP
    {
        public string consultarActivo()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "CALL ultimoVP()";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    VPACTIVO = reader.GetValue(0).ToString();
                    int numeroActivo = (Convert.ToInt32(VPACTIVO.Substring(2, VPACTIVO.Length - 2)) + 1);
                    return "VP"+numeroActivo;

                }
            }
            catch (Exception)
            {
                sql = Properties.Settings.Default.Usuario;
                consultarActivo();
                return "No se pudo establecer conexión con el servidor";
            }
        }
        public String VPACTIVO, COMENTARIO = "";
        public String cadenaDeRetorno = "";
        public String clasificacionActivo = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
