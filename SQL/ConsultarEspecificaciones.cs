using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SistemasInv.SQL
{
    class ConsultarEspecificaciones
    {
        //METODO PARA CONSULTAR ESPECIFICACIONES DE UN ACTIVO
        public String especificacionesTecnicas(String categoria, String activo)
        {
            if (categoria.Equals("PC"))
            {
                return categoriaPC(activo);
            }
            else
            if (categoria.Equals("MOVIL"))
            {
                return categoriaMovil(activo);
            }
            else
            if (categoria.Equals("LAPTOP"))
            {
                return categoriaLaptop(activo);
            }
            else
            if (categoria.Equals("IMPRESORA"))
            {
                return categoriaImpresora(activo);
            }
            else
            if (categoria.Equals("TELEFONO"))
            {
                return categoriaTelefono(activo);
            }
            else
            if (categoria.Equals("ACCESORIO"))
            {
                return "";
            }
            else{ return ""; }
        }
        //METODOS PARA BUSCAR LAS ESPECIFICACIONES DE LOS ACTIVOS
        public String categoriaPC(String codigoActivo) {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from esppc where vp ='" + codigoActivo + "'";

                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MARCA = reader.GetValue(1).ToString();
                    MODELO = reader.GetValue(2).ToString();
                    SERIE = reader.GetValue(3).ToString();
                    MEMORIA = reader.GetValue(4).ToString();
                    ALMACENAMIENTO = reader.GetValue(5).ToString();
                    SISTEMA = reader.GetValue(6).ToString();

                    return cadenaDeRetorno = cadenaDeRetorno + "\n\nESPECIFICACIONES TECNICAS\n\nMarca: " + MARCA + "\n" +
                        "Modelo" + MODELO + "\nSerie: " + SERIE + "\nMemoria: " + MEMORIA + " GB" +
                        "\nAlmacenamiento: " + ALMACENAMIENTO + "GB" + "\nSistema operativo: " + SISTEMA;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR CLAVE NO ENCONTRADA");
                return "NO SE ENCONTRO REGISTRO";
            }
        }

        public String categoriaLaptop(String codigoActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from esplaptop where vp ='" + codigoActivo + "'";

                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MARCA = reader.GetValue(1).ToString();
                    MODELO = reader.GetValue(2).ToString();
                    SERIE = reader.GetValue(3).ToString();
                    MEMORIA = reader.GetValue(4).ToString();
                    ALMACENAMIENTO = reader.GetValue(5).ToString();
                    SISTEMA = reader.GetValue(6).ToString();

                    return cadenaDeRetorno = cadenaDeRetorno + "\n\nESPECIFICACIONES TECNICAS\n\nMarca: " + MARCA + "\n" +
                        "Modelo" + MODELO + "\nSerie: " + SERIE + "\nMemoria: " + MEMORIA + " GB" +
                        "\nAlmacenamiento: " + ALMACENAMIENTO + "GB" + "\nSistema operativo: " + SISTEMA;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR CLAVE NO ENCONTRADA");
                return "NO SE ENCONTRO REGISTRO";
            }
        }

        public String categoriaMovil(String codigoActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from espmovil where vp ='" + codigoActivo + "'";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MARCA = reader.GetValue(1).ToString();
                    MODELO = reader.GetValue(2).ToString();
                    SERIE = reader.GetValue(3).ToString();
                    IP = reader.GetValue(4).ToString();
                    CUENTA = reader.GetValue(5).ToString();
                    PASSCUENTA = reader.GetValue(6).ToString();
                    PASSSISTEMA = reader.GetValue(7).ToString();
                    IMEI = reader.GetValue(8).ToString();
                    NUMTELEFONO = reader.GetValue(9).ToString();
                    RAM = reader.GetValue(10).ToString();
                    ROM = reader.GetValue(11).ToString();

                    return cadenaDeRetorno = cadenaDeRetorno + "\n\nESPECIFICACIONES TECNICAS\n\nMarca: " + MARCA + "\n" +
                        "Modelo" + MODELO + "\nSerie: " + SERIE + "\nIp: " + IP + "\n" +
                        "Cuenta: " + CUENTA + "\nPassword cuenta: " + PASSCUENTA + "\nPassword de sistema operativo: " + PASSSISTEMA
                        + "\nIMEI: " + IMEI + "\nNumero de telefono: " + NUMTELEFONO + "\nMemoria RAM: " + RAM + "\nMemoria ROM: " + ROM;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR CLAVE NO ENCONTRADA:  ");
                return "NO SE ENCONTRO REGISTRO";
            }
        }

        public String categoriaImpresora(String codigoActivo)
        {
            try {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from espimpresoras where vp ='" + codigoActivo + "'";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MARCA = reader.GetValue(1).ToString();
                    MODELO = reader.GetValue(2).ToString();
                    SERIE = reader.GetValue(3).ToString();
                    DIRECCIONIP = reader.GetValue(4).ToString();
                    DIRECCIONMAC = reader.GetValue(5).ToString();
                    return cadenaDeRetorno = cadenaDeRetorno + "\n\nESPECIFICACIONES TECNICAS\n\nMarca: " + MARCA + "\n" +
                    "Modelo" + MODELO + "\nSerie: " + SERIE + "\nDirección IP: " + DIRECCIONIP + "\n" +
                    "\nDirección M.A.C: " + DIRECCIONMAC;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR CLAVE NO ENCONTRADA");
                return "NO SE ENCONTRO REGISTRO";
            }
        }

        public String categoriaTelefono(String codigoActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from esptelefonos where vp ='" + codigoActivo + "'";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    EXTENSION = reader.GetValue(1).ToString();
                    MARCA = reader.GetValue(2).ToString();
                    MODELO = reader.GetValue(3).ToString();
                    SERIE = reader.GetValue(4).ToString();
                    IP = reader.GetValue(5).ToString();

                    return cadenaDeRetorno = cadenaDeRetorno + "\n\nESPECIFICACIONES TECNICAS\n\nExtensión" + EXTENSION + "\nMarca: " + MARCA + "\n" +
                        "Modelo" + MODELO + "\nSerie: " + SERIE + "\nDirección IP: " + IP;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERROR CLAVE NO ENCONTRADA");
                return "NO SE ENCONTRO REGISTRO";
            }
        }

        public String MARCA, MODELO, SERIE, MEMORIA, ALMACENAMIENTO, SISTEMA, IP,CUENTA,PASSCUENTA, PASSSISTEMA, IMEI, NUMTELEFONO, RAM, ROM, DIRECCIONIP, DIRECCIONMAC, EXTENSION = "";
        public String cadenaDeRetorno = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
