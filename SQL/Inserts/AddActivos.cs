using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemasInv.SQL.Inserts
{
    class AddActivos
    {
        public string agregarAccesorio(String codigoActivo, String marca, String modelo, String serie, String subcategoria)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO espaccesorio (vp, marca, modelo, serie, subcategoria) VALUES (@vpActivo, @marca, @modeLo, @serie, @subcategoria)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = codigoActivo;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@subcategoria", MySqlDbType.VarChar)).Value = subcategoria;
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

        public string agregarConsumibles(String codigoActivo, String nombre, String unidades)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO espconsumible (vp, nombre, unidades) VALUES (@vpActivo, @nombre, @unidades)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = codigoActivo;
                    cmd.Parameters.Add(new MySqlParameter("@nombre", MySqlDbType.VarChar)).Value = nombre;
                    cmd.Parameters.Add(new MySqlParameter("@unidades", MySqlDbType.VarChar)).Value = unidades;
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
        public string agregarTelefono(String codigoActivo, String extension, String marca, String modelo, String serie, String ip, String puerto, String tarjeta, String numeroDirecto)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO esptelefonos (vp, extension, marca, modelo, serie, ip, puerto, tarjeta, numeroDirecto) VALUES (@vpActivo, @extencion, @marca, @modelo, @serie, @ip, @puerto, @tarjeta, @numeroDirecto)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = codigoActivo;
                    cmd.Parameters.Add(new MySqlParameter("@extencion", MySqlDbType.VarChar)).Value = extension;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@ip", MySqlDbType.VarChar)).Value = ip;
                    cmd.Parameters.Add(new MySqlParameter("@puerto", MySqlDbType.VarChar)).Value = puerto;
                    cmd.Parameters.Add(new MySqlParameter("@tarjeta", MySqlDbType.VarChar)).Value = tarjeta;
                    cmd.Parameters.Add(new MySqlParameter("@numeroDirecto", MySqlDbType.VarChar)).Value = numeroDirecto;
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

        public string agregarImpresora(String codigoActivo, String marca, String modelo, String serie, String direccionIP, String direccionMac)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO espimpresoras (vp, marca, modelo, serie, direccionIP, direccionMac) VALUES (@vpActivo, @marca, @modeLo, @serie, @direccionIP, @direccionMAC)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = codigoActivo;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@direccionIP", MySqlDbType.VarChar)).Value = direccionIP;
                    cmd.Parameters.Add(new MySqlParameter("@direccionMAC", MySqlDbType.VarChar)).Value = direccionMac;

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
                System.Windows.Forms.MessageBox.Show(ex.Message+ codigoActivo+marca+modelo+serie+direccionIP+direccionMac);
            }
            return "SE INSERTO EL REGISTRO";
        }
        public string agregarPC(String vp, String marca, String modelo, String serie, double memoria, int almacenamiento, String sistema, String procesador, String direccionIP, String usuarioAdministrador, String passAdministrador, String ultimoRespaldo, String ultimoMantenimiento)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO esppc (vp, marca, modelo, serie, memoria, almacenamiento, sistema, procesador, direccionIP, usuarioAdministrador, passAdministrador, ultimoRespaldo, ultimoMantenimiento) VALUES (@vpActivo, @marca, @modeLo, @serie, @memoria, @almacenamiento, @sistema, @procesador, @direccionIP, @usuarioAdministrador, @passAdministrador, @ultimoRespaldo, @ultimoMantenimiento)";
                    System.Windows.Forms.Clipboard.SetText(insertar);
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = vp;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@memoria", MySqlDbType.Double)).Value = memoria;
                    cmd.Parameters.Add(new MySqlParameter("@almacenamiento", MySqlDbType.Int32)).Value = almacenamiento;
                    cmd.Parameters.Add(new MySqlParameter("@sistema", MySqlDbType.VarChar)).Value = sistema;
                    cmd.Parameters.Add(new MySqlParameter("@procesador", MySqlDbType.VarChar)).Value = procesador;
                    cmd.Parameters.Add(new MySqlParameter("@direccionIP", MySqlDbType.VarChar)).Value = direccionIP;
                    cmd.Parameters.Add(new MySqlParameter("@usuarioAdministrador", MySqlDbType.VarChar)).Value = usuarioAdministrador;
                    cmd.Parameters.Add(new MySqlParameter("@passAdministrador", MySqlDbType.VarChar)).Value = passAdministrador;
                    cmd.Parameters.Add(new MySqlParameter("@ultimoRespaldo", MySqlDbType.Date)).Value = ultimoRespaldo;
                    cmd.Parameters.Add(new MySqlParameter("@ultimoMantenimiento", MySqlDbType.Date)).Value = ultimoMantenimiento;

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

        public string agregarLaptop(String vp, String marca, String modelo, String serie, double memoria, int almacenamiento, String sistema, String procesador, String direccionIP, String usuarioAdministrador, String passAdministrador, String ultimoRespaldo, String ultimoMantenimiento)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO esplaptop (vp, marca, modelo, serie, memoria, almacenamiento, sistema, procesador, direccionIP, usuarioAdministrador, passAdministrador, ultimoRespaldo, ultimoMantenimiento) VALUES (@vpActivo, @marca, @modeLo, @serie, @memoria, @almacenamiento, @sistema, @procesador, @direccionIP, @usuarioAdministrador, @passAdministrador, @ultimoRespaldo, @ultimoMantenimiento)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = vp;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@sistema", MySqlDbType.VarChar)).Value = sistema;
                    cmd.Parameters.Add(new MySqlParameter("@memoria", MySqlDbType.VarChar)).Value = memoria;
                    cmd.Parameters.Add(new MySqlParameter("@almacenamiento", MySqlDbType.VarChar)).Value = almacenamiento;
                    cmd.Parameters.Add(new MySqlParameter("@procesador", MySqlDbType.VarChar)).Value = procesador;
                    cmd.Parameters.Add(new MySqlParameter("@direccionIP", MySqlDbType.VarChar)).Value = direccionIP;
                    cmd.Parameters.Add(new MySqlParameter("@usuarioAdministrador", MySqlDbType.VarChar)).Value = usuarioAdministrador;
                    cmd.Parameters.Add(new MySqlParameter("@passAdministrador", MySqlDbType.VarChar)).Value = passAdministrador;
                    cmd.Parameters.Add(new MySqlParameter("@ultimoRespaldo", MySqlDbType.Date)).Value = ultimoRespaldo;
                    cmd.Parameters.Add(new MySqlParameter("@ultimoMantenimiento", MySqlDbType.Date)).Value = ultimoMantenimiento;
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

        public string agregarMovil(String codigoActivo, String marca, String modelo, String serie, String ip, String cuenta, String passCuenta, String passSistema, String imei, String numTelefono, String ram, String rom, String so, String camara )
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO espMovil (vp, marca, modelo, serie, ip, cuenta, passCuenta, passSistema, imei, numTelefono, ram, rom, so, camara) VALUES (@vpActivo, @marca, @modelo, @serie, @ip, @cuenta, @passCuenta, @passSistema, @imei, @numTelefono, @ram, @rom, @so, @camara)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@vpActivo", MySqlDbType.VarChar)).Value = codigoActivo;
                    cmd.Parameters.Add(new MySqlParameter("@marca", MySqlDbType.VarChar)).Value = marca;
                    cmd.Parameters.Add(new MySqlParameter("@modelo", MySqlDbType.VarChar)).Value = modelo;
                    cmd.Parameters.Add(new MySqlParameter("@serie", MySqlDbType.VarChar)).Value = serie;
                    cmd.Parameters.Add(new MySqlParameter("@ip", MySqlDbType.VarChar)).Value = ip;
                    cmd.Parameters.Add(new MySqlParameter("@cuenta", MySqlDbType.VarChar)).Value = cuenta;
                    cmd.Parameters.Add(new MySqlParameter("@passCuenta", MySqlDbType.VarChar)).Value = passCuenta;
                    cmd.Parameters.Add(new MySqlParameter("@passSistema", MySqlDbType.VarChar)).Value = passSistema;
                    cmd.Parameters.Add(new MySqlParameter("@imei", MySqlDbType.VarChar)).Value = imei;
                    cmd.Parameters.Add(new MySqlParameter("@numTelefono", MySqlDbType.VarChar)).Value = numTelefono;
                    cmd.Parameters.Add(new MySqlParameter("@ram", MySqlDbType.VarChar)).Value = ram;
                    cmd.Parameters.Add(new MySqlParameter("@rom", MySqlDbType.VarChar)).Value = rom;
                    cmd.Parameters.Add(new MySqlParameter("@so", MySqlDbType.VarChar)).Value = so;
                    cmd.Parameters.Add(new MySqlParameter("@camara", MySqlDbType.VarChar)).Value = camara;
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
                System.Windows.Forms.MessageBox.Show(ex.Message+" al insertar movil");
            }
            return "SE INSERTO EL REGISTRO";
        }
        public string agregaraActivo(String vpActivo, String fechaDeCompra, String tiempoDeGarantia, String factura, String tipo, String comentario)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO activos (vpActivo, fechaCompra, tiempoGarantia, factura, tipo, comentario) VALUES (@activo, @fechaDeCompra, @tiempoDeGarantia, @factura, @tipo, @comentario)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = vpActivo;
                    cmd.Parameters.Add(new MySqlParameter("@fechaDeCompra", MySqlDbType.DateTime)).Value = fechaDeCompra;
                    cmd.Parameters.Add(new MySqlParameter("@tiempoDeGarantia", MySqlDbType.VarChar)).Value = tiempoDeGarantia;
                    cmd.Parameters.Add(new MySqlParameter("@factura", MySqlDbType.VarChar)).Value = factura;
                    cmd.Parameters.Add(new MySqlParameter("@tipo", MySqlDbType.VarChar)).Value = tipo;
                    cmd.Parameters.Add(new MySqlParameter("@comentario", MySqlDbType.VarChar)).Value = comentario;

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

        public string agregarStock(String vpActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "INSERT INTO estado (vp, estado) VALUES (@activo, @estado)";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = vpActivo;
                    cmd.Parameters.Add(new MySqlParameter("@estado", MySqlDbType.VarChar)).Value = "STOCK";
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
                System.Windows.Forms.MessageBox.Show("ERROR "+ex);
            }
            return "SE INSERTO EL REGISTRO";
        }
        public string activoAsignado(String vpActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "UPDATE estado SET estado = 'ASIGNADO' WHERE vp = @activo ";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = vpActivo;
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
                System.Windows.Forms.MessageBox.Show("ERROR " + ex);
            }
            return "SE INSERTO EL REGISTRO";
        }
        public string activoStock(String vpActivo)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(sql))
                {
                    cnn.Open();
                    String insertar = "UPDATE estado SET estado = 'STOCK' WHERE estado.vp = @activo";
                    MySqlCommand cmd = new MySqlCommand(insertar, cnn);
                    cmd.Parameters.Add(new MySqlParameter("@activo", MySqlDbType.VarChar)).Value = vpActivo;
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
                System.Windows.Forms.MessageBox.Show("ERROR " + ex);
            }
            return "SE INSERTO EL REGISTRO";
        }
        public String cadenaDeRetorno = "";
        public String clasificacionActivo = "";
        public string sql = Properties.Settings.Default.cadenaConexion;
    }
}
