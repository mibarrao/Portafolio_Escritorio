using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using CapaDatos;
using CapaEntidades;
using System.Net.Configuration;
using CapaDatos.Conexion;

namespace CapaPresentacion.Formulario
{
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();
          //  using (OracleConnection cn = new OracleConnection(connOracleString)) ;

        }

        OracleConnection conexion = new OracleConnection("Data Source= orcl; Password = hr; USER ID= portafolio");
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand cm = new OracleCommand("select usuario, clave from usuario where usuario = :usuario and clave = :clave", conexion);

            cm.Parameters.AddWithValue(":usuario", txtUsuario.Text);
            cm.Parameters.AddWithValue(":clave", txtClave.Text);

            OracleDataReader lector = cm.ExecuteReader();

            if (lector.Read())
                {
                MessageBox.Show("Te has podido conectar!");
                conexion.Close();
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
