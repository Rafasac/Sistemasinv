using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Inserts
{
    class addUsuario
    {
        public string usuario(int idEmpleado, String nombre, String apellidoP, String apellidoM)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO empleados (idEmpleado, nombre, apellidoPaterno, apellidoMaterno) VALUES (@id, @nombre, @apellidoP, @apellidoM)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = idEmpleado;
                    cmd.Parameters.Add(new MySqlParameter("@nombre", MySqlDbType.VarChar)).Value = nombre;
                    cmd.Parameters.Add(new MySqlParameter("@apellidoP", MySqlDbType.VarChar)).Value = apellidoP;
                    cmd.Parameters.Add(new MySqlParameter("@apellidoM", MySqlDbType.VarChar)).Value = apellidoM;
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
