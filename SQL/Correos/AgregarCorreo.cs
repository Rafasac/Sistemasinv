using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Correos
{
    class AgregarCorreo
    { 

        public int id_correo { get; set; }
        public int fk_empleado { get; set; }
        public String email { get; set; }
        public int String { get; set; }

        public string agregarCorreoElectronico(int id, int fkEmpleado, String correo, String pass)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO correos (idCorreo, fkEmpleado, email, pass) VALUES (@id, @fkEmpleado, @correo, @pass)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar)).Value = id;
                    cmd.Parameters.Add(new MySqlParameter("@fkEmpleado", MySqlDbType.VarChar)).Value = fkEmpleado;
                    cmd.Parameters.Add(new MySqlParameter("@correo", MySqlDbType.VarChar)).Value = correo;
                    cmd.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar)).Value = pass;
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


    }
}
