using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet
{
    public partial class Bienvenida : Form
    {
        System.Drawing.Drawing2D.GraphicsPath Logo = new System.Drawing.Drawing2D.GraphicsPath();
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Logo.AddRectangles(this., 100, 100, 100);
            //this.Region = new Region(Logo);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < 10000; i++)
            {
                metroProgressSpinner1.Value = i;

                if (i == 9999)
                {
                    timer1.Stop();
                    Acceso access = new Acceso();
                    this.Hide();
                    access.ShowDialog();
                    Administracion admin = new Administracion();
                    admin.ShowDialog();
                    this.Close();
                }
            }            
        }
    }
}
