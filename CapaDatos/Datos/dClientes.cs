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

    }


}
