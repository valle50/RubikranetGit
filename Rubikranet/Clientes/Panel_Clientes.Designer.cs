namespace Rubikranet.Clientes
{
    partial class Panel_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Clientes));
            this.panelclientes = new System.Windows.Forms.Panel();
            this.btnclientes = new System.Windows.Forms.PictureBox();
            this.membresias = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbUsuario = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresias)).BeginInit();
            this.SuspendLayout();
            // 
            // panelclientes
            // 
            this.panelclientes.Location = new System.Drawing.Point(0, 63);
            this.panelclientes.MaximumSize = new System.Drawing.Size(910, 521);
            this.panelclientes.MinimumSize = new System.Drawing.Size(910, 521);
            this.panelclientes.Name = "panelclientes";
            this.panelclientes.Size = new System.Drawing.Size(910, 521);
            this.panelclientes.TabIndex = 3;
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.Location = new System.Drawing.Point(3, 3);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(65, 57);
            this.btnclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclientes.TabIndex = 4;
            this.btnclientes.TabStop = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // membresias
            // 
            this.membresias.BackColor = System.Drawing.Color.Transparent;
            this.membresias.Image = ((System.Drawing.Image)(resources.GetObject("membresias.Image")));
            this.membresias.Location = new System.Drawing.Point(74, 3);
            this.membresias.Name = "membresias";
            this.membresias.Size = new System.Drawing.Size(65, 57);
            this.membresias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.membresias.TabIndex = 5;
            this.membresias.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(172, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Clientes / Nuevo";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Depth = 0;
            this.lbUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUsuario.Location = new System.Drawing.Point(754, 23);
            this.lbUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(120, 19);
            this.lbUsuario.TabIndex = 7;
            this.lbUsuario.Text = "Usuario / Fulano";
            // 
            // Panel_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.membresias);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.panelclientes);
            this.MaximumSize = new System.Drawing.Size(910, 584);
            this.MinimumSize = new System.Drawing.Size(910, 584);
            this.Name = "Panel_Clientes";
            this.Size = new System.Drawing.Size(910, 584);
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelclientes;
        private System.Windows.Forms.PictureBox btnclientes;
        private System.Windows.Forms.PictureBox membresias;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbUsuario;
    }
}
