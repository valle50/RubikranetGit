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
            this.TablaAreas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMensaje = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtNormas = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMaximo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtActual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHorario = new MetroSet_UI.Controls.MetroSetTextBox();
            this.radioEstatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEstatus2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAccesibilidad2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAccesibilidad = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAreas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaAreas
            // 
            this.TablaAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAreas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaAreas.Location = new System.Drawing.Point(0, 308);
            this.TablaAreas.Name = "TablaAreas";
            this.TablaAreas.Size = new System.Drawing.Size(910, 276);
            this.TablaAreas.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 257);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.radioAccesibilidad2);
            this.tabPage1.Controls.Add(this.radioAccesibilidad);
            this.tabPage1.Controls.Add(this.radioEstatus2);
            this.tabPage1.Controls.Add(this.radioEstatus);
            this.tabPage1.Controls.Add(this.txtHorario);
            this.tabPage1.Controls.Add(this.txtActual);
            this.tabPage1.Controls.Add(this.txtMaximo);
            this.tabPage1.Controls.Add(this.txtNormas);
            this.tabPage1.Controls.Add(this.txtMensaje);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 500;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre...";
            this.txtNombre.Location = new System.Drawing.Point(15, 14);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(287, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "Nombre...";
            this.txtNombre.UseSystemPasswordChar = false;
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
            this.txtMensaje.Location = new System.Drawing.Point(15, 61);
            this.txtMensaje.MaxLength = 32767;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = false;
            this.txtMensaje.Size = new System.Drawing.Size(287, 78);
            this.txtMensaje.Style = MetroSet_UI.Design.Style.Light;
            this.txtMensaje.StyleManager = null;
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMensaje.ThemeAuthor = "Narwin";
            this.txtMensaje.ThemeName = "MetroLite";
            this.txtMensaje.UseSystemPasswordChar = false;
            this.txtMensaje.WatermarkText = "";
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
            this.txtNormas.Location = new System.Drawing.Point(325, 142);
            this.txtNormas.MaxLength = 32767;
            this.txtNormas.Multiline = true;
            this.txtNormas.Name = "txtNormas";
            this.txtNormas.ReadOnly = false;
            this.txtNormas.Size = new System.Drawing.Size(287, 78);
            this.txtNormas.Style = MetroSet_UI.Design.Style.Light;
            this.txtNormas.StyleManager = null;
            this.txtNormas.TabIndex = 2;
            this.txtNormas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNormas.ThemeAuthor = "Narwin";
            this.txtNormas.ThemeName = "MetroLite";
            this.txtNormas.UseSystemPasswordChar = false;
            this.txtNormas.WatermarkText = "";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Depth = 0;
            this.txtMaximo.Hint = "Cupo máximo...";
            this.txtMaximo.Location = new System.Drawing.Point(16, 150);
            this.txtMaximo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.PasswordChar = '\0';
            this.txtMaximo.SelectedText = "";
            this.txtMaximo.SelectionLength = 0;
            this.txtMaximo.SelectionStart = 0;
            this.txtMaximo.Size = new System.Drawing.Size(286, 23);
            this.txtMaximo.TabIndex = 3;
            this.txtMaximo.Tag = "Cupo máximo...";
            this.txtMaximo.UseSystemPasswordChar = false;
            // 
            // txtActual
            // 
            this.txtActual.Depth = 0;
            this.txtActual.Hint = "Cupo actual...";
            this.txtActual.Location = new System.Drawing.Point(16, 191);
            this.txtActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '\0';
            this.txtActual.SelectedText = "";
            this.txtActual.SelectionLength = 0;
            this.txtActual.SelectionStart = 0;
            this.txtActual.Size = new System.Drawing.Size(286, 23);
            this.txtActual.TabIndex = 4;
            this.txtActual.Tag = "Cupo actual...";
            this.txtActual.UseSystemPasswordChar = false;
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
            this.txtHorario.Location = new System.Drawing.Point(325, 38);
            this.txtHorario.MaxLength = 32767;
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = false;
            this.txtHorario.Size = new System.Drawing.Size(287, 78);
            this.txtHorario.Style = MetroSet_UI.Design.Style.Light;
            this.txtHorario.StyleManager = null;
            this.txtHorario.TabIndex = 5;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHorario.ThemeAuthor = "Narwin";
            this.txtHorario.ThemeName = "MetroLite";
            this.txtHorario.UseSystemPasswordChar = false;
            this.txtHorario.WatermarkText = "";
            // 
            // radioEstatus
            // 
            this.radioEstatus.AutoSize = true;
            this.radioEstatus.Depth = 0;
            this.radioEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioEstatus.Location = new System.Drawing.Point(646, 198);
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
            // radioEstatus2
            // 
            this.radioEstatus2.AutoSize = true;
            this.radioEstatus2.Depth = 0;
            this.radioEstatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioEstatus2.Location = new System.Drawing.Point(751, 191);
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
            // radioAccesibilidad2
            // 
            this.radioAccesibilidad2.AutoSize = true;
            this.radioAccesibilidad2.Depth = 0;
            this.radioAccesibilidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioAccesibilidad2.Location = new System.Drawing.Point(724, 35);
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
            this.radioAccesibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioAccesibilidad.Location = new System.Drawing.Point(615, 35);
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
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Rubikranet.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(780, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(712, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(151, 18);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Mensaje para clientes";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(321, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(120, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Normas del área";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(321, 120);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Horario descripción:";
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TablaAreas);
            this.Name = "Areas";
            this.Size = new System.Drawing.Size(910, 584);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAreas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaAreas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timerCarga;
        private MaterialSkin.Controls.MaterialRadioButton radioAccesibilidad2;
        private MaterialSkin.Controls.MaterialRadioButton radioAccesibilidad;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus2;
        private MaterialSkin.Controls.MaterialRadioButton radioEstatus;
        private MetroSet_UI.Controls.MetroSetTextBox txtHorario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtActual;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaximo;
        private MetroSet_UI.Controls.MetroSetTextBox txtNormas;
        private MetroSet_UI.Controls.MetroSetTextBox txtMensaje;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
