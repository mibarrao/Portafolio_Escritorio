using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Conexion;
using CapaEntidades;
using System.Configuration;
using System.Data.Sql;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using CapaEntidades;
using CapaEntidades.Entidades;

namespace CapaDatos.Datos
{
   public class D_Usuarios : D_Conexion
    {
        OracleDataReader leer;

        DataTable tabla = new DataTable();
        OracleCommand comando = new OracleCommand();

        public DataTable Mostrar() {
            
            string resultado = string.Empty;

            try
            {
                conectar();
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                desconectar();
                return tabla;

            }

            catch (Exception ex) {
                Console.WriteLine("No se ha podido ejecutar la consulta! ", ex);
                 return tabla;
            }
        }
        
        public DataTable Login (eUsuario obje)

        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("p_usuario",obje.usuario);
            comando.Parameters.Add("p_clave",obje.clave);

            OracleDataAdapter da = new OracleDataAdapter(comando);

            da.Fill(tabla);

            return tabla;
        }


    }
}
