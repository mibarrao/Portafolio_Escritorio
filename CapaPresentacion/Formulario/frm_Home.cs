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
        private BindingList<eCliente> listaCl;

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


        void pEnviaCorreo(string para, string usuario, string clave)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(para);
            mmsg.Subject = "CREACION USUARIO PIMA SOLUCIONES";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = "Estimado/a, \n Se adjuntan las credenciales para acceder al sistema de Pima Soluciones. \n \n Usuario: " + usuario + "\n Clave: "+clave;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false;

            mmsg.From = new System.Net.Mail.MailAddress("contacto@lumostintapapel.cl");
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("contacto@lumostintapapel.cl", "Slytherin250");
            cliente.Port = 26;
            cliente.EnableSsl = false;
            cliente.Host = "mail.lumostintapapel.cl"; //mail.dominio.com

            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Se ha realizado el envío de correo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar el envío de correo "+ ex.Message);
            }
        }

        private void pValidaCamposGuardaCliente() {


            MessageBox.Show("Falta por llenar campos");
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

            tbControlMantenedor.Visible = true;
            if (tbIngresaCliente.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbIngresaCliente);
            }
            tbActualizaCliente.Parent = null;
            tbEliminaCliente.Parent = null;
            tbListaCliente.Parent = null;
         


            /*
              Cuerpo.TabPages.Add(_Cuerpo_FinNC)
                    Cuerpo.TabPages.Item(0).Parent = Nothing
                    guardarPantallaAnterior(1)
             */
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (tbEliminaCliente.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbEliminaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbListaCliente.Parent = null;

        }

        private void btnLista_Click(object sender, EventArgs e)
        {

            //PRECARGAR REGION, COMUNA,CIUDAD Y REGION
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

            if (tbListaCliente.Parent == null)
            {
                // 1 es el index por la segunda pestana
                tbControlMantenedor.TabPages.Insert(1, tbListaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbEliminaCliente.Parent = null;

            try {
                dClientes dcliente = new dClientes();

                List<eCliente> listaCliente = new List<eCliente>();

                listaCliente.AddRange(dcliente.getListaCliente());

                listaCl = new BindingList<eCliente>(listaCliente);
                this.dgvListaCliente.DataSource = listaCl;
                this.Focus();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar la lista "+ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            if (tbActualizaCliente.Parent == null)
            {
                // 3 es el index por la cuarta pestana
                tbControlMantenedor.TabPages.Insert(0, tbActualizaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbListaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbEliminaCliente.Parent = null;

            if (this.dgvListaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error: Debe seleccionar un usuario para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                
            }
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
               
                /*CREAR USUARIO*/
                dClientes clientedao = new dClientes();
                DataTable obtieneCL = clientedao.obtieneMaxCliente();

                eUsuario usu = new eUsuario();
                D_Usuarios dusuario = new D_Usuarios();


                usu.idTipoUsuario = 2; //TipoUsuario: 1 Administrador - 2 Cliente
                usu.usuario = txtNombreCliente.Text.Trim().Substring(0, 1) + '.' + txtPaternoCliente.Text.Trim() + txtMaternoCliente.Text.Trim().Substring(0, 1);
                usu.clave = txtNombreCliente.Text.Trim  ().Substring(0, 1) + '.' + txtPaternoCliente.Text.Trim() + txtMaternoCliente.Text.Trim().Substring(0, 1) + txtRut.Text.Trim().Substring(0, 4);
                usu.activo = 1;
                usu.idcliente = int.Parse(obtieneCL.Rows[0]["idcliente"].ToString().Trim());
                //int.Parse(obtieneCL.Rows[0]["idcliente"].ToString());

                dusuario.creaUsuario(usu);

                MessageBox.Show("El cliente se creado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Dispose();
                /*ENVIA CORREO CON CREDENCIALES DE USUARIO*/

                pEnviaCorreo(txtMailCliente.Text,usu.usuario,usu.clave);
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

        private void chxbRutEliminaCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chxbRutEliminaCliente.Checked == true)
            {
                txtRutEliminaCliente.Enabled = true;
                txtNombreEliminaCliente.Enabled = false;
            }
            else
            {
                txtRutEliminaCliente.Enabled = false;
            }
        }

        private void chxbNombreEliminaCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chxbNombreEliminaCliente.Checked == true)
            {
                txtRutEliminaCliente.Enabled = false;
                txtNombreEliminaCliente.Enabled = true;
            }
            else
            {
                txtNombreEliminaCliente.Enabled = false;
            }
        }

        private void dgvListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dgvListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtNombreClienteListar.Text = dgvListaCliente.CurrentRow.Cells[e.RowIndex].Value;
            pnlActualiza.Visible = true;
            try
            {
                int i;
                i = dgvListaCliente.SelectedCells[0].RowIndex;
                txtNombreClienteListar.Text = dgvListaCliente.Rows[i].Cells[1].Value.ToString();
                txtPaternoClienteListar.Text = dgvListaCliente.Rows[i].Cells[2].Value.ToString();
                txtMaternoClienteListar.Text = dgvListaCliente.Rows[i].Cells[3].Value.ToString();
                
                txtRutListar.Text = dgvListaCliente.Rows[i].Cells[4].Value.ToString();
                txtDvListar.Text = dgvListaCliente.Rows[i].Cells[5].Value.ToString();
                txtTelefonoClienteListar.Text = dgvListaCliente.Rows[i].Cells[11].Value.ToString();
                txtEmailClienteListar.Text = dgvListaCliente.Rows[i].Cells[12].Value.ToString();
                txtDireccionClienteListar.Text = dgvListaCliente.Rows[i].Cells[7].Value.ToString();
                //cbRubroListaCliente.ValueMember = dgvListaCliente.Rows[i].Cells[6].Value.ToString();

                /*CARGA CB RUBROS*/
                int idRubro = int.Parse(dgvListaCliente.Rows[i].Cells[6].Value.ToString());
                dRubro rubrodao = new dRubro();
                DataTable drubro = rubrodao.obtieneRubrosporId(idRubro);

                this.cbRubroListaCliente.DataSource = drubro;
                this.cbRubroListaCliente.DisplayMember = "descripcionrubro";
                this.cbRubroListaCliente.ValueMember = "idrubro";




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void btnBuscaEliminaCliente_Click(object sender, EventArgs e)
        {
            int rutEliminaCliente;
            string nombreEliminaCliente;

            rutEliminaCliente = int.Parse(txtRutEliminaCliente.Text.ToString());
            nombreEliminaCliente = txtNombreEliminaCliente.Text.ToString();

            try
            {
                dClientes dcliente = new dClientes();

                List<eCliente> listaCliente = new List<eCliente>();



                listaCliente.AddRange(dcliente.getListaClientePorRutorName(rutEliminaCliente,nombreEliminaCliente));

                listaCl = new BindingList<eCliente>(listaCliente);
                this.dgvListaEliminar.DataSource = listaCl;
                this.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarListar_Click(object sender, EventArgs e)
        {
            int i,idcliente;
            i = dgvListaCliente.SelectedCells[0].RowIndex;

            idcliente = int.Parse(dgvListaCliente.Rows[i].Cells[0].Value.ToString());

            try
            {
                 dClientes eliminaCliente  = new dClientes();
                eliminaCliente.eliminaCliente(idcliente);
                MessageBox.Show("Éxito al eliminar producto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto.", ex.Message);
            }
        }

        private void dgvListaEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnEliminaEliminar_Click(object sender, EventArgs e)
        {
            int i, idcliente;
            i = dgvListaEliminar.SelectedCells[0].RowIndex;

            idcliente = int.Parse(dgvListaEliminar.Rows[i].Cells[0].Value.ToString());

            try
            {
                dClientes eliminaCliente = new dClientes();
                eliminaCliente.eliminaCliente(idcliente);
                MessageBox.Show("Éxito al eliminar producto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto.", ex.Message);
            }
        }
    }
}
