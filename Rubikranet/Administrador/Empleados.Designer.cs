namespace Rubikranet.Administrador
{
    partial class Empleados
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.panel = new System.Windows.Forms.Panel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboCantidadReg = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalReg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalPag = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagActual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabEmpleados = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboArea = new MetroFramework.Controls.MetroComboBox();
            this.comboPrivilegio = new MetroFramework.Controls.MetroComboBox();
            this.comboCargo = new MetroFramework.Controls.MetroComboBox();
            this.comboEstatus = new MetroFramework.Controls.MetroComboBox();
            this.txtNIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRFID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboMunicipio = new MetroFramework.Controls.MetroComboBox();
            this.comboEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDirección = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.radioSexo2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioSexo = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtAM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.btnRefrescar = new System.Windows.Forms.PictureBox();
            this.btnUltimaPag = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.btnPrimerPagina = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.btnRefrescar);
            this.panel.Controls.Add(this.txtBuscar);
            this.panel.Controls.Add(this.comboCantidadReg);
            this.panel.Controls.Add(this.lblTotalReg);
            this.panel.Controls.Add(this.materialLabel6);
            this.panel.Controls.Add(this.lblTotalPag);
            this.panel.Controls.Add(this.materialLabel4);
            this.panel.Controls.Add(this.lblPagActual);
            this.panel.Controls.Add(this.materialLabel2);
            this.panel.Controls.Add(this.btnUltimaPag);
            this.panel.Controls.Add(this.btnSiguiente);
            this.panel.Controls.Add(this.btnAnterior);
            this.panel.Controls.Add(this.btnPrimerPagina);
            this.panel.Controls.Add(this.tabEmpleados);
            this.panel.Controls.Add(this.tablaEmpleados);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(910, 584);
            this.panel.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(661, 272);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(242, 23);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.Tag = "Buscar...";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // comboCantidadReg
            // 
            this.comboCantidadReg.FormattingEnabled = true;
            this.comboCantidadReg.ItemHeight = 23;
            this.comboCantidadReg.Items.AddRange(new object[] {
            "20",
            "30",
            "50"});
            this.comboCantidadReg.Location = new System.Drawing.Point(519, 266);
            this.comboCantidadReg.Name = "comboCantidadReg";
            this.comboCantidadReg.Size = new System.Drawing.Size(59, 29);
            this.comboCantidadReg.TabIndex = 32;
            this.comboCantidadReg.SelectedIndexChanged += new System.EventHandler(this.comboCantidadReg_SelectedIndexChanged);
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalReg.Depth = 0;
            this.lblTotalReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalReg.Location = new System.Drawing.Point(458, 272);
            this.lblTotalReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(0, 18);
            this.lblTotalReg.TabIndex = 31;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(371, 272);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(80, 18);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Registros: ";
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPag.Depth = 0;
            this.lblTotalPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPag.Location = new System.Drawing.Point(315, 272);
            this.lblTotalPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(0, 18);
            this.lblTotalPag.TabIndex = 29;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(284, 272);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(24, 18);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPagActual.Depth = 0;
            this.lblPagActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPagActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagActual.Location = new System.Drawing.Point(252, 272);
            this.lblPagActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(0, 18);
            this.lblPagActual.TabIndex = 27;
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(192, 272);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 18);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Página";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.tab1);
            this.tabEmpleados.Controls.Add(this.tab2);
            this.tabEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabEmpleados.ImageList = this.ListaImagenes;
            this.tabEmpleados.Location = new System.Drawing.Point(0, 0);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.SelectedIndex = 0;
            this.tabEmpleados.Size = new System.Drawing.Size(910, 257);
            this.tabEmpleados.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.panel1);
            this.tab1.ImageIndex = 0;
            this.tab1.Location = new System.Drawing.Point(4, 23);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(902, 230);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Nuevo/actualiza Empleado";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.comboArea);
            this.panel1.Controls.Add(this.comboPrivilegio);
            this.panel1.Controls.Add(this.comboCargo);
            this.panel1.Controls.Add(this.comboEstatus);
            this.panel1.Controls.Add(this.txtNIP);
            this.panel1.Controls.Add(this.txtRFID);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.comboMunicipio);
            this.panel1.Controls.Add(this.comboEstado);
            this.panel1.Controls.Add(this.txtCP);
            this.panel1.Controls.Add(this.txtDirección);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.dtNacimiento);
            this.panel1.Controls.Add(this.radioSexo2);
            this.panel1.Controls.Add(this.radioSexo);
            this.panel1.Controls.Add(this.txtAM);
            this.panel1.Controls.Add(this.txtAP);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 224);
            this.panel1.TabIndex = 0;
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.ItemHeight = 23;
            this.comboArea.Location = new System.Drawing.Point(726, 142);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(154, 29);
            this.comboArea.Style = MetroFramework.MetroColorStyle.Black;
            this.comboArea.TabIndex = 19;
            // 
            // comboPrivilegio
            // 
            this.comboPrivilegio.FormattingEnabled = true;
            this.comboPrivilegio.ItemHeight = 23;
            this.comboPrivilegio.Location = new System.Drawing.Point(726, 105);
            this.comboPrivilegio.Name = "comboPrivilegio";
            this.comboPrivilegio.Size = new System.Drawing.Size(154, 29);
            this.comboPrivilegio.Style = MetroFramework.MetroColorStyle.Black;
            this.comboPrivilegio.TabIndex = 18;
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.ItemHeight = 23;
            this.comboCargo.Location = new System.Drawing.Point(726, 70);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(154, 29);
            this.comboCargo.Style = MetroFramework.MetroColorStyle.Black;
            this.comboCargo.TabIndex = 17;
            // 
            // comboEstatus
            // 
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.ItemHeight = 23;
            this.comboEstatus.Location = new System.Drawing.Point(726, 35);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.Size = new System.Drawing.Size(154, 29);
            this.comboEstatus.Style = MetroFramework.MetroColorStyle.Black;
            this.comboEstatus.TabIndex = 16;
            // 
            // txtNIP
            // 
            this.txtNIP.Depth = 0;
            this.txtNIP.Hint = "NIP...";
            this.txtNIP.Location = new System.Drawing.Point(512, 162);
            this.txtNIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.PasswordChar = '\0';
            this.txtNIP.SelectedText = "";
            this.txtNIP.SelectionLength = 0;
            this.txtNIP.SelectionStart = 0;
            this.txtNIP.Size = new System.Drawing.Size(84, 23);
            this.txtNIP.TabIndex = 15;
            this.txtNIP.Tag = "NIP...";
            this.txtNIP.UseSystemPasswordChar = false;
            // 
            // txtRFID
            // 
            this.txtRFID.Depth = 0;
            this.txtRFID.Hint = "RFID...";
            this.txtRFID.Location = new System.Drawing.Point(512, 133);
            this.txtRFID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.PasswordChar = '\0';
            this.txtRFID.SelectedText = "";
            this.txtRFID.SelectionLength = 0;
            this.txtRFID.SelectionStart = 0;
            this.txtRFID.Size = new System.Drawing.Size(194, 23);
            this.txtRFID.TabIndex = 14;
            this.txtRFID.Tag = "RFID...";
            this.txtRFID.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "Correo...";
            this.txtCorreo.Location = new System.Drawing.Point(512, 75);
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(198, 23);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Tag = "Correo...";
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono...";
            this.txtTelefono.Location = new System.Drawing.Point(512, 41);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(198, 23);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Tag = "Teléfono...";
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // comboMunicipio
            // 
            this.comboMunicipio.FormattingEnabled = true;
            this.comboMunicipio.ItemHeight = 23;
            this.comboMunicipio.Location = new System.Drawing.Point(247, 168);
            this.comboMunicipio.Name = "comboMunicipio";
            this.comboMunicipio.Size = new System.Drawing.Size(198, 29);
            this.comboMunicipio.Style = MetroFramework.MetroColorStyle.Black;
            this.comboMunicipio.TabIndex = 11;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.ItemHeight = 23;
            this.comboEstado.Location = new System.Drawing.Point(247, 133);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(198, 29);
            this.comboEstado.Style = MetroFramework.MetroColorStyle.Black;
            this.comboEstado.TabIndex = 10;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // txtCP
            // 
            this.txtCP.Depth = 0;
            this.txtCP.Hint = "Código postal...";
            this.txtCP.Location = new System.Drawing.Point(244, 104);
            this.txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '\0';
            this.txtCP.SelectedText = "";
            this.txtCP.SelectionLength = 0;
            this.txtCP.SelectionStart = 0;
            this.txtCP.Size = new System.Drawing.Size(111, 23);
            this.txtCP.TabIndex = 9;
            this.txtCP.Tag = "Código postal...";
            this.txtCP.UseSystemPasswordChar = false;
            // 
            // txtDirección
            // 
            this.txtDirección.Depth = 0;
            this.txtDirección.Hint = "Dirección...";
            this.txtDirección.Location = new System.Drawing.Point(244, 75);
            this.txtDirección.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.PasswordChar = '\0';
            this.txtDirección.SelectedText = "";
            this.txtDirección.SelectionLength = 0;
            this.txtDirección.SelectionStart = 0;
            this.txtDirección.Size = new System.Drawing.Size(247, 23);
            this.txtDirección.TabIndex = 8;
            this.txtDirección.Tag = "Dirección...";
            this.txtDirección.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(241, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(129, 18);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Fecha nacimiento:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Location = new System.Drawing.Point(244, 44);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtNacimiento.TabIndex = 6;
            // 
            // radioSexo2
            // 
            this.radioSexo2.AutoSize = true;
            this.radioSexo2.Depth = 0;
            this.radioSexo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSexo2.Location = new System.Drawing.Point(125, 167);
            this.radioSexo2.Margin = new System.Windows.Forms.Padding(0);
            this.radioSexo2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSexo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSexo2.Name = "radioSexo2";
            this.radioSexo2.Ripple = true;
            this.radioSexo2.Size = new System.Drawing.Size(90, 30);
            this.radioSexo2.TabIndex = 5;
            this.radioSexo2.TabStop = true;
            this.radioSexo2.Tag = "f";
            this.radioSexo2.Text = "Femenino";
            this.radioSexo2.UseVisualStyleBackColor = true;
            // 
            // radioSexo
            // 
            this.radioSexo.AutoSize = true;
            this.radioSexo.Depth = 0;
            this.radioSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSexo.Location = new System.Drawing.Point(14, 167);
            this.radioSexo.Margin = new System.Windows.Forms.Padding(0);
            this.radioSexo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSexo.Name = "radioSexo";
            this.radioSexo.Ripple = true;
            this.radioSexo.Size = new System.Drawing.Size(93, 30);
            this.radioSexo.TabIndex = 4;
            this.radioSexo.TabStop = true;
            this.radioSexo.Tag = "m";
            this.radioSexo.Text = "Masculino";
            this.radioSexo.UseVisualStyleBackColor = true;
            // 
            // txtAM
            // 
            this.txtAM.Depth = 0;
            this.txtAM.Hint = "Apellido materno...";
            this.txtAM.Location = new System.Drawing.Point(23, 133);
            this.txtAM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAM.Name = "txtAM";
            this.txtAM.PasswordChar = '\0';
            this.txtAM.SelectedText = "";
            this.txtAM.SelectionLength = 0;
            this.txtAM.SelectionStart = 0;
            this.txtAM.Size = new System.Drawing.Size(200, 23);
            this.txtAM.TabIndex = 3;
            this.txtAM.Tag = "Apellido materno...";
            this.txtAM.UseSystemPasswordChar = false;
            // 
            // txtAP
            // 
            this.txtAP.Depth = 0;
            this.txtAP.Hint = "Apellido paterno...";
            this.txtAP.Location = new System.Drawing.Point(23, 104);
            this.txtAP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAP.Name = "txtAP";
            this.txtAP.PasswordChar = '\0';
            this.txtAP.SelectedText = "";
            this.txtAP.SelectionLength = 0;
            this.txtAP.SelectionStart = 0;
            this.txtAP.Size = new System.Drawing.Size(200, 23);
            this.txtAP.TabIndex = 2;
            this.txtAP.Tag = "Apellido paterno...";
            this.txtAP.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre...";
            this.txtNombre.Location = new System.Drawing.Point(23, 75);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(201, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "Nombre...";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "Id empleado...";
            this.txtId.Location = new System.Drawing.Point(24, 46);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "Id empleado...";
            this.txtId.UseSystemPasswordChar = false;
            // 
            // tab2
            // 
            this.tab2.ImageIndex = 1;
            this.tab2.Location = new System.Drawing.Point(4, 23);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(902, 230);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Otro...";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "lighthing_bolt.png");
            this.ListaImagenes.Images.SetKeyName(1, "wrench.png");
            this.ListaImagenes.Images.SetKeyName(2, "flash.png");
            // 
            // tablaEmpleados
            // 
            this.tablaEmpleados.AllowUserToAddRows = false;
            this.tablaEmpleados.AllowUserToDeleteRows = false;
            this.tablaEmpleados.AllowUserToResizeColumns = false;
            this.tablaEmpleados.AllowUserToResizeRows = false;
            this.tablaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablaEmpleados.Location = new System.Drawing.Point(0, 308);
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.ReadOnly = true;
            this.tablaEmpleados.Size = new System.Drawing.Size(910, 276);
            this.tablaEmpleados.TabIndex = 0;
            this.tablaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleados_CellContentClick);
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 1000;
            this.timerCarga.Tick += new System.EventHandler(this.timerEmpleados_Tick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackgroundImage = global::Rubikranet.Properties.Resources.synchronize;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Location = new System.Drawing.Point(598, 262);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimaPag.BackgroundImage")));
            this.btnUltimaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimaPag.Location = new System.Drawing.Point(132, 262);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(40, 40);
            this.btnUltimaPag.TabIndex = 25;
            this.btnUltimaPag.TabStop = false;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(90, 262);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(44, 262);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimerPagina
            // 
            this.btnPrimerPagina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrimerPagina.BackgroundImage")));
            this.btnPrimerPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimerPagina.InitialImage = null;
            this.btnPrimerPagina.Location = new System.Drawing.Point(3, 262);
            this.btnPrimerPagina.Name = "btnPrimerPagina";
            this.btnPrimerPagina.Size = new System.Drawing.Size(40, 40);
            this.btnPrimerPagina.TabIndex = 22;
            this.btnPrimerPagina.TabStop = false;
            this.btnPrimerPagina.Click += new System.EventHandler(this.btnPrimerPagina_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(812, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(756, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(96, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Id Empleado:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(508, 111);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(44, 19);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "RFID:";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel);
            this.Name = "Empleados";
            this.Size = new System.Drawing.Size(910, 584);
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.tabEmpleados.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView tablaEmpleados;
        private System.Windows.Forms.TabControl tabEmpleados;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAM;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private MaterialSkin.Controls.MaterialRadioButton radioSexo2;
        private MaterialSkin.Controls.MaterialRadioButton radioSexo;
        private MetroFramework.Controls.MetroComboBox comboMunicipio;
        private MetroFramework.Controls.MetroComboBox comboEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDirección;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MetroFramework.Controls.MetroComboBox comboArea;
        private MetroFramework.Controls.MetroComboBox comboPrivilegio;
        private MetroFramework.Controls.MetroComboBox comboCargo;
        private MetroFramework.Controls.MetroComboBox comboEstatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRFID;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnUltimaPag;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox btnPrimerPagina;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MetroFramework.Controls.MetroComboBox comboCantidadReg;
        private MaterialSkin.Controls.MaterialLabel lblTotalReg;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblTotalPag;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblPagActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ImageList ListaImagenes;
        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.PictureBox btnRefrescar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
