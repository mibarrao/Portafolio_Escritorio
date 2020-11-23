using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Conexion;
using Oracle.DataAccess.Client;
using CapaEntidades.Entidades;
using CapaDatos.Datos;


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

        void pValidaNumeros(KeyPressEventArgs e)
        {
            try
            {
                //Si es digito lo permite escribir
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Si es tecla delete lo permite
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void pValidaLetras(KeyPressEventArgs e)
        {
            try
            {
                //Si es digito lo permite escribir
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Si es tecla delete lo permite
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
            pnlIngresar.Visible = true;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;
            

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

            /*CARGA CB RUBROS*/
            dRubro rubrodao = new dRubro();
            DataTable drubro = rubrodao.obtieneRubros();

            this.cbRubro.DataSource = drubro;
            this.cbRubro.DisplayMember = "descripcionrubro";
            this.cbRubro.ValueMember = "idrubro";


            /*CARGA CB COMUNA*/
            dComuna comunadao = new dComuna();
            DataTable dcomuna = comunadao.obtieneComunacb();          

            this.cbComuna.DataSource = dcomuna;
            this.cbComuna.DisplayMember = "nombrecomuna";
            this.cbComuna.ValueMember = "idcomuna";

            /*CARGA CB CIUDAD*/

            this.cbCiudad.DataSource = dcomuna;
            this.cbCiudad.DisplayMember = "nombreciudad";
            this.cbCiudad.ValueMember = "idciudad";
            
            /*CARGA CB REGION*/

            this.cbRegion.DataSource = dcomuna;
            this.cbRegion.DisplayMember = "nombreregion";
            this.cbRegion.ValueMember = "idregion";


        }

        private void txtDV_TextChanged(object sender, EventArgs e)
        {
 
            pCalculaDV(int.Parse(txtRut.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                /*CREAR USUARIO*/
                eUsuario usu = new eUsuario();
                D_Usuarios dusuario = new D_Usuarios();

                usu.idTipoUsuario = '1';
              //  usu.usuario = Left(txtNombreCliente.Text.Trim(), 1);


                /*CREAR CLIENTE*/
                eCliente cl = new eCliente();
                dClientes dcliente = new dClientes();
                pCalculaDV(int.Parse(txtRut.Text));


                cl.nombre = txtNombreCliente.Text.Trim();
                cl.apPaterno = txtPaternoCliente.Text.Trim();
                cl.apMaterno = txtMaternoCliente.Text.Trim();
                cl.rut = int.Parse(txtRut.Text.Trim());
                cl.dvVerificador = txtDV.Text.Trim();
                cl.idRubro = int.Parse(cbRubro.SelectedValue.ToString());
                cl.direccion = txtDireccionCliente.Text.Trim();
                cl.codComuna = int.Parse(cbComuna.SelectedValue.ToString());
                cl.codCiudad = int.Parse(cbCiudad.SelectedValue.ToString());
                cl.codRegion = int.Parse(cbRegion.SelectedValue.ToString());
                cl.telefono = int.Parse(txtTelefonoCliente.Text.Trim());
                cl.email = txtMailCliente.Text.Trim();


                dcliente.creaCliente(cl);

                MessageBox.Show("El cliente se creado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Dispose();
        }
            catch (Exception ex)
            { 
                MessageBox.Show("Error: Ha ocurrido un error al crear el usuario. "+ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




}

        private void cbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            pValidaNumeros(e);
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            pValidaNumeros(e);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            pValidaLetras(e);
        }

        private void txtPaternoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            pValidaLetras(e);

        }

        private void txtMaternoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            pValidaLetras(e);

        }
    }
}
