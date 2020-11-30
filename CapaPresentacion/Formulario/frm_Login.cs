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
        public static string idTipoUsuario;
        

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objetoEUsuario.usuario =  txtUsuario.Text.ToLower().Trim();
            objetoEUsuario.clave = txtClave.Text.Trim();

            dt = objetoNUsuario.N_Usuario(objetoEUsuario);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = dt.Rows[0][0].ToString();
                idTipoUsuario = dt.Rows[0][2].ToString();

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
                txtClave.Clear();
                txtClave.Focus();
            }

        }


        public frm_Login()
        {
            InitializeComponent();
          //  using (OracleConnection cn = new OracleConnection(connOracleString)) ;

        }

        //OracleConnection conexion = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");
        

        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             p_logueo();

          

        }

        private void chxVer_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chxVer.Checked == true)
            {
                txtClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
            }
        }
    }
}
