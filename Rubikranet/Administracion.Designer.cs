namespace Rubikranet
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.contenidoPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // contenidoPanel
            // 
            this.contenidoPanel.BackColor = System.Drawing.Color.White;
            this.contenidoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenidoPanel.Location = new System.Drawing.Point(0, 0);
            this.contenidoPanel.Name = "contenidoPanel";
            this.contenidoPanel.Size = new System.Drawing.Size(984, 749);
            this.contenidoPanel.TabIndex = 1;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.contenidoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RubiKranet - Control de membresías";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contenidoPanel;
    }
}