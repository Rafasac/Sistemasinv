using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class ConsultarEmpleado
    {
        public int empleado(String codigoActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from asignaciones where fkvp ='" + codigoActivo + "'";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    idEmpleado = Convert.ToInt32(reader.GetValue(2));
                    return idEmpleado;
                }
             }
             catch (Exception)
             {
                 return 0;
             }
            
        }
        public String nombreDelEmpleado(int idEmpleado)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from empleados where idEmpleado ='" + idEmpleado + "'";

                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    NOMBRE = reader.GetValue(1).ToString();
                    APELLIDOPATERNO = reader.GetValue(3).ToString();
                    APELLIDOMATERNO = reader.GetValue(2).ToString();
                    return "\n\nEL RESPONSABLE DEL EQUIPO ES:\n" + NOMBRE + " " + APELLIDOPATERNO + " " + APELLIDOMATERNO;
                }
            }
            catch (Exception)
            {
                return "";
            }

        }
        public String cadena = "";
        public String NOMBRE, APELLIDOPATERNO, APELLIDOMATERNO = "";
        public int idEmpleado = 0;
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
