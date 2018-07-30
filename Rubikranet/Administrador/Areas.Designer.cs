namespace Rubikranet.Administrador
{
    partial class Areas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Areas));
            this.TablaAreas = new System.Windows.Forms.DataGridView();
            this.tabAreas = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.numActual = new MetroSet_UI.Controls.MetroSetNumeric();
            this.scrollActual = new MetroFramework.Controls.MetroTrackBar();
            this.numMaximo = new MetroSet_UI.Controls.MetroSetNumeric();
            this.scrollMaximo = new MetroFramework.Controls.MetroTrackBar();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioEstatus2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAccesibilidad2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAccesibilidad = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.txtNormas = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtHorario = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMensaje = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboCantidadReg = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalReg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalPag = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagActual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRefrescar = new System.Windows.Forms.PictureBox();
            this.btnUltimaPag = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.btnPrimerPagina = new System.Windows.Forms.PictureBox();
            this.timerActualiza = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAreas)).BeginInit();
            this.tabAreas.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaAreas
            // 
            this.TablaAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAreas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaAreas.Location = new System.Drawing.Point(0, 426);
            this.TablaAreas.Name = "TablaAreas";
            this.TablaAreas.Size = new System.Drawing.Size(934, 273);
            this.TablaAreas.TabIndex = 0;
            this.TablaAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaAreas_CellContentClick);
            // 
            // tabAreas
            // 
            this.tabAreas.Controls.Add(this.tabNuevo);
            this.tabAreas.Controls.Add(this.tabPage2);
            this.tabAreas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabAreas.ImageList = this.imageList;
            this.tabAreas.Location = new System.Drawing.Point(0, 0);
            this.tabAreas.Name = "tabAreas";
            this.tabAreas.SelectedIndex = 0;
            this.tabAreas.Size = new System.Drawing.Size(934, 314);
            this.tabAreas.TabIndex = 1;
            // 
            // tabNuevo
            // 
            this.tabNuevo.BackColor = System.Drawing.Color.White;
            this.tabNuevo.Controls.Add(this.materialLabel8);
            this.tabNuevo.Controls.Add(this.materialLabel7);
            this.tabNuevo.Controls.Add(this.numActual);
            this.tabNuevo.Controls.Add(this.scrollActual);
            this.tabNuevo.Controls.Add(this.numMaximo);
            this.tabNuevo.Controls.Add(this.scrollMaximo);
            this.tabNuevo.Controls.Add(this.btnCancelar);
            this.tabNuevo.Controls.Add(this.groupBox2);
            this.tabNuevo.Controls.Add(this.groupBox1);
            this.tabNuevo.Controls.Add(this.materialLabel3);
            this.tabNuevo.Controls.Add(this.materialLabel2);
            this.tabNuevo.Controls.Add(this.materialLabel1);
            this.tabNuevo.Controls.Add(this.btnGuardar);
            this.tabNuevo.Controls.Add(this.txtNormas);
            this.tabNuevo.Controls.Add(this.txtHorario);
            this.tabNuevo.Controls.Add(this.txtMensaje);
            this.tabNuevo.Controls.Add(this.txtNombre);
            this.tabNuevo.ImageIndex = 0;
            this.tabNuevo.Location = new System.Drawing.Point(4, 23);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(926, 287);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nueva/Actualiza áreas";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(18, 107);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(90, 17);
            this.materialLabel8.TabIndex = 47;
            this.materialLabel8.Text = "Cupo actual:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(18, 50);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(103, 17);
            this.materialLabel7.TabIndex = 46;
            this.materialLabel7.Text = "Cupo máximo:";
            // 
            // numActual
            // 
            this.numActual.BackColor = System.Drawing.Color.Transparent;
            this.numActual.BackgroundColor = System.Drawing.Color.Empty;
            this.numActual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numActual.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numActual.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.numActual.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.numActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numActual.Location = new System.Drawing.Point(216, 102);
            this.numActual.Maximum = 999;
            this.numActual.Minimum = 0;
            this.numActual.Name = "numActual";
            this.numActual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numActual.Size = new System.Drawing.Size(96, 26);
            this.numActual.Style = MetroSet_UI.Design.Style.Light;
            this.numActual.StyleManager = null;
            this.numActual.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numActual.TabIndex = 44;
            this.numActual.ThemeAuthor = "Narwin";
            this.numActual.ThemeName = "MetroLite";
            this.numActual.Value = 0;
            this.numActual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numActual_MouseClick);
            // 
            // scrollActual
            // 
            this.scrollActual.BackColor = System.Drawing.Color.Transparent;
            this.scrollActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollActual.Location = new System.Drawing.Point(21, 127);
            this.scrollActual.Maximum = 999;
            this.scrollActual.Name = "scrollActual";
            this.scrollActual.Size = new System.Drawing.Size(292, 23);
            this.scrollActual.Style = MetroFramework.MetroColorStyle.Blue;
            this.scrollActual.TabIndex = 45;
            this.scrollActual.Value = 0;
            this.scrollActual.ValueChanged += new System.EventHandler(this.scrollActual_ValueChanged);
            this.scrollActual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scrollActual_MouseUp);
            // 
            // numMaximo
            // 
            this.numMaximo.BackColor = System.Drawing.Color.Transparent;
            this.numMaximo.BackgroundColor = System.Drawing.Color.Empty;
            this.numMaximo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numMaximo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numMaximo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.numMaximo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.numMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numMaximo.Location = new System.Drawing.Point(216, 45);
            this.numMaximo.Maximum = 999;
            this.numMaximo.Minimum = 20;
            this.numMaximo.Name = "numMaximo";
            this.numMaximo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numMaximo.Size = new System.Drawing.Size(96, 26);
            this.numMaximo.Style = MetroSet_UI.Design.Style.Light;
            this.numMaximo.StyleManager = null;
            this.numMaximo.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numMaximo.TabIndex = 43;
            this.numMaximo.ThemeAuthor = "Narwin";
            this.numMaximo.ThemeName = "MetroLite";
            this.numMaximo.Value = 20;
            // 
            // scrollMaximo
            // 
            this.scrollMaximo.BackColor = System.Drawing.Color.Transparent;
            this.scrollMaximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollMaximo.LargeChange = 1;
            this.scrollMaximo.Location = new System.Drawing.Point(22, 70);
            this.scrollMaximo.Maximum = 999;
            this.scrollMaximo.Minimum = 20;
            this.scrollMaximo.Name = "scrollMaximo";
            this.scrollMaximo.Size = new System.Drawing.Size(292, 23);
            this.scrollMaximo.Style = MetroFramework.MetroColorStyle.Blue;
            this.scrollMaximo.TabIndex = 43;
            this.scrollMaximo.Value = 20;
            this.scrollMaximo.ValueChanged += new System.EventHandler(this.scrollMaximo_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(785, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioEstatus2);
            this.groupBox2.Controls.Add(this.radioEstatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 62);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estatus del área";
            // 
            // radioEstatus2
            // 
            this.radioEstatus2.AutoSize = true;
            this.radioEstatus2.Depth = 0;
            this.radioEstatus2.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioEstatus2.Location = new System.Drawing.Point(112, 23);
            this.radioEstatus2.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstatus2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstatus2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstatus2.Name = "radioEstatus2";
            this.radioEstatus2.Ripple = true;
            this.radioEstatus2.Size = new System.Drawing.Size(134, 30);
            this.radioEstatus2.TabIndex = 7;
            this.radioEstatus2.TabStop = true;
            this.radioEstatus2.Tag = "0";
            this.radioEstatus2.Text = "Fuera de servicio";
            this.radioEstatus2.UseVisualStyleBackColor = true;
            // 
            // radioEstatus
            // 
            this.radioEstatus.AutoSize = true;
            this.radioEstatus.Depth = 0;
            this.radioEstatus.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioEstatus.Location = new System.Drawing.Point(7, 23);
            this.radioEstatus.Margin = new System.Windows.Forms.Padding(0);
            this.radioEstatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEstatus.Name = "radioEstatus";
            this.radioEstatus.Ripple = true;
            this.radioEstatus.Size = new System.Drawing.Size(96, 30);
            this.radioEstatus.TabIndex = 6;
            this.radioEstatus.TabStop = true;
            this.radioEstatus.Tag = "1";
            this.radioEstatus.Text = "En servicio";
            this.radioEstatus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAccesibilidad2);
            this.groupBox1.Controls.Add(this.radioAccesibilidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 62);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accesibilidad del área";
            // 
            // radioAccesibilidad2
            // 
            this.radioAccesibilidad2.AutoSize = true;
            this.radioAccesibilidad2.Depth = 0;
            this.radioAccesibilidad2.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioAccesibilidad2.Location = new System.Drawing.Point(116, 20);
            this.radioAccesibilidad2.Margin = new System.Windows.Forms.Padding(0);
            this.radioAccesibilidad2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAccesibilidad2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAccesibilidad2.Name = "radioAccesibilidad2";
            this.radioAccesibilidad2.Ripple = true;
            this.radioAccesibilidad2.Size = new System.Drawing.Size(79, 30);
            this.radioAccesibilidad2.TabIndex = 9;
            this.radioAccesibilidad2.TabStop = true;
            this.radioAccesibilidad2.Tag = "1";
            this.radioAccesibilidad2.Text = "Familiar";
            this.radioAccesibilidad2.UseVisualStyleBackColor = true;
            // 
            // radioAccesibilidad
            // 
            this.radioAccesibilidad.AutoSize = true;
            this.radioAccesibilidad.Depth = 0;
            this.radioAccesibilidad.Font = new System.Drawing.Font("Segoe WP", 10F);
            this.radioAccesibilidad.Location = new System.Drawing.Point(7, 20);
            this.radioAccesibilidad.Margin = new System.Windows.Forms.Padding(0);
            this.radioAccesibilidad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAccesibilidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAccesibilidad.Name = "radioAccesibilidad";
            this.radioAccesibilidad.Ripple = true;
            this.radioAccesibilidad.Size = new System.Drawing.Size(76, 30);
            this.radioAccesibilidad.TabIndex = 8;
            this.radioAccesibilidad.TabStop = true;
            this.radioAccesibilidad.Tag = "0";
            this.radioAccesibilidad.Text = "Adultos";
            this.radioAccesibilidad.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(327, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(138, 17);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Horario descripción:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(619, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(120, 17);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Normas del área:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(327, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 17);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Mensaje para clientes:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(709, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNormas
            // 
            this.txtNormas.AutoCompleteCustomSource = null;
            this.txtNormas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNormas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNormas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNormas.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNormas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNormas.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNormas.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNormas.Image = null;
            this.txtNormas.Lines = null;
            this.txtNormas.Location = new System.Drawing.Point(622, 35);
            this.txtNormas.MaxLength = 32767;
            this.txtNormas.Multiline = true;
            this.txtNormas.Name = "txtNormas";
            this.txtNormas.ReadOnly = false;
            this.txtNormas.Size = new System.Drawing.Size(289, 202);
            this.txtNormas.Style = MetroSet_UI.Design.Style.Light;
            this.txtNormas.StyleManager = null;
            this.txtNormas.TabIndex = 5;
            this.txtNormas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNormas.ThemeAuthor = "Narwin";
            this.txtNormas.ThemeName = "MetroLite";
            this.txtNormas.UseSystemPasswordChar = false;
            this.txtNormas.WatermarkText = "";
            // 
            // txtHorario
            // 
            this.txtHorario.AutoCompleteCustomSource = null;
            this.txtHorario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHorario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHorario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtHorario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtHorario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtHorario.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHorario.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtHorario.Image = null;
            this.txtHorario.Lines = null;
            this.txtHorario.Location = new System.Drawing.Point(330, 35);
            this.txtHorario.MaxLength = 32767;
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = false;
            this.txtHorario.Size = new System.Drawing.Size(277, 93);
            this.txtHorario.Style = MetroSet_UI.Design.Style.Light;
            this.txtHorario.StyleManager = null;
            this.txtHorario.TabIndex = 2;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHorario.ThemeAuthor = "Narwin";
            this.txtHorario.ThemeName = "MetroLite";
            this.txtHorario.UseSystemPasswordChar = false;
            this.txtHorario.WatermarkText = "";
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoCompleteCustomSource = null;
            this.txtMensaje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMensaje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMensaje.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMensaje.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMensaje.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMensaje.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMensaje.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMensaje.Image = null;
            this.txtMensaje.Lines = null;
            this.txtMensaje.Location = new System.Drawing.Point(330, 153);
            this.txtMensaje.MaxLength = 32767;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = false;
            this.txtMensaje.Size = new System.Drawing.Size(277, 125);
            this.txtMensaje.Style = MetroSet_UI.Design.Style.Light;
            this.txtMensaje.StyleManager = null;
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMensaje.ThemeAuthor = "Narwin";
            this.txtMensaje.ThemeName = "MetroLite";
            this.txtMensaje.UseSystemPasswordChar = false;
            this.txtMensaje.WatermarkText = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre...";
            this.txtNombre.Location = new System.Drawing.Point(21, 14);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(291, 25);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "Nombre...";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otro...";
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 500;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
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
            this.txtBuscar.Size = new System.Drawing.Size(242, 25);
            this.txtBuscar.TabIndex = 42;
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
            this.comboCantidadReg.TabIndex = 41;
            this.comboCantidadReg.SelectedIndexChanged += new System.EventHandler(this.comboCantidadReg_SelectedIndexChanged);
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalReg.Depth = 0;
            this.lblTotalReg.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalReg.Location = new System.Drawing.Point(459, 326);
            this.lblTotalReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(0, 17);
            this.lblTotalReg.TabIndex = 40;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(372, 326);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 17);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Registros: ";
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPag.Depth = 0;
            this.lblTotalPag.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblTotalPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPag.Location = new System.Drawing.Point(316, 326);
            this.lblTotalPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPag.TabIndex = 38;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(285, 326);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(24, 17);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "de";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPagActual.Depth = 0;
            this.lblPagActual.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.lblPagActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagActual.Location = new System.Drawing.Point(253, 326);
            this.lblPagActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(0, 17);
            this.lblPagActual.TabIndex = 36;
            this.lblPagActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(193, 326);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(53, 17);
            this.materialLabel5.TabIndex = 35;
            this.materialLabel5.Text = "Página";
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
            this.btnRefrescar.TabIndex = 34;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
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
            this.btnUltimaPag.TabIndex = 29;
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
            this.btnSiguiente.TabIndex = 28;
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
            this.btnAnterior.TabIndex = 27;
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
            this.btnPrimerPagina.TabIndex = 26;
            this.btnPrimerPagina.TabStop = false;
            this.btnPrimerPagina.Click += new System.EventHandler(this.btnPrimerPagina_Click);
            // 
            // timerActualiza
            // 
            this.timerActualiza.Interval = 500;
            this.timerActualiza.Tick += new System.EventHandler(this.timerActualiza_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "home.png");
            this.imageList.Images.SetKeyName(1, "stats_pie_chart.png");
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Controls.Add(this.tabAreas);
            this.Controls.Add(this.TablaAreas);
            this.Name = "Areas";
            this.Size = new System.Drawing.Size(934, 699);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAreas)).EndInit();
            this.tabAreas.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimaPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimerPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaAreas;
        private System.Windows.Forms.TabControl tabAreas;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timerCarga;
        private MaterialSkin.Controls.MaterialRadioButton radioAccesibilidad2;
        private MaterialSkin.Controls.MaterialRadioButton radioAccesibilidad;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus2;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus;
        private MetroSet_UI.Controls.MetroSetTextBox txtNormas;
        private MetroSet_UI.Controls.MetroSetTextBox txtHorario;
        private MetroSet_UI.Controls.MetroSetTextBox txtMensaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.PictureBox btnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnUltimaPag;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox btnPrimerPagina;
        private System.Windows.Forms.PictureBox btnRefrescar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MetroFramework.Controls.MetroComboBox comboCantidadReg;
        private MaterialSkin.Controls.MaterialLabel lblTotalReg;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblTotalPag;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblPagActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Timer timerActualiza;
        private MetroFramework.Controls.MetroTrackBar scrollMaximo;
        private MetroSet_UI.Controls.MetroSetNumeric numMaximo;
        private MetroSet_UI.Controls.MetroSetNumeric numActual;
        private MetroFramework.Controls.MetroTrackBar scrollActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ImageList imageList;
    }
}
