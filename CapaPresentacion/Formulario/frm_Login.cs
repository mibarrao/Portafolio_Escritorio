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
using System.Net.Configuration;
using CapaDatos.Conexion;
using Oracle.DataAccess.Client;

namespace CapaPresentacion.Formulario
{
    public partial class frm_Login : Form 
    {
        public frm_Login()
        {
            InitializeComponent();
          //  using (OracleConnection cn = new OracleConnection(connOracleString)) ;

        }

        OracleConnection conexion = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");

        //D_Conexion cnx = new D_Conexion();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
                conexion.Open();
            //cnx.conectar();
            OracleCommand cm = new OracleCommand("select usuario, clave from usuario where usuario = :usuario and clave = :clave", conexion);

            cm.Parameters.Add(":usuario", txtUsuario.Text);
            cm.Parameters.Add(":clave", txtClave.Text);

            OracleDataReader lector = cm.ExecuteReader();

            frm_Home home = new frm_Home();
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


                //OracleConnection conexion = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");

                //conexion.Open();

                //if (conexion.State == ConnectionState.Open)
                //    MessageBox.Show("Conectado");
                //else
                //    MessageBox.Show("No se ha podido conectar");
                //conexion.Close();


            

        }

        
    }
}
