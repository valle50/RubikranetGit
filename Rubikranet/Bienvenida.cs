using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet
{
    public partial class Bienvenida : Form
    {
        int timer;

        System.Drawing.Drawing2D.GraphicsPath Logo = new System.Drawing.Drawing2D.GraphicsPath();
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Logo.AddRectangles(this., 100, 100, 100);
            //this.Region = new Region(Logo);
            timer = -1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer >= 0)
            {

                timer = timer - 1;
                progressBar1.Value = progressBar1.Value + 20;

            }
            else {

                timer1.Stop();
                Acceso access = new Acceso();
                this.Hide();
                access.ShowDialog();
                this.Close();
            }


        }
    }
}
