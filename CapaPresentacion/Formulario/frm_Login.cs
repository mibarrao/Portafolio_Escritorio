using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OracleClient;
using Oracle.DataAccess;
using Oracle.ManagedDataAccess;
//using System.Data;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System.Net.Configuration;
using CapaDatos.Conexion;
using Oracle.DataAccess.Client;
using CapaEntidades.Entidades;
using CapaDatos.Datos;

namespace CapaPresentacion.Formulario
{
    public partial class frm_Login : Form 
    {
        eUsuario objetoEUsuario = new eUsuario();
        nUsuario objetoNUsuario = new nUsuario();
        D_Conexion cnx = new D_Conexion();
        frm_Home home = new frm_Home();

        public static string usuario;
        public static string clave;

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objetoEUsuario.usuario = txtUsuario.Text;
            objetoEUsuario.clave = txtClave.Text;

            dt = objetoNUsuario.N_Usuario(objetoEUsuario);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = dt.Rows[0][0].ToString();


                this.Hide();
                home.Show();

                //frm_Login login = new frm_Login();
                //login.ShowDialog();
                //if (login.DialogResult == DialogResult.OK)
                //    Application.Run(new frm_Home());

                //txtUsuario.Clear();
                //txtClave.Clear();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecto ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public frm_Login()
        {
            InitializeComponent();
          //  using (OracleConnection cn = new OracleConnection(connOracleString)) ;

        }

        OracleConnection conexion = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");

        //D_Conexion cnx = new D_Conexion();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             p_logueo();

            /*
            try {
                //VALIDACION QUE CAMPO TXTUSUARIO TRAIGA DATOS
                if (txtUsuario.Text == null || txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error : El login de usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Focus();
                }
                //VALIDACION QUE CAMPO TXTCLAVE TRAIGA DATOS
                else if (txtClave.Text == null || txtClave.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error : La clave de usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtClave.Focus();
                }
                else
                {
                    OracleConnection conn = D_Conexion.conectar();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error procesando Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      

        conexion.Open();
            //cnx.conectar();
            OracleCommand cm = new OracleCommand("select usuario, clave from usuario where usuario = :usuario and clave = :clave", conexion);

            cm.Parameters.Add(":usuario", txtUsuario.Text);
            cm.Parameters.Add(":clave", txtClave.Text);

            OracleDataReader lector = cm.ExecuteReader();

            if (lector.Read())
            {
                this.Hide();
                conexion.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("No se ha podido ingresar");
            }


            */


        }


    }
}
