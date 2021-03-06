﻿using System;
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
        //Para acceder a estas variables desde un user control se hace así: PanelAdministrador.variable
        public static string nombre = "", id_privilegio = "", id_empleado = "";

        public PanelAdministrador()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            panelAdmin.Controls.Add(Inicio.Instancia);
        }

        public static PanelAdministrador Instancia = new PanelAdministrador();

        private void PanelAdministrador_Load(object sender, EventArgs e)
        {            
            nombre = Administracion.nombre;
            id_empleado = Administracion.id_empleado;
            id_privilegio = Administracion.id_privilegio;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(id_privilegio) && !string.IsNullOrEmpty(id_empleado))
            {
                lblNombreUs.Text = nombre;

                int contadorBotones = -1;

                foreach (var control in BarraLateral.Items.OfType<ToolStripButton>())
                {
                    contadorBotones += 1;

                    if (contadorBotones >= 2 && id_privilegio != "1")
                    {
                        var boton = control as ToolStripButton;
                        boton.Enabled = false;
                    }                    
                }

            }
            else
            {
                lblNombreUs.Text = "Sin login";
            }
        }

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
                panelAdmin.Controls.Add(Inicio.Instancia);
                boton.BackColor = BarraLateral.BackColor;
                seccion.Text = "Inicio";
            }
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Clientes.Panel_Clientes.Instancia, sender, lblSeccion);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Membresias.Instancia, sender, lblSeccion);
            Membresias.ventanaActiva = true;
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Promociones.Instancia, sender, lblSeccion);
            Promociones.ventanaActiva = true;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Areas.Instancia, sender, lblSeccion);
            Areas.ventanaActiva = true;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Inventarios.Instancia, sender, lblSeccion);
            Inventarios.ventanaActiva = true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ManipulaContenido(Empleados.Instancia, sender, lblSeccion);
            Empleados.ventanaActiva = true;         
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
