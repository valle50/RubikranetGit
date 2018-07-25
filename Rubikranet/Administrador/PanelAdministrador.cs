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
    public partial class PanelAdministrador : UserControl
    {
        public PanelAdministrador()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static PanelAdministrador Instancia = new PanelAdministrador();
        
        private void ManipulaContenido(object a, object b, object c)
        {
            var controlUsuario = a as UserControl;
            var boton = b as ToolStripButton;
            var seccion = c as ToolStripLabel;

            if (!panelAdmin.Controls.Contains(controlUsuario))
            {
                panelAdmin.Controls.Clear();
                panelAdmin.Controls.Add(controlUsuario);
                boton.BackColor = Color.DeepSkyBlue;
                seccion.Text = boton.Text;
                
                foreach (var control in BarraLateral.Items.OfType<ToolStripButton>())
                {
                    var botonRestante = control as ToolStripButton;
                    if (boton != botonRestante)
                    {
                        botonRestante.BackColor = BarraLateral.BackColor;
                    } 
                }
            }
            else
            {
                panelAdmin.Controls.Remove(controlUsuario);
                boton.BackColor = BarraLateral.BackColor;
                seccion.Text = "Inicio";
            }
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Membresias.Instancia, sender, lblSeccion);
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Promociones.Instancia, sender, lblSeccion);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Areas.Instancia, sender, lblSeccion);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Inventarios.Instancia, sender, lblSeccion);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Usuarios.Instancia, sender, lblSeccion);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Empleados.Instancia, sender, lblSeccion);
        }

        private void btnEntradas_salidas_Click(object sender, EventArgs e)
        {
            ManipulaContenido(EntradasSalidas.Instancia, sender, lblSeccion);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Ventas.Instancia, sender, lblSeccion);
        }
    }
}
