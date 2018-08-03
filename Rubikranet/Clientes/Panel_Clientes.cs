using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Clientes
{
    public partial class Panel_Clientes : UserControl
    {
        public Panel_Clientes()
        {
            InitializeComponent();
        }
        public static Panel_Clientes Instancia = new Panel_Clientes();

        private void ManipulaContenido(object a, object b)
        {
            var controlUsuario = a as UserControl;

            if (!panelclientes.Controls.Contains(controlUsuario))
            {
                panelclientes.Controls.Clear();
                panelclientes.Controls.Add(controlUsuario);
            }
            else
            {
                panelclientes.Controls.Remove(controlUsuario);
                panelclientes.BackgroundImage = Properties.Resources.fondo3;
            }

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            ManipulaContenido(clientes.Instancia, sender);
            btnclientes.BackColor = Color.SkyBlue;
        }
    }
}
