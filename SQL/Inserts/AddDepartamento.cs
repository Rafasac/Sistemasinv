using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Inserts
{
    class AddDepartamento
    {
        public string departamento(String nombre, int fkEmpleado)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO departamento (idDepartamento, nombre, fkEmpleado) VALUES (null, @nombre, @fkEmpleado)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@nombre", MySqlDbType.VarChar)).Value = nombre;
                    cmd.Parameters.Add(new MySqlParameter("@fkEmpleado", MySqlDbType.VarChar)).Value = fkEmpleado;
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return "SE INSERTO EL REGISTRO";
        }
        private String sql = Properties.Settings.Default.cadenaConexion;
    }
}
