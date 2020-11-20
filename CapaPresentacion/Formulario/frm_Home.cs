using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formulario
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        /* FUNCIONES */
        void p_BloqueoSegunPerfil() {
            if (frm_Login.idTipoUsuario == "Administrador")
            {
                MantenedorToolStripMenuItem.Visible = true;
                MantenedorToolStripMenuItem.Enabled = true;
                InformesToolStripMenuItem.Visible = true;
                InformesToolStripMenuItem.Enabled = true;

            }
            else
                if (frm_Login.idTipoUsuario == "Cliente")
            {
                MantenedorToolStripMenuItem.Visible = false;
                MantenedorToolStripMenuItem.Enabled = false;
                InformesToolStripMenuItem.Visible = false;
                InformesToolStripMenuItem.Enabled = false;
            }
        }

        void pCalculaDV(int rut)
        {
            if (txtRut.Text == null || txtRut.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar rut");
            }
            else
            {
                int suma = 0;
                int multiplicador = 1;
                //int rut = int.Parse(txtRut.Text);
                while (rut != 0)
                {
                    multiplicador++;
                    if (multiplicador == 8)
                        multiplicador = 2;
                    suma += (rut % 10) * multiplicador;
                    rut = rut / 10;
                }
                suma = 11 - (suma % 11);
                if (suma == 11)
                {
                    //return "0";
                    txtDV.Text = "0";
                }
                else if (suma == 10)
                {
                    txtDV.Text = "K";

                    //return "K";
                }
                else
                {
                    txtDV.Text = suma.ToString();

                    //return suma.ToString();
                }
            }
        }



        /*******************************************************************/
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            //Designa que menu estaran disponibles segun tipo de usuario
            p_BloqueoSegunPerfil();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {

        }

        private void MantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          

        }

        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             grxMantenedorCliente.Visible = false;
        }

        private void InformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grxMantenedorCliente.Visible = false;
        }

        private void ClienteMantenedor_Click(object sender, EventArgs e)
        {
               grxMantenedorCliente.Visible = true;
        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {
            pCalculaDV(int.Parse(txtRut.Text));
        }

       
    }
}
