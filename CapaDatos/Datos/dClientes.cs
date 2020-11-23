using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Conexion;
using CapaDatos.Contract;
using CapaEntidades.Entidades;
using Oracle.DataAccess.Client;
using System.Data;

namespace CapaDatos.Datos
{
   public class dClientes 
    {
        //    public string actualizar(eCliente dto)
        //    {
        //        string resultado = string.Empty;
        //        try {
        //            conectar();
        //            using (OracleCommand command = new OracleCommand("SP_UPDATE_CLIENTE",conectar()))
        //        }
        //        catch(Exception ex)
        //    }

        public void creaCliente(eCliente cl)
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = new OracleCommand("SP_INSERTACLIENTE", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("nom", OracleDbType.Varchar2).Value = cl.nombre ;
                command.Parameters.Add("paterno",OracleDbType.Varchar2).Value = cl.apPaterno;
                command.Parameters.Add("materno", OracleDbType.Varchar2).Value = cl.apMaterno;
                command.Parameters.Add("rut", OracleDbType.Int32).Value = cl.rut;
                command.Parameters.Add("dverificador", OracleDbType.Varchar2).Value = cl.dvVerificador;
                command.Parameters.Add("idrubro", OracleDbType.Int32).Value = cl.idRubro;
                command.Parameters.Add("direccion", OracleDbType.Varchar2).Value = cl.direccion;
                command.Parameters.Add("codcomuna", OracleDbType.Int32).Value = cl.codComuna;
                command.Parameters.Add("codciudad", OracleDbType.Int32).Value = cl.codCiudad;
                command.Parameters.Add("codregion", OracleDbType.Int32).Value = cl.codRegion;
                command.Parameters.Add("telefono", OracleDbType.Int32).Value = cl.telefono;
                command.Parameters.Add("mail", OracleDbType.Varchar2).Value = cl.email;
                command.ExecuteNonQuery();
                command.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                cnn.Close();
                cnn.Dispose();   
            }
        }

        public DataTable obtieneMaxCliente()
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = cnn.CreateCommand();
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email from cliente where idcliente = (select max(idcliente) from cliente)";

                OracleDataAdapter da = new OracleDataAdapter(command);
                DataTable dt = new DataTable("Cliente");

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error en obtieneTipoUsuario" + ex.Message);
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public List<eCliente> getListaCliente()
        {
            OracleConnection conn = D_Conexion.conectar();
            List<eCliente> listaCliente = new List<eCliente>();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email from cliente";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                { 
                    eCliente clienteGrid = new eCliente();
                    clienteGrid.idcliente = int.Parse(reader["IDCLIENTE"].ToString());
                    clienteGrid.nombre = reader["NOMBRE"].ToString();
                    //usuarioGrid.estado = short.Parse(reader["ISACTIVO"].ToString()) == 1 ? "Activo" : "Inactivo";
                    clienteGrid.apPaterno = reader["APPATERNO"].ToString().ToUpper();
                    clienteGrid.apMaterno = reader["APMATERNO"].ToString().ToUpper();
                    clienteGrid.rut = int.Parse(reader["RUT"].ToString());
                    clienteGrid.dvVerificador = reader["DVVERIFICADOR"].ToString();
                    clienteGrid.idRubro = int.Parse(reader["IDRUBRO"].ToString());
                    clienteGrid.direccion = reader["DIRECCION"].ToString().ToUpper();
                    clienteGrid.codComuna = int.Parse(reader["CODCOMUNA"].ToString());
                    clienteGrid.codCiudad = int.Parse(reader["CODCIUDAD"].ToString());
                    listaCliente.Add(clienteGrid);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return listaCliente;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


    }


}
