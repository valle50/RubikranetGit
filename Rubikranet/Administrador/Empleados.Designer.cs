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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkCambioId = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupHorario = new System.Windows.Forms.GroupBox();
            this.comboTurnos = new MetroFramework.Controls.MetroComboBox();
            this.dtDiaInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.dtDiaFin = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.radioSexo2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioSexo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
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
            this.txtAM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRefrescar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboCantidadReg = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalReg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalPag = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagActual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUltimaPag = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.btnPrimerPagina = new System.Windows.Forms.PictureBox();
            this.tablaEmpleados = new System.Windows.Forms.DataGridView();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.timerActualiza = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupHorario.SuspendLayout();
            this.groupSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.panel1);
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
            this.panel.Controls.Add(this.tablaEmpleados);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(987, 702);
            this.panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkCambioId);
            this.panel1.Controls.Add(this.groupHorario);
            this.panel1.Controls.Add(this.groupSexo);
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
            this.panel1.Controls.Add(this.txtAM);
            this.panel1.Controls.Add(this.txtAP);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 310);
            this.panel1.TabIndex = 0;
            // 
            // checkCambioId
            // 
            this.checkCambioId.AutoSize = true;
            this.checkCambioId.Depth = 0;
            this.checkCambioId.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.checkCambioId.Location = new System.Drawing.Point(628, 61);
            this.checkCambioId.Margin = new System.Windows.Forms.Padding(0);
            this.checkCambioId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkCambioId.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkCambioId.Name = "checkCambioId";
            this.checkCambioId.Ripple = true;
            this.checkCambioId.Size = new System.Drawing.Size(111, 30);
            this.checkCambioId.TabIndex = 31;
            this.checkCambioId.Text = "¿Cambiar ID?";
            this.checkCambioId.UseVisualStyleBackColor = true;
            this.checkCambioId.Visible = false;
            this.checkCambioId.CheckedChanged += new System.EventHandler(this.checkCambioId_CheckedChanged);
            // 
            // groupHorario
            // 
            this.groupHorario.Controls.Add(this.comboTurnos);
            this.groupHorario.Controls.Add(this.dtDiaInicio);
            this.groupHorario.Controls.Add(this.materialLabel8);
            this.groupHorario.Controls.Add(this.dtDiaFin);
            this.groupHorario.Controls.Add(this.materialLabel7);
            this.groupHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHorario.Location = new System.Drawing.Point(530, 112);
            this.groupHorario.Name = "groupHorario";
            this.groupHorario.Size = new System.Drawing.Size(176, 183);
            this.groupHorario.TabIndex = 30;
            this.groupHorario.TabStop = false;
            this.groupHorario.Text = "Horarios";
            // 
            // comboTurnos
            // 
            this.comboTurnos.FormattingEnabled = true;
            this.comboTurnos.ItemHeight = 23;
            this.comboTurnos.Location = new System.Drawing.Point(10, 19);
            this.comboTurnos.Name = "comboTurnos";
            this.comboTurnos.Size = new System.Drawing.Size(154, 29);
            this.comboTurnos.Style = MetroFramework.MetroColorStyle.Black;
            this.comboTurnos.TabIndex = 24;
            // 
            // dtDiaInicio
            // 
            this.dtDiaInicio.Location = new System.Drawing.Point(12, 85);
            this.dtDiaInicio.Name = "dtDiaInicio";
            this.dtDiaInicio.Size = new System.Drawing.Size(154, 24);
            this.dtDiaInicio.TabIndex = 25;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(8, 124);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(49, 17);
            this.materialLabel8.TabIndex = 28;
            this.materialLabel8.Text = "Día fin";
            // 
            // dtDiaFin
            // 
            this.dtDiaFin.Location = new System.Drawing.Point(12, 146);
            this.dtDiaFin.Name = "dtDiaFin";
            this.dtDiaFin.Size = new System.Drawing.Size(154, 24);
            this.dtDiaFin.TabIndex = 26;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(8, 63);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 17);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Día inicio:";
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.radioSexo2);
            this.groupSexo.Controls.Add(this.radioSexo);
            this.groupSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSexo.Location = new System.Drawing.Point(17, 192);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(217, 53);
            this.groupSexo.TabIndex = 29;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            // 
            // radioSexo2
            // 
            this.radioSexo2.AutoSize = true;
            this.radioSexo2.Depth = 0;
            this.radioSexo2.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioSexo2.Location = new System.Drawing.Point(119, 17);
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
            this.radioSexo.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioSexo.Location = new System.Drawing.Point(8, 17);
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
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(528, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(46, 17);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "RFID:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(15, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 17);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Id Empleado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(844, 250);
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
            this.btnGuardar.Location = new System.Drawing.Point(788, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.ItemHeight = 23;
            this.comboArea.Location = new System.Drawing.Point(759, 203);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(154, 29);
            this.comboArea.Style = MetroFramework.MetroColorStyle.Black;
            this.comboArea.TabIndex = 19;
            // 
            // comboPrivilegio
            // 
            this.comboPrivilegio.FormattingEnabled = true;
            this.comboPrivilegio.ItemHeight = 23;
            this.comboPrivilegio.Location = new System.Drawing.Point(759, 147);
            this.comboPrivilegio.Name = "comboPrivilegio";
            this.comboPrivilegio.Size = new System.Drawing.Size(154, 29);
            this.comboPrivilegio.Style = MetroFramework.MetroColorStyle.Black;
            this.comboPrivilegio.TabIndex = 18;
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.ItemHeight = 23;
            this.comboCargo.Location = new System.Drawing.Point(759, 89);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(154, 29);
            this.comboCargo.Style = MetroFramework.MetroColorStyle.Black;
            this.comboCargo.TabIndex = 17;
            // 
            // comboEstatus
            // 
            this.comboEstatus.FormattingEnabled = true;
            this.comboEstatus.ItemHeight = 23;
            this.comboEstatus.Location = new System.Drawing.Point(759, 35);
            this.comboEstatus.Name = "comboEstatus";
            this.comboEstatus.Size = new System.Drawing.Size(154, 29);
            this.comboEstatus.Style = MetroFramework.MetroColorStyle.Black;
            this.comboEstatus.TabIndex = 16;
            // 
            // txtNIP
            // 
            this.txtNIP.Depth = 0;
            this.txtNIP.Hint = "NIP...";
            this.txtNIP.Location = new System.Drawing.Point(531, 79);
            this.txtNIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.PasswordChar = '\0';
            this.txtNIP.SelectedText = "";
            this.txtNIP.SelectionLength = 0;
            this.txtNIP.SelectionStart = 0;
            this.txtNIP.Size = new System.Drawing.Size(84, 25);
            this.txtNIP.TabIndex = 15;
            this.txtNIP.Tag = "NIP...";
            this.txtNIP.UseSystemPasswordChar = false;
            // 
            // txtRFID
            // 
            this.txtRFID.Depth = 0;
            this.txtRFID.Enabled = false;
            this.txtRFID.Hint = "RFID...";
            this.txtRFID.Location = new System.Drawing.Point(531, 35);
            this.txtRFID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.PasswordChar = '\0';
            this.txtRFID.SelectedText = "";
            this.txtRFID.SelectionLength = 0;
            this.txtRFID.SelectionStart = 0;
            this.txtRFID.Size = new System.Drawing.Size(194, 25);
            this.txtRFID.TabIndex = 14;
            this.txtRFID.Tag = "RFID...";
            this.txtRFID.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Hint = "Correo...";
            this.txtCorreo.Location = new System.Drawing.Point(252, 250);
            this.txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.Size = new System.Drawing.Size(198, 25);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Tag = "Correo...";
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono...";
            this.txtTelefono.Location = new System.Drawing.Point(252, 205);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(198, 25);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.Tag = "Teléfono...";
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // comboMunicipio
            // 
            this.comboMunicipio.FormattingEnabled = true;
            this.comboMunicipio.ItemHeight = 23;
            this.comboMunicipio.Location = new System.Drawing.Point(252, 158);
            this.comboMunicipio.Name = "comboMunicipio";
            this.comboMunicipio.Size = new System.Drawing.Size(198, 29);
            this.comboMunicipio.Style = MetroFramework.MetroColorStyle.Black;
            this.comboMunicipio.TabIndex = 11;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.ItemHeight = 23;
            this.comboEstado.Location = new System.Drawing.Point(252, 114);
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
            this.txtCP.Location = new System.Drawing.Point(252, 79);
            this.txtCP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '\0';
            this.txtCP.SelectedText = "";
            this.txtCP.SelectionLength = 0;
            this.txtCP.SelectionStart = 0;
            this.txtCP.Size = new System.Drawing.Size(111, 25);
            this.txtCP.TabIndex = 9;
            this.txtCP.Tag = "Código postal...";
            this.txtCP.UseSystemPasswordChar = false;
            // 
            // txtDirección
            // 
            this.txtDirección.Depth = 0;
            this.txtDirección.Hint = "Dirección...";
            this.txtDirección.Location = new System.Drawing.Point(252, 35);
            this.txtDirección.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.PasswordChar = '\0';
            this.txtDirección.SelectedText = "";
            this.txtDirección.SelectionLength = 0;
            this.txtDirección.SelectionStart = 0;
            this.txtDirección.Size = new System.Drawing.Size(247, 25);
            this.txtDirección.TabIndex = 8;
            this.txtDirección.Tag = "Dirección...";
            this.txtDirección.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 250);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 17);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Fecha nacimiento:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacimiento.Location = new System.Drawing.Point(17, 275);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(154, 24);
            this.dtNacimiento.TabIndex = 6;
            // 
            // txtAM
            // 
            this.txtAM.Depth = 0;
            this.txtAM.Hint = "Apellido materno...";
            this.txtAM.Location = new System.Drawing.Point(17, 153);
            this.txtAM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAM.Name = "txtAM";
            this.txtAM.PasswordChar = '\0';
            this.txtAM.SelectedText = "";
            this.txtAM.SelectionLength = 0;
            this.txtAM.SelectionStart = 0;
            this.txtAM.Size = new System.Drawing.Size(200, 25);
            this.txtAM.TabIndex = 3;
            this.txtAM.Tag = "Apellido materno...";
            this.txtAM.UseSystemPasswordChar = false;
            // 
            // txtAP
            // 
            this.txtAP.Depth = 0;
            this.txtAP.Hint = "Apellido paterno...";
            this.txtAP.Location = new System.Drawing.Point(17, 114);
            this.txtAP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAP.Name = "txtAP";
            this.txtAP.PasswordChar = '\0';
            this.txtAP.SelectedText = "";
            this.txtAP.SelectionLength = 0;
            this.txtAP.SelectionStart = 0;
            this.txtAP.Size = new System.Drawing.Size(200, 25);
            this.txtAP.TabIndex = 2;
            this.txtAP.Tag = "Apellido paterno...";
            this.txtAP.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre...";
            this.txtNombre.Location = new System.Drawing.Point(18, 79);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(201, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "Nombre...";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "Id empleado...";
            this.txtId.Location = new System.Drawing.Point(18, 41);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(200, 25);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "Id empleado...";
            this.txtId.UseSystemPasswordChar = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.BackgroundImage = global::Rubikranet.Properties.Resources.synchronize;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Location = new System.Drawing.Point(595, 316);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(658, 326);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(242, 25);
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
            this.comboCantidadReg.Location = new System.Drawing.Point(516, 320);
            this.comboCantidadReg.Name = "comboCantidadReg";
            this.comboCantidadReg.Size = new System.Drawing.Size(59, 29);
            this.comboCantidadReg.Style = MetroFramework.MetroColorStyle.Black;
            this.comboCantidadReg.TabIndex = 32;
            this.comboCantidadReg.SelectedIndexChanged += new System.EventHandler(this.comboCantidadReg_SelectedIndexChanged);
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalReg.Depth = 0;
            this.lblTotalReg.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalReg.Location = new System.Drawing.Point(455, 326);
            this.lblTotalReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(0, 17);
            this.lblTotalReg.TabIndex = 31;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(368, 326);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 17);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Registros: ";
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPag.Depth = 0;
            this.lblTotalPag.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPag.Location = new System.Drawing.Point(312, 326);
            this.lblTotalPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPag.TabIndex = 29;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(281, 326);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(24, 17);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPagActual.Depth = 0;
            this.lblPagActual.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblPagActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagActual.Location = new System.Drawing.Point(249, 326);
            this.lblPagActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(0, 17);
            this.lblPagActual.TabIndex = 27;
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(189, 326);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 17);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Página";
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimaPag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimaPag.BackgroundImage")));
            this.btnUltimaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimaPag.Location = new System.Drawing.Point(129, 316);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(40, 40);
            this.btnUltimaPag.TabIndex = 25;
            this.btnUltimaPag.TabStop = false;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(87, 316);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(41, 316);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimerPagina
            // 
            this.btnPrimerPagina.BackColor = System.Drawing.Color.Transparent;
            this.btnPrimerPagina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrimerPagina.BackgroundImage")));
            this.btnPrimerPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimerPagina.InitialImage = null;
            this.btnPrimerPagina.Location = new System.Drawing.Point(0, 316);
            this.btnPrimerPagina.Name = "btnPrimerPagina";
            this.btnPrimerPagina.Size = new System.Drawing.Size(40, 40);
            this.btnPrimerPagina.TabIndex = 22;
            this.btnPrimerPagina.TabStop = false;
            this.btnPrimerPagina.Click += new System.EventHandler(this.btnPrimerPagina_Click);
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
            this.tablaEmpleados.Location = new System.Drawing.Point(0, 428);
            this.tablaEmpleados.Name = "tablaEmpleados";
            this.tablaEmpleados.ReadOnly = true;
            this.tablaEmpleados.RowHeadersVisible = false;
            this.tablaEmpleados.Size = new System.Drawing.Size(987, 274);
            this.tablaEmpleados.TabIndex = 0;
            this.tablaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleados_CellContentClick);
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 500;
            this.timerCarga.Tick += new System.EventHandler(this.timerEmpleados_Tick);
            // 
            // timerActualiza
            // 
            this.timerActualiza.Interval = 500;
            this.timerActualiza.Tick += new System.EventHandler(this.timerActualiza_Tick);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel);
            this.Name = "Empleados";
            this.Size = new System.Drawing.Size(987, 702);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupHorario.ResumeLayout(false);
            this.groupHorario.PerformLayout();
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView tablaEmpleados;
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
        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.PictureBox btnRefrescar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private MetroFramework.Controls.MetroComboBox comboArea;
        private MetroFramework.Controls.MetroComboBox comboPrivilegio;
        private MetroFramework.Controls.MetroComboBox comboCargo;
        private MetroFramework.Controls.MetroComboBox comboEstatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRFID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MetroFramework.Controls.MetroComboBox comboMunicipio;
        private MetroFramework.Controls.MetroComboBox comboEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDirección;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private MaterialSkin.Controls.MaterialRadioButton radioSexo2;
        private MaterialSkin.Controls.MaterialRadioButton radioSexo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAM;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtDiaFin;
        private System.Windows.Forms.DateTimePicker dtDiaInicio;
        private MetroFramework.Controls.MetroComboBox comboTurnos;
        private MaterialSkin.Controls.MaterialCheckBox checkCambioId;
        private System.Windows.Forms.GroupBox groupHorario;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.Timer timerActualiza;
    }
}
