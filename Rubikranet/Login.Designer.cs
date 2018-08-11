namespace Rubikranet
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAcceder = new System.Windows.Forms.PictureBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_RFID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_NIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe WP SemiLight", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(326, 45);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Utiliza tu tarjeta RFID y tu NIP para acceder al panel de administración";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceder.Image")));
            this.btnAcceder.Location = new System.Drawing.Point(200, 219);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(45, 45);
            this.btnAcceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.TabStop = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(200, 265);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(67, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 4;
            this.metroSetLabel1.Text = "Validar";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe WP SemiLight", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(29, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 17);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "RFID :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe WP SemiLight", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(32, 180);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(43, 17);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "PIN : ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(134, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(124, 265);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(75, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 10;
            this.metroSetLabel2.Text = "Cancelar";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_NIP);
            this.panel1.Controls.Add(this.txt_RFID);
            this.panel1.Location = new System.Drawing.Point(78, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 94);
            this.panel1.TabIndex = 11;
            // 
            // txt_RFID
            // 
            this.txt_RFID.Depth = 0;
            this.txt_RFID.Enabled = false;
            this.txt_RFID.Hint = "";
            this.txt_RFID.Location = new System.Drawing.Point(7, 21);
            this.txt_RFID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_RFID.Name = "txt_RFID";
            this.txt_RFID.PasswordChar = '\0';
            this.txt_RFID.SelectedText = "";
            this.txt_RFID.SelectionLength = 0;
            this.txt_RFID.SelectionStart = 0;
            this.txt_RFID.Size = new System.Drawing.Size(254, 25);
            this.txt_RFID.TabIndex = 0;
            this.txt_RFID.UseSystemPasswordChar = false;
            // 
            // txt_NIP
            // 
            this.txt_NIP.Depth = 0;
            this.txt_NIP.Hint = "";
            this.txt_NIP.Location = new System.Drawing.Point(7, 61);
            this.txt_NIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_NIP.Name = "txt_NIP";
            this.txt_NIP.PasswordChar = '*';
            this.txt_NIP.SelectedText = "";
            this.txt_NIP.SelectionLength = 0;
            this.txt_NIP.SelectionStart = 0;
            this.txt_NIP.Size = new System.Drawing.Size(254, 25);
            this.txt_NIP.TabIndex = 1;
            this.txt_NIP.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(380, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 293);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificación de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnAcceder;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox btnCancelar;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_NIP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_RFID;
    }
}