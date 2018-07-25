using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Administrador
{
    public partial class Membresias : UserControl
    {
        public Membresias()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static Membresias Instancia = new Membresias();
    }
}
