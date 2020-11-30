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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

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

        void esconderBotones()
        {
            btnIngresa.Visible = false;
            btnLista.Visible = false;
            btnElimina.Visible = false;
        }

        void limpiaPanelListar() {
           /*PANEL LISTAR*/
            pnlActualiza.Visible = false;
            txtNombreClienteListar.Clear();
            txtPaternoClienteListar.Clear();
            txtMaternoClienteListar.Clear();
            txtRutListar.Clear();
            txtTelefonoClienteListar.Clear();
            txtEmailClienteListar.Clear();
            txtDireccionClienteListar.Clear();
            cbComunaListaCliente.SelectedIndex = -1;
            cbCiudadListaCliente.SelectedIndex = -1;
            cbRegionListaCliente.SelectedIndex = -1;
            cbRubroListaCliente.SelectedIndex = -1;
            /*PANEL ACTUALIZAR*/

            pnlActualizar.Visible = false;


        }





        bool IsValidEmail(string strIn)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        string DomainMapper(Match match)
        {
            bool invalid = false;
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        bool ValidaRut(string rut, string dv)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
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
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
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

        void pMantenedorFalse()
        {
            grxMantenedorCliente.Visible = false;
            btnLista.Visible = false;
            btnElimina.Visible = false;
            btnIngresa.Visible = false;
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
            limpiaPanelListar();
            tbControlMantenedor.Visible = true;
            if (tbIngresaCliente.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbIngresaCliente);
            }
            tbActualizaCliente.Parent = null;
            tbEliminaCliente.Parent = null;
            tbListaCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbBuscar.Parent = null;
            tbInfomeCliente.Parent = null;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

            limpiaPanelListar();


            if (tbEliminaCliente.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbEliminaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbListaCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbBuscar.Parent = null;
            tbInfomeCliente.Parent = null;

        }

        private void btnLista_Click(object sender, EventArgs e)
        {

            ////PRECARGAR REGION, COMUNA,CIUDAD Y REGION
            ///*CARGA CB RUBROS*/
            //dRubro rubrodao = new dRubro();
            //DataTable drubro = rubrodao.obtieneRubros();

            //this.cbRubroListaCliente.DataSource = drubro;
            //this.cbRubroListaCliente.DisplayMember = "descripcionrubro";
            //this.cbRubroListaCliente.ValueMember = "idrubro";


            ///*CARGA CB COMUNA*/
            //dComuna comunadao = new dComuna();
            //DataTable dcomuna = comunadao.obtieneComunacb();

            //this.cbComunaListaCliente.DataSource = dcomuna;
            //this.cbComunaListaCliente.DisplayMember = "nombrecomuna";
            //this.cbComunaListaCliente.ValueMember = "idcomuna";

            ///*CARGA CB CIUDAD*/

            //this.cbCiudadListaCliente.DataSource = dcomuna;
            //this.cbCiudadListaCliente.DisplayMember = "nombreciudad";
            //this.cbCiudadListaCliente.ValueMember = "idciudad";

            ///*CARGA CB REGION*/

            //this.cbRegionListaCliente.DataSource = dcomuna;
            //this.cbRegionListaCliente.DisplayMember = "nombreregion";
            //this.cbRegionListaCliente.ValueMember = "idregion";

            if (tbListaCliente.Parent == null)
            {
                // 1 es el index por la segunda pestana
                tbControlMantenedor.TabPages.Insert(1, tbListaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbEliminaCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbBuscar.Parent = null;
            tbInfomeCliente.Parent = null; 


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
            if (tbListaCliente.Parent == null)
            {
                // 3 es el index por la cuarta pestana
                tbControlMantenedor.TabPages.Insert(0, tbListaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbEliminaCliente.Parent = null;
            tbInfomeCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbBuscar.Parent = null;


            if (this.dgvListaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error: Debe seleccionar un usuario para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //eCliente e_cliente = new eCliente();
                //e_cliente.nombre = txtNombreClienteListar.Text.Trim();
                //e_cliente.apPaterno = txtPaternoClienteListar.Text.Trim();
                //e_cliente.apMaterno = txtMaternoClienteListar.Text.Trim();
                //e_cliente.rut = int.Parse(txtRutListar.Text.Trim());


                /*CREAR CLIENTE*/
                eCliente cl = new eCliente();
                dClientes dcliente = new dClientes();


                cl.idcliente = int.Parse(txtIdCliente.Text.Trim());
                cl.nombre = txtNombreClienteListar.Text.Trim();
                cl.apPaterno = txtPaternoClienteListar.Text.Trim();
                cl.apMaterno = txtMaternoClienteListar.Text.Trim();
                cl.rut = int.Parse(txtRutListar.Text.Trim());
                cl.dvVerificador = txtDvListar.Text.Trim();
                cl.idRubro = int.Parse(cbRubroListaCliente.SelectedValue.ToString());
                cl.direccion = txtDireccionClienteListar.Text.Trim();
                cl.codComuna = int.Parse(cbComunaListaCliente.SelectedValue.ToString());
                cl.codCiudad = int.Parse(cbCiudadListaCliente.SelectedValue.ToString());
                cl.codRegion = int.Parse(cbComunaListaCliente.SelectedValue.ToString());
                cl.telefono = int.Parse(txtTelefonoClienteListar.Text.Trim());
                cl.email = txtEmailClienteListar.Text.Trim();


                dcliente.editaCliente(cl);
                MessageBox.Show("Cliente editado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void MantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbControlMantenedor.Visible = false;
          

        }

        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            grxMantenedorCliente.Visible = true;
            grxMantenedorCliente.Text = "BUSCAR";
            esconderBotones();

            limpiaPanelListar();
            tbControlMantenedor.Visible = true;
            if (tbBuscar.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbBuscar);
            }
            tbActualizaCliente.Parent = null;
            tbEliminaCliente.Parent = null;
            tbListaCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbInfomeCliente.Parent = null;
            tbIngresaCliente.Parent = null;
        }

        private void InformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderBotones();
            limpiaPanelListar();

        }

        private void ClienteMantenedor_Click(object sender, EventArgs e)
        {
            grxMantenedorCliente.Text = "MANTENEDOR-CLIENTE";
            grxMantenedorCliente.Visible = true;
            btnLista.Visible = true;
            btnElimina.Visible = true;
            btnIngresa.Visible = true;
            rbCliente.Checked = true;
            rbProfesional.Checked = false;
               


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

            pCalculaDV(int.Parse(txtRut.Text));

            /*VALIDACION DATOS*/
            if (String.IsNullOrEmpty(txtNombreCliente.Text) || txtNombreCliente.TextLength < 3)
            {
                MessageBox.Show("Error: El Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCliente.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtRut.Text) || txtRut.TextLength < 7)
            {
                MessageBox.Show("Error: El Rut es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRut.Focus();
                return;
            }

            else if (String.IsNullOrEmpty(txtTelefonoCliente.Text) || txtTelefonoCliente.TextLength < 9)
            {
                MessageBox.Show("Error: El telefono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefonoCliente.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMailCliente.Text) )
            {
                MessageBox.Show("Error: El Mail es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMailCliente.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Error: La dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccionCliente.Focus();
                return;
            }
            //else if (!ValidaRut(txtRut.Text.Trim(),txtDV.Text.Trim()))
            //{
            //    MessageBox.Show("Error: El Rut ingresado no es válido. Debe ser sin puntos y con guión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtRut.Focus();
            //    return;
            //}
            else if (!IsValidEmail(txtMailCliente.Text.Trim()))
            {
                MessageBox.Show("Error: El Email ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMailCliente.Focus();
                return;
            }

            try
            {


                /*CREAR CLIENTE*/
                eCliente cl = new eCliente();
                dClientes dcliente = new dClientes();
               


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
                MessageBox.Show("Error: Ha ocurrido un error al crear el usuario. "+ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtIdCliente.Text = dgvListaCliente.Rows[i].Cells[0].Value.ToString();
                txtNombreClienteListar.Text = dgvListaCliente.Rows[i].Cells[1].Value.ToString();
                txtPaternoClienteListar.Text = dgvListaCliente.Rows[i].Cells[2].Value.ToString();
                txtMaternoClienteListar.Text = dgvListaCliente.Rows[i].Cells[3].Value.ToString();
                
                txtRutListar.Text = dgvListaCliente.Rows[i].Cells[4].Value.ToString();
                txtDvListar.Text = dgvListaCliente.Rows[i].Cells[5].Value.ToString();
                txtTelefonoClienteListar.Text = dgvListaCliente.Rows[i].Cells[11].Value.ToString();
                txtEmailClienteListar.Text = dgvListaCliente.Rows[i].Cells[12].Value.ToString();
                txtDireccionClienteListar.Text = dgvListaCliente.Rows[i].Cells[7].Value.ToString();
                //cbRubroListaCliente.ValueMember = dgvListaCliente.Rows[i].Cells[6].Value.ToString();


                /*PRECARGA RUBROS*/
                dRubro rubrodao = new dRubro();
                DataTable drubro = rubrodao.obtieneRubros();

                this.cbRubroListaCliente.DataSource = drubro;
                this.cbRubroListaCliente.DisplayMember = "descripcionrubro";
                this.cbRubroListaCliente.ValueMember = "idrubro";
                cbRubroListaCliente.SelectedValue = int.Parse(dgvListaCliente.Rows[i].Cells[6].Value.ToString());

                /*CARGA CB COMUNA*/
                dComuna comunadao = new dComuna();
                DataTable dcomuna = comunadao.obtieneComunacb();

                this.cbComunaListaCliente.DataSource = dcomuna;
                this.cbComunaListaCliente.DisplayMember = "nombrecomuna";
                this.cbComunaListaCliente.ValueMember = "idcomuna";
                cbComunaListaCliente.SelectedValue = int.Parse(dgvListaCliente.Rows[i].Cells[8].Value.ToString());


                /*CARGA CB CIUDAD*/

                this.cbCiudadListaCliente.DataSource = dcomuna;
                this.cbCiudadListaCliente.DisplayMember = "nombreciudad";
                this.cbCiudadListaCliente.ValueMember = "idciudad";
                cbCiudadListaCliente.SelectedValue = int.Parse(dgvListaCliente.Rows[i].Cells[9].Value.ToString());


                /*CARGA CB REGION*/

                this.cbRegionListaCliente.DataSource = dcomuna;
                this.cbRegionListaCliente.DisplayMember = "nombreregion";
                this.cbRegionListaCliente.ValueMember = "idregion";
                cbRegionListaCliente.SelectedValue = int.Parse(dgvListaCliente.Rows[i].Cells[10].Value.ToString());





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

        private void ProfesionalMantenedor_Click(object sender, EventArgs e)
        {
            grxMantenedorCliente.Text = "MANTENEDOR - PROFESIONAL";
            grxMantenedorCliente.Visible = true;
            rbCliente.Checked = false;
            rbProfesional.Checked = true;

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderBotones();
            limpiaPanelListar();

        }

        private void btnDescargaListadoCliente_Click(object sender, EventArgs e)
        {
            dClientes creapdf = new dClientes();

            creapdf.creaPdf();

        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grxMantenedorCliente.Text = "MANTENEDOR - USUARIO";
            grxMantenedorCliente.Visible = true;
        }

        private void pLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grxMantenedorCliente.Text = "MANTENEDOR - PLAN";
            grxMantenedorCliente.Visible = true;
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rut;
            string nombre;



            if (!string.IsNullOrEmpty(txtRutBuscar.Text))
            {
                rut = int.Parse(txtRutBuscar.Text.ToString());
                nombre = " ";
            }
            else
            {
                nombre = txtNombreBusca.Text.ToString();
                rut = '0';

            }





            try
            {

                if (rdCliente.Checked == true)
                {

                    dClientes dcliente = new dClientes();

                    List<eCliente> listaCliente = new List<eCliente>();


                   

                    listaCliente.AddRange(dcliente.getListaClientePorRutorName(rut, nombre));

                    listaCl = new BindingList<eCliente>(listaCliente);
                    this.dgvBuscar.DataSource = listaCl;
                    this.Focus();
                }
                else if (rdProfesional.Checked == true)
                {  nombre = txtNombreBusca.Text.ToString();
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chxRutBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (chxRutBuscar.Checked == true)
            {
                txtRutBuscar.Enabled = true;
                txtNombreBusca.Enabled = false;
                chxNombreBuscar.Checked = false;
            }
            else
            {
                txtRutBuscar.Enabled = false;
            }
        }

        private void chxNombreBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (chxNombreBuscar.Checked == true)
            {
                txtRutBuscar.Enabled = false;
                txtNombreBusca.Enabled = true;
                chxRutBuscar.Checked = false;
            }
            else
            {
                txtNombreBusca.Enabled = false;
            }
        }

        private void pROFESIONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esconderBotones();
            limpiaPanelListar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            tbEliminaCliente.Text = "Acualizar";
            pnlActualizar.Visible = true;

            if (tbEliminaCliente.Parent == null)
            {
                // 0 es el index por la primera pestana
                tbControlMantenedor.TabPages.Insert(0, tbEliminaCliente);
            }
            tbControlMantenedor.Visible = true;
            tbActualizaCliente.Parent = null;
            tbIngresaCliente.Parent = null;
            tbListaCliente.Parent = null;
            tbIngresaProfesional.Parent = null;
            tbBuscar.Parent = null;
            tbInfomeCliente.Parent = null;


            
            }

        private void dgvListaEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbCliente.Checked == true)
            {
                try
                {
                    int i;
                    i = dgvListaEliminar.SelectedCells[0].RowIndex;
                    txtNombreActualiza.Text = dgvListaEliminar.Rows[i].Cells[1].Value.ToString();
                    txtPaternoActualiza.Text = dgvListaEliminar.Rows[i].Cells[2].Value.ToString();
                    txtMaternoActualiza.Text = dgvListaEliminar.Rows[i].Cells[3].Value.ToString();

                    txtRutActualiza.Text = dgvListaEliminar.Rows[i].Cells[4].Value.ToString();
                    txtDvActualiza.Text = dgvListaEliminar.Rows[i].Cells[5].Value.ToString();
                    txtTelefonoActualiza.Text = dgvListaEliminar.Rows[i].Cells[11].Value.ToString();
                    txtMailActualiza.Text = dgvListaEliminar.Rows[i].Cells[12].Value.ToString();
                    txtDireccionActualiza.Text = dgvListaEliminar.Rows[i].Cells[7].Value.ToString();
                    //cbRubroListaCliente.ValueMember = dgvListaCliente.Rows[i].Cells[6].Value.ToString();

                    /*CARGA CB RUBROS*/
                    int idRubro = int.Parse(dgvListaEliminar.Rows[i].Cells[6].Value.ToString());
                    dRubro rubrodao = new dRubro();
                    DataTable drubro = rubrodao.obtieneRubrosporId(idRubro);

                    this.cbRubroActualiza.DataSource = drubro;
                    this.cbRubroActualiza.DisplayMember = "descripcionrubro";
                    this.cbRubroActualiza.ValueMember = "idrubro";




                }
                catch (Exception ex)
                {
                    throw new Exception(" se produjo un error: " + ex.Message);
                }
            }
    }

        /* private void creaPdf()
         {
             DateTime fecha = DateTime.Now;
             string fechaActual = fecha.ToString("dd-MM-yyyy");
             //string ruta = 'C:\Users\M.ibarraO\Documents\DUOC\Aplicaciones\GeneraPDF\Listado_ClienteActual_' + fechaActual+'.pdf';

             PdfWriter pdfwriter = new PdfWriter("Listado_ClienteActual_"+ fechaActual + ".pdf");
             //Crear documento
             PdfDocument pdf = new PdfDocument(pdfwriter);
             Document documento = new Document(pdf,PageSize.LETTER);

             documento.SetMargins(60,20,55,20);

             PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
             PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

             string[] columnas = { "idcliente", "nombre", "paterno", "materno", "rut", "dvs", "idrubro", "direccion", "codcomuna", "ciudad", "region", "telefono", "mail" };
             float[] tamanios = {5,50,50,50,10,1,4,100,10,10,10,50,50 };

             Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
             tabla.SetWidth(UnitValue.CreatePercentValue(100));

             foreach (string columna in columnas)
             {
                 tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
             }

             //Cargardatos en TablaPDF
             int i;
             i = dgvListaCliente.SelectedCells[0].RowIndex;

             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[0].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[1].Value.ToString()).SetFont(fontContenido))) ;
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[2].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[3].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[4].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[5].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[6].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[7].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[8].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[9].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[10].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[11].Value.ToString()).SetFont(fontContenido)));
             tabla.AddCell(new Cell().Add(new Paragraph(dgvListaCliente.Rows[i].Cells[12].Value.ToString()).SetFont(fontContenido)));





             documento.Add(tabla);
             documento.Close();

         }*/
    }
}
