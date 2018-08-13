using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using MetroSet_UI.Controls;

namespace Rubikranet.Clientes
{
    public partial class Agregar_Miembros : MaterialSkin.Controls.MaterialForm
    {
        public Agregar_Miembros()
        {
            InitializeComponent();
        }

        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
