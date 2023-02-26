using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL
{
    class ConsultaGeneralVP
    {
        //METODO PARA CONSULTAR EL CODIGO DE ACTIVO
        public string consultarActivo(String codigoActivo)
        {
            try {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String consulta = "select * from activos where vpActivo ='" + codigoActivo + "' LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(consulta, cnn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    VPACTIVO = reader.GetValue(0).ToString();
                    FECHADECOMPRA = reader.GetValue(1).ToString();
                    TIEMPOGARANTIA = reader.GetValue(2).ToString();
                    FACTURA = reader.GetValue(3).ToString();
                    TIPO = reader.GetValue(4).ToString();
                    COMENTARIO = reader.GetValue(5).ToString();
                    clasificacionActivo = TIPO;
                    return cadenaDeRetorno = cadenaDeRetorno + "DATOS BASICOS DEL ACTIVO\n\nCodigo activo: " + VPACTIVO + "\n" +
            "Fecha de compra" + FECHADECOMPRA + "\nTiempo de garantia: " + TIEMPOGARANTIA + "\nFactura: " + FACTURA +
            "\nTipo: " + TIPO + "\nComentario: " + COMENTARIO;
                }
            }  
            catch (Exception)
            {
                return "";
            }
        }
        public String VPACTIVO, FECHADECOMPRA, TIEMPOGARANTIA, FACTURA, TIPO, COMENTARIO = "";
        public String cadenaDeRetorno = "";
        public String clasificacionActivo = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
    
}
