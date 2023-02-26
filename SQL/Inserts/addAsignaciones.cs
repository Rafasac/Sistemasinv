using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Inserts
{
    class addAsignaciones
    {
        public void insertarAsignacion(String activo, Int32 empleado, int responsiva) {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO asignaciones (idAsignacion, fkvp, fkEmpleado, responsiva) VALUES (null, @activo, @empleado, @responsiva)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = activo;
                    cmd.Parameters.Add(new MySqlParameter("@empleado", MySqlDbType.Int32)).Value = empleado;
                    cmd.Parameters.Add(new MySqlParameter("@responsiva", MySqlDbType.Int32)).Value = responsiva;
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
        }

        public void insertarDevolucion(String activo, Int32 empleado, int responsiva)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO devoluciones (idDevolucion, fkvp, fkEmpleado, responsiva) VALUES (null, @activo, @empleado, @responsiva)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = activo;
                    cmd.Parameters.Add(new MySqlParameter("@empleado", MySqlDbType.Int32)).Value = empleado;
                    cmd.Parameters.Add(new MySqlParameter("@responsiva", MySqlDbType.Int32)).Value = responsiva;
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
        }

        public void quitarAsignacion(String activo, Int32 empleado)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.cadenaConexion))
                {
                    cnn.Open();
                    String insertar = "CALL DevolucionDeArticulo(@empleado, @activo)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = activo;
                    cmd.Parameters.Add(new MySqlParameter("@empleado", MySqlDbType.Int32)).Value = empleado;
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
        }
    }
}
