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
    public partial class Promociones : UserControl
    {
        public Promociones()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static Promociones Instancia = new Promociones();
    }
}
