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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblComunaCliente = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grxMantenedorCliente.SuspendLayout();
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
            this.grxMantenedorCliente.Controls.Add(this.lblComunaCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtDireccionCliente);
            this.grxMantenedorCliente.Controls.Add(this.lblDireccionCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtTelefonoCliente);
            this.grxMantenedorCliente.Controls.Add(this.lblTelefonoCliente);
            this.grxMantenedorCliente.Controls.Add(this.listBox1);
            this.grxMantenedorCliente.Controls.Add(this.lblRubroCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtDV);
            this.grxMantenedorCliente.Controls.Add(this.lblDvCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtRut);
            this.grxMantenedorCliente.Controls.Add(this.lblRutCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtMaternoCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtPaternoCliente);
            this.grxMantenedorCliente.Controls.Add(this.txtNombreCliente);
            this.grxMantenedorCliente.Controls.Add(this.lblMaternoCliente);
            this.grxMantenedorCliente.Controls.Add(this.lblPaternoCliente);
            this.grxMantenedorCliente.Controls.Add(this.lblNombreCliente);
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
            this.lblDvCliente.Location = new System.Drawing.Point(188, 115);
            this.lblDvCliente.Name = "lblDvCliente";
            this.lblDvCliente.Size = new System.Drawing.Size(23, 15);
            this.lblDvCliente.TabIndex = 12;
            this.lblDvCliente.Text = "DV";
            this.lblDvCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRut
            // 
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRut.Location = new System.Drawing.Point(55, 113);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(112, 13);
            this.txtRut.TabIndex = 11;
            // 
            // lblRutCliente
            // 
            this.lblRutCliente.AutoSize = true;
            this.lblRutCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutCliente.Location = new System.Drawing.Point(10, 114);
            this.lblRutCliente.Name = "lblRutCliente";
            this.lblRutCliente.Size = new System.Drawing.Size(26, 15);
            this.lblRutCliente.TabIndex = 10;
            this.lblRutCliente.Text = "Rut";
            this.lblRutCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaternoCliente
            // 
            this.txtMaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaternoCliente.Location = new System.Drawing.Point(482, 74);
            this.txtMaternoCliente.Name = "txtMaternoCliente";
            this.txtMaternoCliente.Size = new System.Drawing.Size(120, 13);
            this.txtMaternoCliente.TabIndex = 9;
            // 
            // txtPaternoCliente
            // 
            this.txtPaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaternoCliente.Location = new System.Drawing.Point(291, 74);
            this.txtPaternoCliente.Name = "txtPaternoCliente";
            this.txtPaternoCliente.Size = new System.Drawing.Size(120, 13);
            this.txtPaternoCliente.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Location = new System.Drawing.Point(68, 74);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(161, 13);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // lblMaternoCliente
            // 
            this.lblMaternoCliente.AutoSize = true;
            this.lblMaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaternoCliente.Location = new System.Drawing.Point(423, 75);
            this.lblMaternoCliente.Name = "lblMaternoCliente";
            this.lblMaternoCliente.Size = new System.Drawing.Size(53, 15);
            this.lblMaternoCliente.TabIndex = 6;
            this.lblMaternoCliente.Text = "Materno";
            // 
            // lblPaternoCliente
            // 
            this.lblPaternoCliente.AutoSize = true;
            this.lblPaternoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaternoCliente.Location = new System.Drawing.Point(235, 76);
            this.lblPaternoCliente.Name = "lblPaternoCliente";
            this.lblPaternoCliente.Size = new System.Drawing.Size(50, 15);
            this.lblPaternoCliente.TabIndex = 5;
            this.lblPaternoCliente.Text = "Paterno";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(10, 75);
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
            this.txtDV.Location = new System.Drawing.Point(212, 113);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(35, 13);
            this.txtDV.TabIndex = 13;
            this.txtDV.TextChanged += new System.EventHandler(this.txtDV_TextChanged);
            // 
            // lblRubroCliente
            // 
            this.lblRubroCliente.AutoSize = true;
            this.lblRubroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubroCliente.Location = new System.Drawing.Point(262, 115);
            this.lblRubroCliente.Name = "lblRubroCliente";
            this.lblRubroCliente.Size = new System.Drawing.Size(41, 15);
            this.lblRubroCliente.TabIndex = 14;
            this.lblRubroCliente.Text = "Rubro";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "HOLA",
            "DIA",
            "NOCHE",
            "TAL VEZ"});
            this.listBox1.Location = new System.Drawing.Point(309, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 26);
            this.listBox1.TabIndex = 15;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(507, 120);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(112, 13);
            this.txtTelefonoCliente.TabIndex = 17;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(446, 118);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(55, 15);
            this.lblTelefonoCliente.TabIndex = 16;
            this.lblTelefonoCliente.Text = "Telefono";
            this.lblTelefonoCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionCliente.Location = new System.Drawing.Point(68, 153);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(268, 13);
            this.txtDireccionCliente.TabIndex = 19;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(10, 151);
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
            this.lblComunaCliente.Location = new System.Drawing.Point(352, 154);
            this.lblComunaCliente.Name = "lblComunaCliente";
            this.lblComunaCliente.Size = new System.Drawing.Size(54, 15);
            this.lblComunaCliente.TabIndex = 20;
            this.lblComunaCliente.Text = "Comuna";
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
            this.grxMantenedorCliente.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblComunaCliente;
    }
}