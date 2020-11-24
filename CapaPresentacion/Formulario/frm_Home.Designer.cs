﻿namespace CapaPresentacion.Formulario
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
            this.pnlIngresar = new System.Windows.Forms.Panel();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.cbComuna = new System.Windows.Forms.ComboBox();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.lblMailCliente = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblComunaCliente = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblRubroCliente = new System.Windows.Forms.Label();
            this.txtDV = new System.Windows.Forms.TextBox();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbControlMantenedor = new System.Windows.Forms.TabControl();
            this.tbIngresaCliente = new System.Windows.Forms.TabPage();
            this.tbListaCliente = new System.Windows.Forms.TabPage();
            this.tbEliminaCliente = new System.Windows.Forms.TabPage();
            this.tbActualizaCliente = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grxMantenedorCliente.SuspendLayout();
            this.pnlIngresar.SuspendLayout();
            this.tbControlMantenedor.SuspendLayout();
            this.tbIngresaCliente.SuspendLayout();
            this.tbListaCliente.SuspendLayout();
            this.tbEliminaCliente.SuspendLayout();
            this.tbActualizaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(70, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1013, 28);
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
            this.MantenedorToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.MantenedorToolStripMenuItem.Text = "MANTENEDOR";
            this.MantenedorToolStripMenuItem.Click += new System.EventHandler(this.MantenedorToolStripMenuItem_Click);
            // 
            // ClienteMantenedor
            // 
            this.ClienteMantenedor.Name = "ClienteMantenedor";
            this.ClienteMantenedor.Size = new System.Drawing.Size(224, 26);
            this.ClienteMantenedor.Text = "CLIENTE";
            this.ClienteMantenedor.Click += new System.EventHandler(this.ClienteMantenedor_Click);
            // 
            // ProfesionalMantenedor
            // 
            this.ProfesionalMantenedor.Name = "ProfesionalMantenedor";
            this.ProfesionalMantenedor.Size = new System.Drawing.Size(224, 26);
            this.ProfesionalMantenedor.Text = "PROFESIONAL";
            // 
            // cLIENTEToolStripMenuItem1
            // 
            this.cLIENTEToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARToolStripMenuItem});
            this.cLIENTEToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.cLIENTEToolStripMenuItem1.Name = "cLIENTEToolStripMenuItem1";
            this.cLIENTEToolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.cLIENTEToolStripMenuItem1.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem1_Click);
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            // 
            // InformesToolStripMenuItem
            // 
            this.InformesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem";
            this.InformesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.InformesToolStripMenuItem.Text = "INFORMES";
            this.InformesToolStripMenuItem.Click += new System.EventHandler(this.InformesToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // grxMantenedorCliente
            // 
            this.grxMantenedorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.grxMantenedorCliente.Controls.Add(this.tbControlMantenedor);
            this.grxMantenedorCliente.Controls.Add(this.btnIngresa);
            this.grxMantenedorCliente.Controls.Add(this.btnActualiza);
            this.grxMantenedorCliente.Controls.Add(this.btnElimina);
            this.grxMantenedorCliente.Controls.Add(this.btnLista);
            this.grxMantenedorCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.grxMantenedorCliente.Location = new System.Drawing.Point(16, 75);
            this.grxMantenedorCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grxMantenedorCliente.Name = "grxMantenedorCliente";
            this.grxMantenedorCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grxMantenedorCliente.Size = new System.Drawing.Size(952, 426);
            this.grxMantenedorCliente.TabIndex = 2;
            this.grxMantenedorCliente.TabStop = false;
            this.grxMantenedorCliente.Text = "CLIENTE";
            this.grxMantenedorCliente.Visible = false;
            // 
            // pnlIngresar
            // 
            this.pnlIngresar.Controls.Add(this.cbRegion);
            this.pnlIngresar.Controls.Add(this.lblRegion);
            this.pnlIngresar.Controls.Add(this.cbCiudad);
            this.pnlIngresar.Controls.Add(this.cbComuna);
            this.pnlIngresar.Controls.Add(this.cbRubro);
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
            this.pnlIngresar.Location = new System.Drawing.Point(12, 7);
            this.pnlIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIngresar.Name = "pnlIngresar";
            this.pnlIngresar.Size = new System.Drawing.Size(902, 292);
            this.pnlIngresar.TabIndex = 25;
            // 
            // cbRegion
            // 
            this.cbRegion.Enabled = false;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(577, 180);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(4);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(160, 24);
            this.cbRegion.TabIndex = 29;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Enabled = false;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(507, 181);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(55, 18);
            this.lblRegion.TabIndex = 28;
            this.lblRegion.Text = "Region";
            // 
            // cbCiudad
            // 
            this.cbCiudad.Enabled = false;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(338, 180);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(160, 24);
            this.cbCiudad.TabIndex = 27;
            // 
            // cbComuna
            // 
            this.cbComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbComuna.FormattingEnabled = true;
            this.cbComuna.Location = new System.Drawing.Point(108, 180);
            this.cbComuna.Margin = new System.Windows.Forms.Padding(4);
            this.cbComuna.Name = "cbComuna";
            this.cbComuna.Size = new System.Drawing.Size(160, 24);
            this.cbComuna.TabIndex = 26;
            this.cbComuna.SelectedIndexChanged += new System.EventHandler(this.cbComuna_SelectedIndexChanged);
            // 
            // cbRubro
            // 
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(405, 78);
            this.cbRubro.Margin = new System.Windows.Forms.Padding(4);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(160, 24);
            this.cbRubro.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnGuardar.Location = new System.Drawing.Point(381, 242);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 28);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMailCliente.Location = new System.Drawing.Point(108, 137);
            this.txtMailCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(241, 22);
            this.txtMailCliente.TabIndex = 23;
            // 
            // lblMailCliente
            // 
            this.lblMailCliente.AutoSize = true;
            this.lblMailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailCliente.Location = new System.Drawing.Point(7, 138);
            this.lblMailCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailCliente.Name = "lblMailCliente";
            this.lblMailCliente.Size = new System.Drawing.Size(35, 18);
            this.lblMailCliente.TabIndex = 22;
            this.lblMailCliente.Text = "Mail";
            this.lblMailCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Enabled = false;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(268, 181);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(54, 18);
            this.lblCiudad.TabIndex = 21;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblComunaCliente
            // 
            this.lblComunaCliente.AutoSize = true;
            this.lblComunaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunaCliente.Location = new System.Drawing.Point(13, 181);
            this.lblComunaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComunaCliente.Name = "lblComunaCliente";
            this.lblComunaCliente.Size = new System.Drawing.Size(65, 18);
            this.lblComunaCliente.TabIndex = 20;
            this.lblComunaCliente.Text = "Comuna";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionCliente.Location = new System.Drawing.Point(461, 137);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(357, 22);
            this.txtDireccionCliente.TabIndex = 19;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(375, 134);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(71, 18);
            this.lblDireccionCliente.TabIndex = 18;
            this.lblDireccionCliente.Text = "Direccion";
            this.lblDireccionCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(669, 86);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCliente.MaxLength = 9;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(149, 22);
            this.txtTelefonoCliente.TabIndex = 17;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(588, 84);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(66, 18);
            this.lblTelefonoCliente.TabIndex = 16;
            this.lblTelefonoCliente.Text = "Telefono";
            this.lblTelefonoCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRubroCliente
            // 
            this.lblRubroCliente.AutoSize = true;
            this.lblRubroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubroCliente.Location = new System.Drawing.Point(343, 80);
            this.lblRubroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubroCliente.Name = "lblRubroCliente";
            this.lblRubroCliente.Size = new System.Drawing.Size(49, 18);
            this.lblRubroCliente.TabIndex = 14;
            this.lblRubroCliente.Text = "Rubro";
            // 
            // txtDV
            // 
            this.txtDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(276, 78);
            this.txtDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(46, 22);
            this.txtDV.TabIndex = 13;
            this.txtDV.TextChanged += new System.EventHandler(this.txtDV_TextChanged);
            // 
            // lblDvCliente
            // 
            this.lblDvCliente.AutoSize = true;
            this.lblDvCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvCliente.Location = new System.Drawing.Point(244, 80);
            this.lblDvCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDvCliente.Name = "lblDvCliente";
            this.lblDvCliente.Size = new System.Drawing.Size(28, 18);
            this.lblDvCliente.TabIndex = 12;
            this.lblDvCliente.Text = "DV";
            this.lblDvCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRut
            // 
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRut.Location = new System.Drawing.Point(87, 76);
            this.txtRut.Margin = new System.Windows.Forms.Padding(4);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(149, 22);
            this.txtRut.TabIndex = 11;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // lblRutCliente
            // 
            this.lblRutCliente.AutoSize = true;
            this.lblRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutCliente.Location = new System.Drawing.Point(7, 79);
            this.lblRutCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutCliente.Name = "lblRutCliente";
            this.lblRutCliente.Size = new System.Drawing.Size(31, 18);
            this.lblRutCliente.TabIndex = 10;
            this.lblRutCliente.Text = "Rut";
            this.lblRutCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaternoCliente
            // 
            this.txtMaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaternoCliente.Location = new System.Drawing.Point(636, 30);
            this.txtMaternoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaternoCliente.Name = "txtMaternoCliente";
            this.txtMaternoCliente.Size = new System.Drawing.Size(159, 22);
            this.txtMaternoCliente.TabIndex = 9;
            this.txtMaternoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaternoCliente_KeyPress);
            // 
            // txtPaternoCliente
            // 
            this.txtPaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaternoCliente.Location = new System.Drawing.Point(381, 30);
            this.txtPaternoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaternoCliente.Name = "txtPaternoCliente";
            this.txtPaternoCliente.Size = new System.Drawing.Size(159, 22);
            this.txtPaternoCliente.TabIndex = 8;
            this.txtPaternoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaternoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Location = new System.Drawing.Point(84, 30);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(214, 22);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // lblMaternoCliente
            // 
            this.lblMaternoCliente.AutoSize = true;
            this.lblMaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaternoCliente.Location = new System.Drawing.Point(557, 31);
            this.lblMaternoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaternoCliente.Name = "lblMaternoCliente";
            this.lblMaternoCliente.Size = new System.Drawing.Size(63, 18);
            this.lblMaternoCliente.TabIndex = 6;
            this.lblMaternoCliente.Text = "Materno";
            // 
            // lblPaternoCliente
            // 
            this.lblPaternoCliente.AutoSize = true;
            this.lblPaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaternoCliente.Location = new System.Drawing.Point(307, 32);
            this.lblPaternoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaternoCliente.Name = "lblPaternoCliente";
            this.lblPaternoCliente.Size = new System.Drawing.Size(60, 18);
            this.lblPaternoCliente.TabIndex = 5;
            this.lblPaternoCliente.Text = "Paterno";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(7, 31);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(62, 18);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // btnIngresa
            // 
            this.btnIngresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnIngresa.Location = new System.Drawing.Point(240, 23);
            this.btnIngresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(119, 28);
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
            this.btnActualiza.Location = new System.Drawing.Point(584, 25);
            this.btnActualiza.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(133, 26);
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
            this.btnElimina.Location = new System.Drawing.Point(474, 23);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(101, 28);
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
            this.btnLista.Location = new System.Drawing.Point(366, 23);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(100, 28);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "LISTAR";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // tbControlMantenedor
            // 
            this.tbControlMantenedor.Controls.Add(this.tbIngresaCliente);
            this.tbControlMantenedor.Controls.Add(this.tbListaCliente);
            this.tbControlMantenedor.Controls.Add(this.tbEliminaCliente);
            this.tbControlMantenedor.Controls.Add(this.tbActualizaCliente);
            this.tbControlMantenedor.Location = new System.Drawing.Point(8, 58);
            this.tbControlMantenedor.Name = "tbControlMantenedor";
            this.tbControlMantenedor.SelectedIndex = 0;
            this.tbControlMantenedor.Size = new System.Drawing.Size(937, 335);
            this.tbControlMantenedor.TabIndex = 26;
            this.tbControlMantenedor.Visible = false;
            // 
            // tbIngresaCliente
            // 
            this.tbIngresaCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbIngresaCliente.Controls.Add(this.pnlIngresar);
            this.tbIngresaCliente.Location = new System.Drawing.Point(4, 25);
            this.tbIngresaCliente.Name = "tbIngresaCliente";
            this.tbIngresaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngresaCliente.Size = new System.Drawing.Size(929, 306);
            this.tbIngresaCliente.TabIndex = 0;
            this.tbIngresaCliente.Text = "Ingresar";
            this.tbIngresaCliente.UseVisualStyleBackColor = true;
            // 
            // tbListaCliente
            // 
            this.tbListaCliente.Controls.Add(this.button1);
            this.tbListaCliente.Location = new System.Drawing.Point(4, 25);
            this.tbListaCliente.Name = "tbListaCliente";
            this.tbListaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbListaCliente.Size = new System.Drawing.Size(929, 306);
            this.tbListaCliente.TabIndex = 1;
            this.tbListaCliente.Text = "Listar";
            this.tbListaCliente.UseVisualStyleBackColor = true;
            // 
            // tbEliminaCliente
            // 
            this.tbEliminaCliente.Controls.Add(this.button2);
            this.tbEliminaCliente.Location = new System.Drawing.Point(4, 25);
            this.tbEliminaCliente.Name = "tbEliminaCliente";
            this.tbEliminaCliente.Size = new System.Drawing.Size(929, 306);
            this.tbEliminaCliente.TabIndex = 2;
            this.tbEliminaCliente.Text = "Eliminar";
            this.tbEliminaCliente.UseVisualStyleBackColor = true;
            // 
            // tbActualizaCliente
            // 
            this.tbActualizaCliente.Controls.Add(this.button3);
            this.tbActualizaCliente.Location = new System.Drawing.Point(4, 25);
            this.tbActualizaCliente.Name = "tbActualizaCliente";
            this.tbActualizaCliente.Size = new System.Drawing.Size(929, 306);
            this.tbActualizaCliente.TabIndex = 3;
            this.tbActualizaCliente.Text = "Actualizar";
            this.tbActualizaCliente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LISTA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "ELIMINA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "ACTUALIZA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1013, 522);
            this.Controls.Add(this.grxMantenedorCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Home";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grxMantenedorCliente.ResumeLayout(false);
            this.pnlIngresar.ResumeLayout(false);
            this.pnlIngresar.PerformLayout();
            this.tbControlMantenedor.ResumeLayout(false);
            this.tbIngresaCliente.ResumeLayout(false);
            this.tbListaCliente.ResumeLayout(false);
            this.tbEliminaCliente.ResumeLayout(false);
            this.tbActualizaCliente.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbComuna;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.TabControl tbControlMantenedor;
        private System.Windows.Forms.TabPage tbIngresaCliente;
        private System.Windows.Forms.TabPage tbListaCliente;
        private System.Windows.Forms.TabPage tbEliminaCliente;
        private System.Windows.Forms.TabPage tbActualizaCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}