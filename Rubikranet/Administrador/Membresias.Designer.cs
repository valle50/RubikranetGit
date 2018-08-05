namespace Rubikranet.Administrador
{
    partial class Membresias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresias));
            this.TablaMem = new System.Windows.Forms.DataGridView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
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
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.timerActualiza = new System.Windows.Forms.Timer(this.components);
            this.tabCategorias = new MetroSet_UI.Controls.MetroSetTabControl();
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboPromocion = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEstatus2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.numIVA = new MetroSet_UI.Controls.MetroSetNumeric();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblIVA = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecioPromo = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).BeginInit();
            this.tabCategorias.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaMem
            // 
            this.TablaMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaMem.Location = new System.Drawing.Point(0, 426);
            this.TablaMem.Name = "TablaMem";
            this.TablaMem.Size = new System.Drawing.Size(934, 273);
            this.TablaMem.TabIndex = 0;
            this.TablaMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMem_CellContentClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.BackgroundImage = global::Rubikranet.Properties.Resources.synchronize;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Location = new System.Drawing.Point(600, 316);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescar.TabIndex = 47;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar...";
            this.txtBuscar.Location = new System.Drawing.Point(663, 326);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(242, 23);
            this.txtBuscar.TabIndex = 55;
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
            this.comboCantidadReg.Location = new System.Drawing.Point(521, 320);
            this.comboCantidadReg.Name = "comboCantidadReg";
            this.comboCantidadReg.Size = new System.Drawing.Size(59, 29);
            this.comboCantidadReg.Style = MetroFramework.MetroColorStyle.Black;
            this.comboCantidadReg.TabIndex = 54;
            this.comboCantidadReg.SelectedIndexChanged += new System.EventHandler(this.comboCantidadReg_SelectedIndexChanged);
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalReg.Depth = 0;
            this.lblTotalReg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalReg.Location = new System.Drawing.Point(460, 326);
            this.lblTotalReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(0, 19);
            this.lblTotalReg.TabIndex = 53;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(373, 326);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 52;
            this.materialLabel6.Text = "Registros: ";
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPag.Depth = 0;
            this.lblTotalPag.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPag.Location = new System.Drawing.Point(317, 326);
            this.lblTotalPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(0, 19);
            this.lblTotalPag.TabIndex = 51;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(286, 326);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(25, 19);
            this.materialLabel4.TabIndex = 50;
            this.materialLabel4.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPagActual.Depth = 0;
            this.lblPagActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPagActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagActual.Location = new System.Drawing.Point(254, 326);
            this.lblPagActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(0, 19);
            this.lblPagActual.TabIndex = 49;
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(194, 326);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Página";
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimaPag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimaPag.BackgroundImage")));
            this.btnUltimaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimaPag.Location = new System.Drawing.Point(133, 316);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(40, 40);
            this.btnUltimaPag.TabIndex = 46;
            this.btnUltimaPag.TabStop = false;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(91, 316);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 45;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Location = new System.Drawing.Point(45, 316);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 44;
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
            this.btnPrimerPagina.Location = new System.Drawing.Point(4, 316);
            this.btnPrimerPagina.Name = "btnPrimerPagina";
            this.btnPrimerPagina.Size = new System.Drawing.Size(40, 40);
            this.btnPrimerPagina.TabIndex = 43;
            this.btnPrimerPagina.TabStop = false;
            this.btnPrimerPagina.Click += new System.EventHandler(this.btnPrimerPagina_Click);
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
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.metroSetTabPage1);
            this.tabCategorias.Controls.Add(this.metroSetTabPage2);
            this.tabCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCategorias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCategorias.HotTrack = true;
            this.tabCategorias.ImageList = this.imageList;
            this.tabCategorias.ItemSize = new System.Drawing.Size(100, 38);
            this.tabCategorias.Location = new System.Drawing.Point(0, 0);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.SelectedIndex = 0;
            this.tabCategorias.Size = new System.Drawing.Size(934, 314);
            this.tabCategorias.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCategorias.Speed = 80;
            this.tabCategorias.Style = MetroSet_UI.Design.Style.Light;
            this.tabCategorias.StyleManager = null;
            this.tabCategorias.TabIndex = 4;
            this.tabCategorias.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.tabCategorias.ThemeAuthor = "Narwin";
            this.tabCategorias.ThemeName = "MetroLite";
            this.tabCategorias.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage1.Controls.Add(this.panel1);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = "home.png";
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(926, 268);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "Nuevo/actualiza categorías";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroLite";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPrecioPromo);
            this.panel1.Controls.Add(this.lblIVA);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.comboCategoria);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.metroSetDivider1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.numIVA);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comboPromocion);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 268);
            this.panel1.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre de categoría...";
            this.txtNombre.Location = new System.Drawing.Point(17, 16);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(227, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "Nombre de categoría...";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(650, 0);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(276, 268);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(926, 268);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabPage2.StyleManager = null;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "metroSetTabPage2";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroLite";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "Precio...";
            this.txtPrecio.Location = new System.Drawing.Point(17, 72);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(169, 23);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.Tag = "Precio...";
            this.txtPrecio.UseSystemPasswordChar = false;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // comboPromocion
            // 
            this.comboPromocion.FormattingEnabled = true;
            this.comboPromocion.ItemHeight = 23;
            this.comboPromocion.Location = new System.Drawing.Point(17, 123);
            this.comboPromocion.Name = "comboPromocion";
            this.comboPromocion.Size = new System.Drawing.Size(227, 29);
            this.comboPromocion.TabIndex = 4;
            this.comboPromocion.SelectedIndexChanged += new System.EventHandler(this.comboPromocion_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEstatus2);
            this.groupBox1.Controls.Add(this.radioEstatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus de categoría";
            // 
            // radioEstatus
            // 
            this.radioEstatus.AutoSize = true;
            this.radioEstatus.Depth = 0;
            this.radioEstatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioEstatus.Location = new System.Drawing.Point(3, 20);
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
            this.radioEstatus2.Location = new System.Drawing.Point(86, 20);
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
            // numIVA
            // 
            this.numIVA.BackColor = System.Drawing.Color.Transparent;
            this.numIVA.BackgroundColor = System.Drawing.Color.Empty;
            this.numIVA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numIVA.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numIVA.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.numIVA.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.numIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numIVA.Location = new System.Drawing.Point(285, 123);
            this.numIVA.Maximum = 100;
            this.numIVA.Minimum = 0;
            this.numIVA.Name = "numIVA";
            this.numIVA.Size = new System.Drawing.Size(75, 26);
            this.numIVA.Style = MetroSet_UI.Design.Style.Light;
            this.numIVA.StyleManager = null;
            this.numIVA.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numIVA.TabIndex = 6;
            this.numIVA.ThemeAuthor = "Narwin";
            this.numIVA.ThemeName = "MetroLite";
            this.numIVA.Value = 0;
            this.numIVA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numIVA_MouseClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(281, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "IVA:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(327, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(269, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.Location = new System.Drawing.Point(407, 22);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider1.Size = new System.Drawing.Size(4, 220);
            this.metroSetDivider1.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 26;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLite";
            this.metroSetDivider1.Thickness = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(419, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(200, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Asignación de accesibilidad:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.ItemHeight = 23;
            this.comboCategoria.Location = new System.Drawing.Point(423, 125);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(169, 29);
            this.comboCategoria.TabIndex = 28;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(423, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(196, 59);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Seleccione la categoría para\r\nasignar la accesibilidad que\r\nésta tendrá a las áre" +
    "as.";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(281, 162);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Precio total:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(281, 16);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(86, 38);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Precio por \r\npromoción:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.SystemColors.Info;
            this.lblIVA.Depth = 0;
            this.lblIVA.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIVA.Location = new System.Drawing.Point(319, 101);
            this.lblIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(25, 19);
            this.lblIVA.TabIndex = 32;
            this.lblIVA.Text = "$0";
            // 
            // lblPrecioPromo
            // 
            this.lblPrecioPromo.AutoSize = true;
            this.lblPrecioPromo.BackColor = System.Drawing.SystemColors.Info;
            this.lblPrecioPromo.Depth = 0;
            this.lblPrecioPromo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecioPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecioPromo.Location = new System.Drawing.Point(284, 61);
            this.lblPrecioPromo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioPromo.Name = "lblPrecioPromo";
            this.lblPrecioPromo.Size = new System.Drawing.Size(25, 19);
            this.lblPrecioPromo.TabIndex = 33;
            this.lblPrecioPromo.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(284, 183);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 19);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "$0";
            // 
            // Membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabCategorias);
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
            this.Controls.Add(this.TablaMem);
            this.Name = "Membresias";
            this.Size = new System.Drawing.Size(934, 699);
            ((System.ComponentModel.ISupportInitialize)(this.TablaMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).EndInit();
            this.tabCategorias.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaMem;
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
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.Timer timerActualiza;
        private MetroSet_UI.Controls.MetroSetTabControl tabCategorias;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MetroFramework.Controls.MetroComboBox comboPromocion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus2;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus;
        private MetroSet_UI.Controls.MetroSetNumeric numIVA;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblPrecioPromo;
        private MaterialSkin.Controls.MaterialLabel lblIVA;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
