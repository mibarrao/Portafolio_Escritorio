using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.OracleClient;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data;

namespace CapaDatos.Conexion
{
    public class D_Conexion
    {
        private OracleConnection conn = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");


        public OracleConnection abrirConexion() {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;

        }

        public OracleConnection cerrarConexion(){
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }

    
    }
}
