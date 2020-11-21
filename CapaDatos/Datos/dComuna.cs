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
   public class dComuna
    {
        public DataTable obtieneComunacb()
        { 
         OracleConnection conn = D_Conexion.conectar();

            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select cmm.IDCOMUNA,cmm.NOMBRECOMUNA, cmm.IDCIUDAD from comuna cmm inner join ciudad cd on cd.idciudad = cmm.idciudad inner join region rg on rg.idregion = cd.idregion order by rg.idregion ";

                OracleDataAdapter da = new OracleDataAdapter(command);
                DataTable dt = new DataTable("Comunas");

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
