using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Inserts
{
    class AddResponsiva
    {
        public string agregarResponsiva(int numeroRegistro, String resguardo, String elaboro)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO responsivas (id, fecha, usuario, elaboro) VALUES (@Registro, @fecha, @usuario, @elaboro)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@Registro", MySqlDbType.VarChar)).Value = numeroRegistro;
                    cmd.Parameters.Add(new MySqlParameter("@fecha", MySqlDbType.DateTime)).Value = DateTime.Now;
                    cmd.Parameters.Add(new MySqlParameter("@usuario", MySqlDbType.VarChar)).Value = resguardo;
                    cmd.Parameters.Add(new MySqlParameter("@elaboro", MySqlDbType.VarChar)).Value = elaboro;

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
        public string agregarDevolucion(int numeroRegistro, String resguardo, String elaboro)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO responsivas (id, fecha, usuario, elaboro) VALUES (@Registro, @fecha, @usuario, @elaboro)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@Registro", MySqlDbType.VarChar)).Value = numeroRegistro;
                    cmd.Parameters.Add(new MySqlParameter("@fecha", MySqlDbType.DateTime)).Value = DateTime.Now;
                    cmd.Parameters.Add(new MySqlParameter("@usuario", MySqlDbType.VarChar)).Value = resguardo;
                    cmd.Parameters.Add(new MySqlParameter("@elaboro", MySqlDbType.VarChar)).Value = elaboro;

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
        public String sql = Properties.Settings.Default.cadenaConexion;
    }
}
