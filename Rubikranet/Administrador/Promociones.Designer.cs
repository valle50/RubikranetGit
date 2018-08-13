namespace Rubikranet.Administrador
{
    partial class Promociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promociones));
            this.btnRefrescar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboCantidadReg = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalReg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalPag = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagActual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUltimaPag = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.btnPrimerPagina = new System.Windows.Forms.PictureBox();
            this.TablaProm = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDesc = new MetroSet_UI.Controls.MetroSetTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.numPorcentaje = new MetroSet_UI.Controls.MetroSetNumeric();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.GroupEstatusPromo = new System.Windows.Forms.GroupBox();
            this.radioEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEstatus2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.timerActualiza = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProm)).BeginInit();
            this.panel.SuspendLayout();
            this.GroupEstatusPromo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.BackgroundImage = global::Rubikranet.Properties.Resources.synchronize;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Location = new System.Drawing.Point(599, 316);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescar.TabIndex = 60;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(662, 326);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(242, 23);
            this.txtBuscar.TabIndex = 68;
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
            this.comboCantidadReg.Location = new System.Drawing.Point(520, 320);
            this.comboCantidadReg.Name = "comboCantidadReg";
            this.comboCantidadReg.Size = new System.Drawing.Size(59, 29);
            this.comboCantidadReg.Style = MetroFramework.MetroColorStyle.Black;
            this.comboCantidadReg.TabIndex = 67;
            this.comboCantidadReg.SelectedIndexChanged += new System.EventHandler(this.comboCantidadReg_SelectedIndexChanged);
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalReg.Depth = 0;
            this.lblTotalReg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalReg.Location = new System.Drawing.Point(459, 326);
            this.lblTotalReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(0, 19);
            this.lblTotalReg.TabIndex = 66;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(372, 326);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 65;
            this.materialLabel6.Text = "Registros: ";
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPag.Depth = 0;
            this.lblTotalPag.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPag.Location = new System.Drawing.Point(316, 326);
            this.lblTotalPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(0, 19);
            this.lblTotalPag.TabIndex = 64;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(285, 326);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(25, 19);
            this.materialLabel4.TabIndex = 63;
            this.materialLabel4.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPagActual.Depth = 0;
            this.lblPagActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPagActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagActual.Location = new System.Drawing.Point(253, 326);
            this.lblPagActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(0, 19);
            this.lblPagActual.TabIndex = 62;
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(193, 326);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 61;
            this.materialLabel5.Text = "Página";
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimaPag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimaPag.BackgroundImage")));
            this.btnUltimaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimaPag.Location = new System.Drawing.Point(132, 316);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(40, 40);
            this.btnUltimaPag.TabIndex = 59;
            this.btnUltimaPag.TabStop = false;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(90, 316);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 58;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(44, 316);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 57;
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
            this.btnPrimerPagina.Location = new System.Drawing.Point(3, 316);
            this.btnPrimerPagina.Name = "btnPrimerPagina";
            this.btnPrimerPagina.Size = new System.Drawing.Size(40, 40);
            this.btnPrimerPagina.TabIndex = 56;
            this.btnPrimerPagina.TabStop = false;
            this.btnPrimerPagina.Click += new System.EventHandler(this.btnPrimerPagina_Click);
            // 
            // TablaProm
            // 
            this.TablaProm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaProm.Location = new System.Drawing.Point(0, 426);
            this.TablaProm.Name = "TablaProm";
            this.TablaProm.Size = new System.Drawing.Size(934, 273);
            this.TablaProm.TabIndex = 69;
            this.TablaProm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProm_CellContentClick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnGuardar);
            this.panel.Controls.Add(this.btnCancelar);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.GroupEstatusPromo);
            this.panel.Controls.Add(this.materialLabel3);
            this.panel.Controls.Add(this.materialLabel2);
            this.panel.Controls.Add(this.numPorcentaje);
            this.panel.Controls.Add(this.materialLabel1);
            this.panel.Controls.Add(this.txtDesc);
            this.panel.Controls.Add(this.txtNombre);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(934, 314);
            this.panel.TabIndex = 70;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre...";
            this.txtNombre.Location = new System.Drawing.Point(22, 17);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(270, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "Nombre...";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDesc
            // 
            this.txtDesc.AutoCompleteCustomSource = null;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDesc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDesc.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDesc.Image = null;
            this.txtDesc.Lines = null;
            this.txtDesc.Location = new System.Drawing.Point(21, 76);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.Size = new System.Drawing.Size(340, 225);
            this.txtDesc.Style = MetroSet_UI.Design.Style.Light;
            this.txtDesc.StyleManager = null;
            this.txtDesc.TabIndex = 1;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.ThemeAuthor = "Narwin";
            this.txtDesc.ThemeName = "MetroLite";
            this.txtDesc.UseSystemPasswordChar = false;
            this.txtDesc.WatermarkText = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Descripción de promoción:";
            // 
            // numPorcentaje
            // 
            this.numPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.numPorcentaje.BackgroundColor = System.Drawing.Color.Empty;
            this.numPorcentaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numPorcentaje.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numPorcentaje.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.numPorcentaje.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.numPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numPorcentaje.Location = new System.Drawing.Point(385, 47);
            this.numPorcentaje.Maximum = 100;
            this.numPorcentaje.Minimum = 0;
            this.numPorcentaje.Name = "numPorcentaje";
            this.numPorcentaje.Size = new System.Drawing.Size(75, 26);
            this.numPorcentaje.Style = MetroSet_UI.Design.Style.Light;
            this.numPorcentaje.StyleManager = null;
            this.numPorcentaje.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numPorcentaje.TabIndex = 3;
            this.numPorcentaje.Text = "metroSetNumeric1";
            this.numPorcentaje.ThemeAuthor = "Narwin";
            this.numPorcentaje.ThemeName = "MetroLite";
            this.numPorcentaje.Value = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(381, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(179, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Porcentaje de descuento:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(466, 49);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(20, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "%";
            // 
            // GroupEstatusPromo
            // 
            this.GroupEstatusPromo.Controls.Add(this.radioEstatus2);
            this.GroupEstatusPromo.Controls.Add(this.radioEstatus);
            this.GroupEstatusPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupEstatusPromo.Location = new System.Drawing.Point(385, 94);
            this.GroupEstatusPromo.Name = "GroupEstatusPromo";
            this.GroupEstatusPromo.Size = new System.Drawing.Size(200, 100);
            this.GroupEstatusPromo.TabIndex = 6;
            this.GroupEstatusPromo.TabStop = false;
            this.GroupEstatusPromo.Text = "Estatus de promoción";
            // 
            // radioEstatus
            // 
            this.radioEstatus.AutoSize = true;
            this.radioEstatus.Depth = 0;
            this.radioEstatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioEstatus.Location = new System.Drawing.Point(15, 42);
            this.radioEstatus.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstatus.Name = "radioEstatus";
            this.radioEstatus.Ripple = true;
            this.radioEstatus.Size = new System.Drawing.Size(68, 30);
            this.radioEstatus.TabIndex = 0;
            this.radioEstatus.TabStop = true;
            this.radioEstatus.Tag = "1";
            this.radioEstatus.Text = "Activo";
            this.radioEstatus.UseVisualStyleBackColor = true;
            // 
            // radioEstatus2
            // 
            this.radioEstatus2.AutoSize = true;
            this.radioEstatus2.Depth = 0;
            this.radioEstatus2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioEstatus2.Location = new System.Drawing.Point(106, 42);
            this.radioEstatus2.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstatus2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstatus2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstatus2.Name = "radioEstatus2";
            this.radioEstatus2.Ripple = true;
            this.radioEstatus2.Size = new System.Drawing.Size(78, 30);
            this.radioEstatus2.TabIndex = 1;
            this.radioEstatus2.TabStop = true;
            this.radioEstatus2.Tag = "0";
            this.radioEstatus2.Text = "Inactivo";
            this.radioEstatus2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.dtFin);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(599, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vigencia de promoción";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(10, 55);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 24);
            this.dtInicio.TabIndex = 0;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(10, 121);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 24);
            this.dtFin.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 28);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(114, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Fecha de inicio:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 93);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(94, 19);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "Fecha de fin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(230, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 69);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(589, 238);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(659, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 500;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // timerActualiza
            // 
            this.timerActualiza.Interval = 500;
            this.timerActualiza.Tick += new System.EventHandler(this.timerActualiza_Tick);
            // 
            // Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.TablaProm);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.comboCantidadReg);
            this.Controls.Add(this.lblTotalReg);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblTotalPag);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblPagActual);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnUltimaPag);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerPagina);
            this.Name = "Promociones";
            this.Size = new System.Drawing.Size(934, 699);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProm)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.GroupEstatusPromo.ResumeLayout(false);
            this.GroupEstatusPromo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRefrescar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MetroFramework.Controls.MetroComboBox comboCantidadReg;
        private MaterialSkin.Controls.MaterialLabel lblTotalReg;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblTotalPag;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblPagActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox btnUltimaPag;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox btnPrimerPagina;
        private System.Windows.Forms.DataGridView TablaProm;
        private System.Windows.Forms.Panel panel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MetroSet_UI.Controls.MetroSetTextBox txtDesc;
        private System.Windows.Forms.GroupBox GroupEstatusPromo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroSet_UI.Controls.MetroSetNumeric numPorcentaje;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus2;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.Timer timerActualiza;
    }
}
