namespace Rubikranet.Administrador
{
    partial class PanelAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdministrador));
            this.BarraSuperior = new System.Windows.Forms.ToolStrip();
            this.btnConfiguracion = new System.Windows.Forms.ToolStripButton();
            this.btnAdministrador = new System.Windows.Forms.ToolStripDropDownButton();
            this.miInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombreUs = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lblSeccion = new System.Windows.Forms.ToolStripLabel();
            this.BarraLateral = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnVentas = new System.Windows.Forms.ToolStripButton();
            this.btnMembresia = new System.Windows.Forms.ToolStripButton();
            this.btnPromociones = new System.Windows.Forms.ToolStripButton();
            this.btnArea = new System.Windows.Forms.ToolStripButton();
            this.btnInventario = new System.Windows.Forms.ToolStripButton();
            this.btnEmpleado = new System.Windows.Forms.ToolStripButton();
            this.btnEntradas_salidas = new System.Windows.Forms.ToolStripButton();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            this.BarraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.AutoSize = false;
            this.BarraSuperior.BackColor = System.Drawing.Color.Black;
            this.BarraSuperior.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.BarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracion,
            this.btnAdministrador,
            this.lblNombreUs,
            this.toolStripLabel,
            this.lblSeccion});
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BarraSuperior.Size = new System.Drawing.Size(984, 50);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.Text = "toolStrip1";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(34, 47);
            this.btnConfiguracion.Text = "Configuarción";
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInformaciónToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.btnAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.Image")));
            this.btnAdministrador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(43, 47);
            this.btnAdministrador.Text = "Administrador";
            // 
            // miInformaciónToolStripMenuItem
            // 
            this.miInformaciónToolStripMenuItem.Name = "miInformaciónToolStripMenuItem";
            this.miInformaciónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.miInformaciónToolStripMenuItem.Text = "Mi información";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editarToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // lblNombreUs
            // 
            this.lblNombreUs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUs.ForeColor = System.Drawing.Color.White;
            this.lblNombreUs.Name = "lblNombreUs";
            this.lblNombreUs.Size = new System.Drawing.Size(86, 47);
            this.lblNombreUs.Text = "Nombre admin";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.AutoSize = false;
            this.toolStripLabel.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel.Size = new System.Drawing.Size(550, 47);
            this.toolStripLabel.Text = "toolStripLabel2";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = false;
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSeccion.Size = new System.Drawing.Size(210, 47);
            this.lblSeccion.Text = "Inicio";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarraLateral
            // 
            this.BarraLateral.AutoSize = false;
            this.BarraLateral.BackColor = System.Drawing.Color.Black;
            this.BarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateral.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.BarraLateral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnVentas,
            this.btnMembresia,
            this.btnPromociones,
            this.btnArea,
            this.btnInventario,
            this.btnEmpleado,
            this.btnEntradas_salidas});
            this.BarraLateral.Location = new System.Drawing.Point(0, 50);
            this.BarraLateral.Name = "BarraLateral";
            this.BarraLateral.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraLateral.Size = new System.Drawing.Size(50, 699);
            this.BarraLateral.TabIndex = 1;
            this.BarraLateral.Text = "toolStrip2";
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Black;
            this.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(48, 34);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(48, 34);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMembresia.Image = ((System.Drawing.Image)(resources.GetObject("btnMembresia.Image")));
            this.btnMembresia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMembresia.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(48, 34);
            this.btnMembresia.Text = "Categoría de membresias";
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPromociones.Image = ((System.Drawing.Image)(resources.GetObject("btnPromociones.Image")));
            this.btnPromociones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPromociones.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(48, 34);
            this.btnPromociones.Text = "Promociones";
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // btnArea
            // 
            this.btnArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArea.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.Image")));
            this.btnArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArea.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(48, 34);
            this.btnArea.Text = "Áreas";
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInventario.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(48, 34);
            this.btnInventario.Text = "Inventarios";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(48, 34);
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnEntradas_salidas
            // 
            this.btnEntradas_salidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEntradas_salidas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradas_salidas.Image")));
            this.btnEntradas_salidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntradas_salidas.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.btnEntradas_salidas.Name = "btnEntradas_salidas";
            this.btnEntradas_salidas.Size = new System.Drawing.Size(48, 34);
            this.btnEntradas_salidas.Text = "Entradas/Salidas empleados";
            this.btnEntradas_salidas.Click += new System.EventHandler(this.btnEntradas_salidas_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.White;
            this.panelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(50, 50);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(934, 699);
            this.panelAdmin.TabIndex = 2;
            // 
            // PanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.BarraLateral);
            this.Controls.Add(this.BarraSuperior);
            this.Name = "PanelAdministrador";
            this.Size = new System.Drawing.Size(984, 749);
            this.Load += new System.EventHandler(this.PanelAdministrador_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.BarraLateral.ResumeLayout(false);
            this.BarraLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraSuperior;
        private System.Windows.Forms.ToolStrip BarraLateral;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripDropDownButton btnAdministrador;
        private System.Windows.Forms.ToolStripMenuItem miInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnPromociones;
        private System.Windows.Forms.ToolStripButton btnEmpleado;
        private System.Windows.Forms.ToolStripButton btnArea;
        private System.Windows.Forms.ToolStripButton btnInventario;
        private System.Windows.Forms.ToolStripButton btnMembresia;
        private System.Windows.Forms.ToolStripButton btnEntradas_salidas;
        private System.Windows.Forms.ToolStripButton btnConfiguracion;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripLabel lblSeccion;
        private System.Windows.Forms.ToolStripButton btnVentas;
        public System.Windows.Forms.ToolStripLabel lblNombreUs;
    }
}
