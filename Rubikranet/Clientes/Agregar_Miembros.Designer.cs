namespace Rubikranet.Clientes
{
    partial class Agregar_Miembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Miembros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.txtAM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMembreFam = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNum = new MaterialSkin.Controls.MaterialLabel();
            this.lblmiembros = new MaterialSkin.Controls.MaterialLabel();
            this.txtMembre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSexo2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioSexo = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioprice2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioprice = new MetroFramework.Controls.MetroRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtAM);
            this.panel1.Controls.Add(this.txtAP);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.txtMembreFam);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblmiembros);
            this.panel1.Controls.Add(this.txtMembre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 242);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "m";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(563, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Rubikranet.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(505, 190);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAM
            // 
            this.txtAM.BackColor = System.Drawing.Color.White;
            this.txtAM.Depth = 0;
            this.txtAM.Hint = "Apellido Materno";
            this.txtAM.Location = new System.Drawing.Point(304, 72);
            this.txtAM.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAM.Name = "txtAM";
            this.txtAM.PasswordChar = '\0';
            this.txtAM.SelectedText = "";
            this.txtAM.SelectionLength = 0;
            this.txtAM.SelectionStart = 0;
            this.txtAM.Size = new System.Drawing.Size(235, 25);
            this.txtAM.TabIndex = 12;
            this.txtAM.UseSystemPasswordChar = false;
            // 
            // txtAP
            // 
            this.txtAP.BackColor = System.Drawing.Color.White;
            this.txtAP.Depth = 0;
            this.txtAP.Hint = "Apellido Paterno";
            this.txtAP.Location = new System.Drawing.Point(16, 197);
            this.txtAP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAP.Name = "txtAP";
            this.txtAP.PasswordChar = '\0';
            this.txtAP.SelectedText = "";
            this.txtAP.SelectionLength = 0;
            this.txtAP.SelectionStart = 0;
            this.txtAP.Size = new System.Drawing.Size(235, 25);
            this.txtAP.TabIndex = 11;
            this.txtAP.UseSystemPasswordChar = false;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.Depth = 0;
            this.txtNombres.Hint = "Nombre(s)";
            this.txtNombres.Location = new System.Drawing.Point(15, 153);
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(235, 25);
            this.txtNombres.TabIndex = 10;
            this.txtNombres.UseSystemPasswordChar = false;
            // 
            // txtMembreFam
            // 
            this.txtMembreFam.BackColor = System.Drawing.Color.White;
            this.txtMembreFam.Depth = 0;
            this.txtMembreFam.Hint = "Membresia Familiar";
            this.txtMembreFam.Location = new System.Drawing.Point(15, 113);
            this.txtMembreFam.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMembreFam.Name = "txtMembreFam";
            this.txtMembreFam.PasswordChar = '\0';
            this.txtMembreFam.SelectedText = "";
            this.txtMembreFam.SelectionLength = 0;
            this.txtMembreFam.SelectionStart = 0;
            this.txtMembreFam.Size = new System.Drawing.Size(235, 25);
            this.txtMembreFam.TabIndex = 9;
            this.txtMembreFam.UseSystemPasswordChar = false;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Depth = 0;
            this.lblNum.Font = new System.Drawing.Font("Segoe WP Light", 11F);
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNum.Location = new System.Drawing.Point(463, 13);
            this.lblNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(76, 17);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Miembro #";
            // 
            // lblmiembros
            // 
            this.lblmiembros.AutoSize = true;
            this.lblmiembros.BackColor = System.Drawing.Color.White;
            this.lblmiembros.Depth = 0;
            this.lblmiembros.Font = new System.Drawing.Font("Segoe WP Light", 11F);
            this.lblmiembros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblmiembros.Location = new System.Drawing.Point(12, 13);
            this.lblmiembros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblmiembros.Name = "lblmiembros";
            this.lblmiembros.Size = new System.Drawing.Size(238, 17);
            this.lblmiembros.TabIndex = 7;
            this.lblmiembros.Text = "Puedes agregar hasta 5 miembros:";
            // 
            // txtMembre
            // 
            this.txtMembre.BackColor = System.Drawing.Color.White;
            this.txtMembre.Depth = 0;
            this.txtMembre.Hint = "Membresia";
            this.txtMembre.Location = new System.Drawing.Point(15, 72);
            this.txtMembre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMembre.Name = "txtMembre";
            this.txtMembre.PasswordChar = '\0';
            this.txtMembre.SelectedText = "";
            this.txtMembre.SelectionLength = 0;
            this.txtMembre.SelectionStart = 0;
            this.txtMembre.Size = new System.Drawing.Size(235, 25);
            this.txtMembre.TabIndex = 6;
            this.txtMembre.UseSystemPasswordChar = false;
            this.txtMembre.TextChanged += new System.EventHandler(this.txtMembre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSexo2);
            this.groupBox1.Controls.Add(this.radioSexo);
            this.groupBox1.Location = new System.Drawing.Point(304, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 35);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioSexo2
            // 
            this.radioSexo2.AutoSize = true;
            this.radioSexo2.Location = new System.Drawing.Point(118, 13);
            this.radioSexo2.Name = "radioSexo2";
            this.radioSexo2.Size = new System.Drawing.Size(76, 15);
            this.radioSexo2.TabIndex = 16;
            this.radioSexo2.TabStop = true;
            this.radioSexo2.Tag = "f";
            this.radioSexo2.Text = "Femenino";
            this.radioSexo2.UseVisualStyleBackColor = true;
            // 
            // radioSexo
            // 
            this.radioSexo.AutoSize = true;
            this.radioSexo.Location = new System.Drawing.Point(7, 13);
            this.radioSexo.Name = "radioSexo";
            this.radioSexo.Size = new System.Drawing.Size(78, 15);
            this.radioSexo.TabIndex = 15;
            this.radioSexo.TabStop = true;
            this.radioSexo.Tag = "m";
            this.radioSexo.Text = "Masculino";
            this.radioSexo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioprice2);
            this.groupBox2.Controls.Add(this.radioprice);
            this.groupBox2.Location = new System.Drawing.Point(304, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 35);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // radioprice2
            // 
            this.radioprice2.AutoSize = true;
            this.radioprice2.Location = new System.Drawing.Point(118, 13);
            this.radioprice2.Name = "radioprice2";
            this.radioprice2.Size = new System.Drawing.Size(58, 15);
            this.radioprice2.TabIndex = 16;
            this.radioprice2.TabStop = true;
            this.radioprice2.Tag = "1";
            this.radioprice2.Text = "Menor";
            this.radioprice2.UseVisualStyleBackColor = true;
            // 
            // radioprice
            // 
            this.radioprice.AutoSize = true;
            this.radioprice.Location = new System.Drawing.Point(7, 13);
            this.radioprice.Name = "radioprice";
            this.radioprice.Size = new System.Drawing.Size(59, 15);
            this.radioprice.TabIndex = 15;
            this.radioprice.TabStop = true;
            this.radioprice.Tag = "0";
            this.radioprice.Text = "Adulto";
            this.radioprice.UseVisualStyleBackColor = true;
            // 
            // Agregar_Miembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 305);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_Miembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Miembros";
            this.Load += new System.EventHandler(this.Agregar_Miembros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMembreFam;
        private MaterialSkin.Controls.MaterialLabel lblNum;
        private MaterialSkin.Controls.MaterialLabel lblmiembros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMembre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAM;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton radioSexo2;
        private MetroFramework.Controls.MetroRadioButton radioSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton radioprice2;
        private MetroFramework.Controls.MetroRadioButton radioprice;
    }
}