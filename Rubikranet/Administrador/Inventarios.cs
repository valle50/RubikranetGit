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
    public partial class Inventarios : UserControl
    {
        public Inventarios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static Inventarios Instancia = new Inventarios();
    }
}
