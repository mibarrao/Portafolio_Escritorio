using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
//using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Security.Policy;
using CapaEntidades.Entidades;
using System.Runtime.InteropServices;

namespace CapaDatos.Conexion
{
    public class D_Conexion
    {

        private OracleConnection conn = null;
        private OracleCommand cmd = new OracleCommand();

        

        //protected string strOracle = string.Empty;
        public D_Conexion()
        {
            
            //  strOracle = ConfigurationManager.ConnectionStrings["ConnectionPortafolio"].ConnectionString;
        }

        public static OracleConnection conectar()
        {
            OracleConnection connOracleString = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionPortafolio"].ConnectionString);
            connOracleString.Open();
            return connOracleString;

        }

        //OracleConnection connOracleString = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");


       /* public DataTable Login(eUsuario obje)

        {
            connOracleString.Open();
            OracleCommand comando  = new OracleCommand ("SP_LOGIN", connOracleString);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            
            comando.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value= obje.usuario;
            comando.Parameters.Add("p_clave", OracleDbType.Varchar2).Value = obje.clave;
            comando.Parameters.Add("p_cursor", OracleDbType.Varchar2).Direction = System.Data.ParameterDirection.Output;

            OracleDataAdapter dt = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();

            using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    
                }
            }

            comando.ExecuteNonQuery();


          

            dt.Fill(tabla);

            return tabla;
        }*/


 

        private string CadenaConexion(short IdBase)
        {
            string stringConexion = "";
            switch (IdBase)
            {
                case 1: // Portafolio
                    {
                        stringConexion = ConfigurationManager.ConnectionStrings["ConnectionPortafolio"].ConnectionString;
                        break;
                    }
               
            }
            return stringConexion;
        }

        public async Task Ejecutar(string query, short tipoConexion, OracleParameter[] parameters = null, int timmer = 0)
        {
            using (conn = new OracleConnection(CadenaConexion(tipoConexion)))
            {
                conn.Open();
                using (var cmd = new OracleCommand())
                {
                    if (timmer != 0) { cmd.CommandTimeout = timmer; }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = query;
                    if (parameters != null) { cmd.Parameters.AddRange(parameters); }
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<DataTable> ObtieneDato(string sql, short tipoConexion, OracleParameter[] parameters = null, int timmer = 0)
        {
            DataTable Tabla = new DataTable();

            using (conn = new OracleConnection(CadenaConexion(tipoConexion)))
            {
                conn.Open();
                using (var cmd = new OracleCommand())
                {
                    if (timmer != 0) { cmd.CommandTimeout = timmer; }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sql;
                    if (parameters != null) { cmd.Parameters.AddRange(parameters); }

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            return Tabla;
        }

        /*public void desconectar() {
            try
            {
                if (conectar().State == ConnectionState.Open)
                {
                    this.Close();
                }
            }
            catch (Exception exp) { 
                Console.WriteLine("No se ha podido realizar la desconexión: ",exp);
            }
        }
        */

    }
  

}
