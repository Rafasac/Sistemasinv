using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv
{
    class CRUD
    {
        public void insertarUsuario(int usuario, String nombre, String apellidos)
        {

            try
            {
                MySqlConnection cnn = new MySqlConnection(@"server=192.168.215.113; Database=sistemas; Uid = vdlp; pwd ='' ; Port = 3306;");
                cnn.Open();
                String insertar = "INSERT INTO usuarios (Id_Usuario, numeroDeEmpleado, Apellido) values (@usuario, @nombre , @apellidos)";
                MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                cmd.Parameters.Add(new MySqlParameter("@usuario", MySqlDbType.Int32)).Value = usuario;
                cmd.Parameters.Add(new MySqlParameter("@nombre", MySqlDbType.VarChar)).Value = nombre;
                cmd.Parameters.Add(new MySqlParameter("@apellidos", MySqlDbType.VarChar)).Value = apellidos;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Registro :" + usuario + " " + nombre + " " + apellidos + " Exitoso");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void insertarActivo(String activo, int usuario, String departamento, String descripcion, String marca, String modelo, String serie, String fecha_Compra, String factura)
        {

            try
            {
                MySqlConnection cnn = new MySqlConnection(@"server=192.168.215.113; Database=sistemas; Uid = vdlp; pwd ='' ; Port = 3306;");
                cnn.Open();
                String insertar = "INSERT INTO activos (Id_Activo, Usuario, Departamento, Descripcion, Marca, Modelo, Serie, Fecha_Compra, Factura) values (@activo, @usuario, @departamento, @descripcion, @marca, @modelo, @serie, @fecha_Compra, @factura)";
                MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = activo;
                cmd.Parameters.Add(new MySqlParameter("@usuario", MySqlDbType.Int32)).Value = usuario;
                cmd.Parameters.Add(new MySqlParameter("@departamento", MySqlDbType.VarChar)).Value = departamento;
                cmd.Parameters.Add(new MySqlParameter("@descripcion", MySqlDbType.VarChar)).Value = descripcion;
                cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                cmd.Parameters.Add(new MySqlParameter("@fecha_Compra", MySqlDbType.Date)).Value = fecha_Compra;
                cmd.Parameters.Add(new MySqlParameter("@factura", MySqlDbType.VarChar)).Value = factura;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    System.Windows.Forms.MessageBox.Show("Registro :" + activo + " Exitoso");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public int totalUsuarios()
        {
            try
            {
                int id = 0;
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT count(Id_Usuario) FROM usuarios";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    id = consultar.GetInt32(0);
                    return id;
                }
                Conexion.Close();
                return 0;
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return 0;
            }
        }

        public String persona(int empleado)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(sql))
                {
                    Conexion.Open();
                    Query.CommandText = "SELECT * FROM usuarios WHERE Id_Usuario =" + empleado;
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        return consultar.GetString(1) + " " + consultar.GetString(2);
                    }
                    Conexion.Close();
                    return "a";
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
                //Conexion.Close();
                return "b";
            }
        }
        public String activo(int empleado)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(sql))
                {
                    Conexion.Open();
                    Query.CommandText = "SELECT * FROM usuarios WHERE Id_Usuario =" + empleado;
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        return consultar.GetString(1) + " " + consultar.GetString(2);
                    }
                    Conexion.Close();
                    return "a";
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
                //Conexion.Close();
                return "b";
            }
        }

        public String marca(String activo)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(sql))
                {
                    Conexion.Open();
                    Query.CommandText = "SELECT marca FROM espimpresoras WHERE vp ='" + activo + "'";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        return consultar.GetString(0);
                    }
                    Conexion.Close();
                    return "ERROR NO ENCUENTRA INFO ACTIVO";
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
                //Conexion.Close();
                return "ERROR EN CATCH ACTIVO";
            }
        }
        public String modelo(String activo)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(sql))
                {
                    Conexion.Open();
                    Query.CommandText = "SELECT modelo FROM espimpresoras WHERE vp ='" + activo + "'";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        return consultar.GetString(0);
                    }
                    Conexion.Close();
                    return "ERROR NO ENCUENTRA INFO ACTIVO";
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
                //Conexion.Close();
                return "ERROR EN CATCH ACTIVO";
            }
        }
        public String serie(String activo)
        {
            try
            {
                using (MySqlConnection Conexion = new MySqlConnection(sql))
                {
                    Conexion.Open();
                    Query.CommandText = "SELECT serie FROM espimpresoras WHERE vp ='" + activo + "'";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        return consultar.GetString(0);
                    }
                    Conexion.Close();
                    return "ERROR NO ENCUENTRA INFO ACTIVO";
                }
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
                //Conexion.Close();
                return "ERROR EN CATCH ACTIVO";
            }
        }
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = Properties.Settings.Default.cadenaConexion;
        public int contadorCI = 0;
    }
}
