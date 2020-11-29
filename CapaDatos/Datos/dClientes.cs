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
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace CapaDatos.Datos
{
    public class dClientes
    {

        public void creaCliente(eCliente cl)
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = new OracleCommand("SP_INSERTACLIENTE", cnn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("nom", OracleDbType.Varchar2).Value = cl.nombre;
                command.Parameters.Add("paterno", OracleDbType.Varchar2).Value = cl.apPaterno;
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

        public DataTable obtieneMaxCliente()
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = cnn.CreateCommand();
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email from cliente where idcliente = (select max(idcliente) from cliente)";

                OracleDataAdapter da = new OracleDataAdapter(command);
                DataTable dt = new DataTable("Cliente");

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

        public List<eCliente> getListaCliente()
        {
            OracleConnection conn = D_Conexion.conectar();
            List<eCliente> listaCliente = new List<eCliente>();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email  from cliente cl inner join comuna cm on cm.idcomuna = cl.codcomuna inner join ciudad cd on cd.idciudad = cm.idciudad inner join region rg on rg.idregion = cd.idregion";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    eCliente clienteGrid = new eCliente();
                    clienteGrid.idcliente = int.Parse(reader["IDCLIENTE"].ToString());
                    clienteGrid.nombre = reader["NOMBRE"].ToString();
                    //usuarioGrid.estado = short.Parse(reader["ISACTIVO"].ToString()) == 1 ? "Activo" : "Inactivo";
                    clienteGrid.apPaterno = reader["APPATERNO"].ToString().ToUpper();
                    clienteGrid.apMaterno = reader["APMATERNO"].ToString().ToUpper();
                    clienteGrid.rut = int.Parse(reader["RUT"].ToString());
                    clienteGrid.dvVerificador = reader["dverificador"].ToString();
                    clienteGrid.idRubro = int.Parse(reader["IDRUBRO"].ToString());
                    clienteGrid.direccion = reader["DIRECCION"].ToString().ToUpper();
                    clienteGrid.codComuna = int.Parse(reader["CODCOMUNA"].ToString());
                    clienteGrid.codCiudad = int.Parse(reader["CODCIUDAD"].ToString());
                    clienteGrid.codRegion = int.Parse(reader["CODREGION"].ToString());
                    clienteGrid.telefono = int.Parse(reader["TELEFONO"].ToString());
                    clienteGrid.email = reader["EMAIL"].ToString();

                    listaCliente.Add(clienteGrid);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return listaCliente;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void editaCliente(eCliente cl)
        {
            OracleConnection conn = D_Conexion.conectar();
            string result = string.Empty;

            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SP_UPDATE_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_idCliente", OracleDbType.Int32).Value = cl.idcliente;
                cmd.Parameters.Add("p_nombre", OracleDbType.Int32).Value = cl.nombre;
                cmd.Parameters.Add("p_apPaterno", OracleDbType.Varchar2).Value = cl.apPaterno;
                cmd.Parameters.Add("p_apMaterno", OracleDbType.Varchar2).Value = cl.apMaterno;
                cmd.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = cl.rut;
                cmd.Parameters.Add("p_dvVerificador", OracleDbType.Varchar2).Value = cl.dvVerificador;
                cmd.Parameters.Add("p_idrubro", OracleDbType.Varchar2).Value = cl.idRubro;
                cmd.Parameters.Add("p_direccion", OracleDbType.Varchar2).Value = cl.direccion;
                cmd.Parameters.Add("p_codcomuna", OracleDbType.Varchar2).Value = cl.codComuna;
                cmd.Parameters.Add("p_codciudad", OracleDbType.Int16).Value = cl.codCiudad;
                cmd.Parameters.Add("p_codregion", OracleDbType.Int32).Value = cl.codRegion;
                cmd.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = cl.telefono;
                cmd.Parameters.Add("P_email", OracleDbType.Varchar2).Value = cl.email;

                cmd.ExecuteNonQuery();
                result = Convert.ToString(cmd.Parameters["P_RESULT"].Value);
                cmd.Dispose();

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

        public void eliminaCliente(Int32 idCliente)
        {
            OracleConnection cnn = D_Conexion.conectar();
            try
            {
                OracleCommand command = cnn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_DELETE_CLIENTE";
                command.Parameters.Add("IDCLIENTE", OracleDbType.Int16).Value = idCliente;
                OracleDataReader dr = command.ExecuteReader();
                dr.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                cnn.Close();
                cnn.Dispose();
            }
        }


        public List<eCliente> getListaClientePorRutorName(int rut, string nombre) 
        {
            OracleConnection conn = D_Conexion.conectar();
            List<eCliente> listaCliente = new List<eCliente>();
            try
            {
                OracleCommand command = conn.CreateCommand();

                StringBuilder queryCliente = new StringBuilder();

                //queryCliente.Append("select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email  from cliente cl inner join comuna cm on cm.idcomuna = cl.codcomuna inner join ciudad cd on cd.idciudad = cm.idciudad inner join region rg on rg.idregion = cd.idregion where (cl.rut = :rut  or UPPER(cl.nombre|| ' '|| cl.appaterno ||' ' ||cl.apmaterno) like ");
                //queryCliente.Append(nombre);
                //queryCliente.Append(" )");
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email  from cliente cl inner join comuna cm on cm.idcomuna = cl.codcomuna inner join ciudad cd on cd.idciudad = cm.idciudad inner join region rg on rg.idregion = cd.idregion where (cl.rut = :rut  or UPPER(cl.nombre|| ' '|| cl.appaterno ||' ' ||cl.apmaterno) = :nombre )  ";
                //command.CommandText = queryCliente.ToString();


                command.Parameters.Add(":rut", OracleDbType.Varchar2).Value = rut;
                command.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre.ToUpper();

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    eCliente clienteGrid = new eCliente();
                    clienteGrid.idcliente = int.Parse(reader["IDCLIENTE"].ToString());
                    clienteGrid.nombre = reader["NOMBRE"].ToString();
                    //usuarioGrid.estado = short.Parse(reader["ISACTIVO"].ToString()) == 1 ? "Activo" : "Inactivo";
                    clienteGrid.apPaterno = reader["APPATERNO"].ToString().ToUpper();
                    clienteGrid.apMaterno = reader["APMATERNO"].ToString().ToUpper();
                    clienteGrid.rut = int.Parse(reader["RUT"].ToString());
                    clienteGrid.dvVerificador = reader["dverificador"].ToString();
                    clienteGrid.idRubro = int.Parse(reader["IDRUBRO"].ToString());
                    clienteGrid.direccion = reader["DIRECCION"].ToString().ToUpper();
                    clienteGrid.codComuna = int.Parse(reader["CODCOMUNA"].ToString());
                    clienteGrid.codCiudad = int.Parse(reader["CODCIUDAD"].ToString());
                    clienteGrid.codRegion = int.Parse(reader["CODREGION"].ToString());
                    clienteGrid.telefono = int.Parse(reader["TELEFONO"].ToString());
                    clienteGrid.email = reader["EMAIL"].ToString();

                    listaCliente.Add(clienteGrid);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return listaCliente;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void creaPdf()
        {
            DateTime fecha = DateTime.Now;
            string fechaActual = fecha.ToString("dd-MM-yyyy");
            //string ruta = 'C:\Users\M.ibarraO\Documents\DUOC\Aplicaciones\GeneraPDF\Listado_ClienteActual_' + fechaActual+'.pdf';

            PdfWriter pdfwriter = new PdfWriter("Listado_ClienteActual_" + fechaActual + ".pdf");
            //Crear documento
            PdfDocument pdf = new PdfDocument(pdfwriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "idcliente", "nombre", "paterno", "materno", "rut", "dvs", "rubro", "direccion", "codcomuna", "ciudad", "region", "telefono", "mail" };
            float[] tamanios = { 5, 20, 20, 20, 10, 1, 10, 30, 15, 15, 15, 9, 30 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            /*CONSULTA SQL*/

            OracleConnection conn = D_Conexion.conectar();
            List<eCliente> listaCliente = new List<eCliente>();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select idcliente,nombre,appaterno,apmaterno,rut,dverificador,descripcionrubro,direccion,nombrecomuna,NOMBRECIUDAD, NOMBREREGION,telefono,email  from cliente cl inner join comuna cm on cm.idcomuna = cl.codcomuna inner join ciudad cd on cd.idciudad = cm.idciudad inner join region rg on rg.idregion = cd.idregion inner join rubro rb on rb.idrubro = cl.idrubro";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    tabla.AddCell(new Cell().Add(new Paragraph(reader["IDCLIENTE"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["APPATERNO"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["APMATERNO"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["RUT"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["DVERIFICADOR"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcionrubro"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBRECOMUNA"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBRECIUDAD"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["NOMBREREGION"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["TELEFONO"].ToString())));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["EMAIL"].ToString())));

                   

                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                //Agrega en la tablapdf
                documento.Add(tabla);
                documento.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }



        }


    }


}
