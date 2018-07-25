using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MetroSet_UI;
using MetroSet_UI.Controls;
using System.IO.Ports;
using Rubikranet.Administrador;

namespace Rubikranet
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            contenidoPanel.Controls.Add(PanelAdministrador.Instancia);
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

    }
}
