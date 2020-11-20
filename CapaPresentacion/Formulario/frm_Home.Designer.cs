namespace CapaPresentacion.Formulario
{
    partial class frm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MantenedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfesionalMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grxMantenedorCliente = new System.Windows.Forms.GroupBox();
            this.lblDvCliente = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblRutCliente = new System.Windows.Forms.Label();
            this.txtMaternoCliente = new System.Windows.Forms.TextBox();
            this.txtPaternoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblMaternoCliente = new System.Windows.Forms.Label();
            this.lblPaternoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnIngresa = new System.Windows.Forms.Button();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.lblRubroCliente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblComunaCliente = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.lblMailCliente = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlIngresar = new System.Windows.Forms.Panel();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grxMantenedorCliente.SuspendLayout();
            this.pnlIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenedorToolStripMenuItem,
            this.cLIENTEToolStripMenuItem1,
            this.InformesToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MantenedorToolStripMenuItem
            // 
            this.MantenedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteMantenedor,
            this.ProfesionalMantenedor});
            this.MantenedorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.MantenedorToolStripMenuItem.Name = "MantenedorToolStripMenuItem";
            this.MantenedorToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.MantenedorToolStripMenuItem.Text = "MANTENEDOR";
            this.MantenedorToolStripMenuItem.Click += new System.EventHandler(this.MantenedorToolStripMenuItem_Click);
            // 
            // ClienteMantenedor
            // 
            this.ClienteMantenedor.Name = "ClienteMantenedor";
            this.ClienteMantenedor.Size = new System.Drawing.Size(180, 22);
            this.ClienteMantenedor.Text = "CLIENTE";
            this.ClienteMantenedor.Click += new System.EventHandler(this.ClienteMantenedor_Click);
            // 
            // ProfesionalMantenedor
            // 
            this.ProfesionalMantenedor.Name = "ProfesionalMantenedor";
            this.ProfesionalMantenedor.Size = new System.Drawing.Size(180, 22);
            this.ProfesionalMantenedor.Text = "PROFESIONAL";
            // 
            // cLIENTEToolStripMenuItem1
            // 
            this.cLIENTEToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARToolStripMenuItem});
            this.cLIENTEToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.cLIENTEToolStripMenuItem1.Name = "cLIENTEToolStripMenuItem1";
            this.cLIENTEToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.cLIENTEToolStripMenuItem1.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem1_Click);
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            // 
            // InformesToolStripMenuItem
            // 
            this.InformesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem";
            this.InformesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.InformesToolStripMenuItem.Text = "INFORMES";
            this.InformesToolStripMenuItem.Click += new System.EventHandler(this.InformesToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // grxMantenedorCliente
            // 
            this.grxMantenedorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.grxMantenedorCliente.Controls.Add(this.pnlIngresar);
            this.grxMantenedorCliente.Controls.Add(this.btnIngresa);
            this.grxMantenedorCliente.Controls.Add(this.btnActualiza);
            this.grxMantenedorCliente.Controls.Add(this.btnElimina);
            this.grxMantenedorCliente.Controls.Add(this.btnLista);
            this.grxMantenedorCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.grxMantenedorCliente.Location = new System.Drawing.Point(12, 61);
            this.grxMantenedorCliente.Name = "grxMantenedorCliente";
            this.grxMantenedorCliente.Size = new System.Drawing.Size(714, 346);
            this.grxMantenedorCliente.TabIndex = 2;
            this.grxMantenedorCliente.TabStop = false;
            this.grxMantenedorCliente.Text = "CLIENTE";
            this.grxMantenedorCliente.Visible = false;
            // 
            // lblDvCliente
            // 
            this.lblDvCliente.AutoSize = true;
            this.lblDvCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvCliente.Location = new System.Drawing.Point(183, 65);
            this.lblDvCliente.Name = "lblDvCliente";
            this.lblDvCliente.Size = new System.Drawing.Size(23, 15);
            this.lblDvCliente.TabIndex = 12;
            this.lblDvCliente.Text = "DV";
            this.lblDvCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRut
            // 
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRut.Location = new System.Drawing.Point(50, 63);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(112, 13);
            this.txtRut.TabIndex = 11;
            // 
            // lblRutCliente
            // 
            this.lblRutCliente.AutoSize = true;
            this.lblRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutCliente.Location = new System.Drawing.Point(5, 64);
            this.lblRutCliente.Name = "lblRutCliente";
            this.lblRutCliente.Size = new System.Drawing.Size(26, 15);
            this.lblRutCliente.TabIndex = 10;
            this.lblRutCliente.Text = "Rut";
            this.lblRutCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaternoCliente
            // 
            this.txtMaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaternoCliente.Location = new System.Drawing.Point(477, 24);
            this.txtMaternoCliente.Name = "txtMaternoCliente";
            this.txtMaternoCliente.Size = new System.Drawing.Size(120, 13);
            this.txtMaternoCliente.TabIndex = 9;
            // 
            // txtPaternoCliente
            // 
            this.txtPaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaternoCliente.Location = new System.Drawing.Point(286, 24);
            this.txtPaternoCliente.Name = "txtPaternoCliente";
            this.txtPaternoCliente.Size = new System.Drawing.Size(120, 13);
            this.txtPaternoCliente.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Location = new System.Drawing.Point(63, 24);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(161, 13);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // lblMaternoCliente
            // 
            this.lblMaternoCliente.AutoSize = true;
            this.lblMaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaternoCliente.Location = new System.Drawing.Point(418, 25);
            this.lblMaternoCliente.Name = "lblMaternoCliente";
            this.lblMaternoCliente.Size = new System.Drawing.Size(53, 15);
            this.lblMaternoCliente.TabIndex = 6;
            this.lblMaternoCliente.Text = "Materno";
            // 
            // lblPaternoCliente
            // 
            this.lblPaternoCliente.AutoSize = true;
            this.lblPaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaternoCliente.Location = new System.Drawing.Point(230, 26);
            this.lblPaternoCliente.Name = "lblPaternoCliente";
            this.lblPaternoCliente.Size = new System.Drawing.Size(50, 15);
            this.lblPaternoCliente.TabIndex = 5;
            this.lblPaternoCliente.Text = "Paterno";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(5, 25);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(52, 15);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // btnIngresa
            // 
            this.btnIngresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnIngresa.Location = new System.Drawing.Point(143, 19);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(89, 23);
            this.btnIngresa.TabIndex = 3;
            this.btnIngresa.Text = "INGRESAR";
            this.btnIngresa.UseVisualStyleBackColor = false;
            this.btnIngresa.Click += new System.EventHandler(this.btnIngresa_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnActualiza.Location = new System.Drawing.Point(401, 20);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(100, 21);
            this.btnActualiza.TabIndex = 2;
            this.btnActualiza.Text = "ACTUALIZAR";
            this.btnActualiza.UseVisualStyleBackColor = false;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnElimina.Location = new System.Drawing.Point(319, 19);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(76, 23);
            this.btnElimina.TabIndex = 1;
            this.btnElimina.Text = "ELIMINAR";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnLista.Location = new System.Drawing.Point(238, 19);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "LISTAR";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtDV
            // 
            this.txtDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(207, 63);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(35, 13);
            this.txtDV.TabIndex = 13;
            this.txtDV.TextChanged += new System.EventHandler(this.txtDV_TextChanged);
            // 
            // lblRubroCliente
            // 
            this.lblRubroCliente.AutoSize = true;
            this.lblRubroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubroCliente.Location = new System.Drawing.Point(257, 65);
            this.lblRubroCliente.Name = "lblRubroCliente";
            this.lblRubroCliente.Size = new System.Drawing.Size(41, 15);
            this.lblRubroCliente.TabIndex = 14;
            this.lblRubroCliente.Text = "Rubro";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(502, 70);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(112, 13);
            this.txtTelefonoCliente.TabIndex = 17;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(441, 68);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(55, 15);
            this.lblTelefonoCliente.TabIndex = 16;
            this.lblTelefonoCliente.Text = "Telefono";
            this.lblTelefonoCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionCliente.Location = new System.Drawing.Point(346, 111);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(268, 13);
            this.txtDireccionCliente.TabIndex = 19;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(281, 109);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(59, 15);
            this.lblDireccionCliente.TabIndex = 18;
            this.lblDireccionCliente.Text = "Direccion";
            this.lblDireccionCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblComunaCliente
            // 
            this.lblComunaCliente.AutoSize = true;
            this.lblComunaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunaCliente.Location = new System.Drawing.Point(10, 147);
            this.lblComunaCliente.Name = "lblComunaCliente";
            this.lblComunaCliente.Size = new System.Drawing.Size(54, 15);
            this.lblComunaCliente.TabIndex = 20;
            this.lblComunaCliente.Text = "Comuna";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Enabled = false;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(196, 147);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 15);
            this.lblCiudad.TabIndex = 21;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMailCliente.Location = new System.Drawing.Point(72, 111);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(181, 13);
            this.txtMailCliente.TabIndex = 23;
            // 
            // lblMailCliente
            // 
            this.lblMailCliente.AutoSize = true;
            this.lblMailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailCliente.Location = new System.Drawing.Point(5, 112);
            this.lblMailCliente.Name = "lblMailCliente";
            this.lblMailCliente.Size = new System.Drawing.Size(31, 15);
            this.lblMailCliente.TabIndex = 22;
            this.lblMailCliente.Text = "Mail";
            this.lblMailCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnGuardar.Location = new System.Drawing.Point(274, 197);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pnlIngresar
            // 
            this.pnlIngresar.Controls.Add(this.cmbRegion);
            this.pnlIngresar.Controls.Add(this.lblRegion);
            this.pnlIngresar.Controls.Add(this.cmbCiudad);
            this.pnlIngresar.Controls.Add(this.cmbComuna);
            this.pnlIngresar.Controls.Add(this.cmbRubro);
            this.pnlIngresar.Controls.Add(this.btnGuardar);
            this.pnlIngresar.Controls.Add(this.txtMailCliente);
            this.pnlIngresar.Controls.Add(this.lblMailCliente);
            this.pnlIngresar.Controls.Add(this.lblCiudad);
            this.pnlIngresar.Controls.Add(this.lblComunaCliente);
            this.pnlIngresar.Controls.Add(this.txtDireccionCliente);
            this.pnlIngresar.Controls.Add(this.lblDireccionCliente);
            this.pnlIngresar.Controls.Add(this.txtTelefonoCliente);
            this.pnlIngresar.Controls.Add(this.lblTelefonoCliente);
            this.pnlIngresar.Controls.Add(this.lblRubroCliente);
            this.pnlIngresar.Controls.Add(this.txtDV);
            this.pnlIngresar.Controls.Add(this.lblDvCliente);
            this.pnlIngresar.Controls.Add(this.txtRut);
            this.pnlIngresar.Controls.Add(this.lblRutCliente);
            this.pnlIngresar.Controls.Add(this.txtMaternoCliente);
            this.pnlIngresar.Controls.Add(this.txtPaternoCliente);
            this.pnlIngresar.Controls.Add(this.txtNombreCliente);
            this.pnlIngresar.Controls.Add(this.lblMaternoCliente);
            this.pnlIngresar.Controls.Add(this.lblPaternoCliente);
            this.pnlIngresar.Controls.Add(this.lblNombreCliente);
            this.pnlIngresar.Location = new System.Drawing.Point(5, 66);
            this.pnlIngresar.Name = "pnlIngresar";
            this.pnlIngresar.Size = new System.Drawing.Size(703, 240);
            this.pnlIngresar.TabIndex = 25;
            this.pnlIngresar.Visible = false;
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(304, 63);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(121, 21);
            this.cmbRubro.TabIndex = 25;
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(63, 146);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(121, 21);
            this.cmbComuna.TabIndex = 26;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(248, 146);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 27;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(433, 146);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion.TabIndex = 29;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Enabled = false;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(381, 147);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(38, 12);
            this.lblRegion.TabIndex = 28;
            this.lblRegion.Text = "Region";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(760, 424);
            this.Controls.Add(this.grxMantenedorCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Home";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grxMantenedorCliente.ResumeLayout(false);
            this.pnlIngresar.ResumeLayout(false);
            this.pnlIngresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MantenedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteMantenedor;
        private System.Windows.Forms.ToolStripMenuItem ProfesionalMantenedor;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem;
        private System.Windows.Forms.GroupBox grxMantenedorCliente;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnIngresa;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblMaternoCliente;
        private System.Windows.Forms.Label lblPaternoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtMaternoCliente;
        private System.Windows.Forms.TextBox txtPaternoCliente;
        private System.Windows.Forms.Label lblDvCliente;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblRutCliente;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Label lblRubroCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblComunaCliente;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.Label lblMailCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlIngresar;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbComuna;
        private System.Windows.Forms.ComboBox cmbRubro;
    }
}