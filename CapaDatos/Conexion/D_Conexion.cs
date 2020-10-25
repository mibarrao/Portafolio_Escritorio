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

namespace CapaDatos.Conexion
{
    public class D_Conexion
    {

        OracleConnection conn = null;

        public D_Conexion() { }

        public void conectar() { 
            String connOracleString = ConfigurationManager.ConnectionStrings["ConnectionPortafolio"].ConnectionString;
            conn = new OracleConnection(connOracleString);
            try
            {
                conn.Open();
            }
            catch (Exception exp) {
                Console.WriteLine("La conexión no ha podido realizarse: ", exp);
            }

        }

        public void desconectar() {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception exp) { 
                Console.WriteLine("No se ha podido realizar la desconexión: ",exp);
            }
        }


    }
  

}
