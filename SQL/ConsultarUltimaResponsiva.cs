using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class ConsultarUltimaResponsiva
    {
        public int consultarActivo()//para consultar ultimaResponsiva()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "CALL ultimaResponsiva()";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (string.IsNullOrEmpty(reader.GetString(0)))
                    {
                        return 1;
                    }
                    else
                    {
                        valor = reader.GetInt32(0);
                        int numeroActivo = (valor);
                        return numeroActivo;
                    }

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int ultimaDevolucion()//para consultar ultimaDevolucion()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "CALL ultimaDevolucion()";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (string.IsNullOrEmpty(reader.GetString(0)))
                    {
                        return 1;
                    }
                    else
                    {
                        valor = reader.GetInt32(0);
                        int numeroActivo = (valor);
                        return numeroActivo;
                    }

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int  valor= 0;
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
