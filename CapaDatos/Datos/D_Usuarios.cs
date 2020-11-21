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
using CapaDatos.Contract;

namespace CapaDatos.Datos  
{
    public class D_Usuarios
    {
        OracleConnection conn = D_Conexion.conectar();

        public DataTable D_usuario(eUsuario obje) {

            OracleCommand command = conn.CreateCommand();
            command.CommandText = "select usuario,clave,descripciontipousuario from usuario usu inner join TIPOUSUARIO tp on tp.idtipousuario = usu.idtipousuario where usuario = :usuario and clave = :clave";
            command.Parameters.Add(":usuario", OracleDbType.NVarchar2).Value = obje.usuario;
            command.Parameters.Add(":clave", OracleDbType.NVarchar2).Value = obje.clave;
            //OracleDataReader dr = command.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

            conn.Close();
            conn.Dispose();

        }



        public eUsuario GetUsuario(string usuario, string clave)
        {
            

            try
            {
                //Obtiene consulta para que devuelva valor
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select usuario, clave from usuario where usuario = :usuario and clave = :clave";
                command.Parameters.Add (":usuario",OracleDbType.NVarchar2).Value  = usuario;
                command.Parameters.Add(":clave", OracleDbType.NVarchar2).Value = clave;
                OracleDataReader dr = command.ExecuteReader();

                eUsuario usu = null;

                while (dr.Read())
                {
                    usu = new eUsuario();
                    usu.idUsuario = int.Parse(dr["IDUSUARIO"].ToString());
                    usu.idTipoUsuario = int.Parse(dr["IDTIPOUSUARIO"].ToString());
                    usu.usuario = (string)dr["USUARIO"];
                    usu.clave = (string)dr["CLAVE"];
                    usu.activo = bool.Parse(dr["ACTIVO"].ToString());
                    usu.idcliente = int.Parse(dr["IDCLIENTE"].ToString());
                    usu.idprofesional = int.Parse(dr["IDPROFESIONAL"].ToString());
                }
                dr.Close();
                command.Dispose();
                return usu;

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
