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
    public class dTipoUsuario
    {
        public DataTable obtieneTipoUsuario()
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = cnn.CreateCommand();
                command.CommandText = "select idtipousuario,descripciontipousuario from tipousuario";
                
                OracleDataAdapter da = new OracleDataAdapter(command);
                DataTable dt = new DataTable("TipoUusario");

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
    }
}
