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


        public List<eRubro> Listar()
        {
            List<eRubro> list = new List<eRubro>();
            eRubro rubro = null;
            OracleConnection conn = D_Conexion.conectar();

            try {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SP_SELECT_RUBRO";

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new OracleParameter("P_CURSOR", OracleDbType.RefCursor)).Direction = System.Data.ParameterDirection.Output;

                using (OracleDataReader dr = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        rubro = new eRubro();
                        rubro.idRubro = Convert.ToInt32(dr["IDRUBRO"]);
                        rubro.descripcionRubro = dr["IDRUBRO"].ToString();
                        list.Add(rubro);
                    }
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return list;
        }

        public DataTable obtieneRubrosporId(int idRubro)
        {
            OracleConnection conn = D_Conexion.conectar();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select idrubro, descripcionrubro from rubro where idrubro = :idRubro order by descripcionrubro";
                command.Parameters.Add(":idRubro", OracleDbType.Varchar2).Value = idRubro;

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
