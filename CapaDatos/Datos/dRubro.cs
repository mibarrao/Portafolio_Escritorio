using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using CapaEntidades;
using CapaEntidades.Entidades;
using CapaDatos.Contract;
using CapaDatos.Conexion;
using System.Data;

namespace CapaDatos.Datos
{
    public class dRubro
    {

        public DataTable obtieneRubros ()
        {
            OracleConnection conn = D_Conexion.conectar();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select idrubro, descripcionrubro from rubro order by descripcionrubro";
               
                OracleDataAdapter da = new OracleDataAdapter(command);
                DataTable dt = new DataTable("Rubro");

                da.Fill(dt);

                return dt;
            }

            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }



        }

    }
}
