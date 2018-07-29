using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubikranet.Funciones;

namespace Rubikranet.Administrador
{
    public partial class Areas : UserControl
    {
        int tiempo = 0;
        public Areas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();          
        }

        public static Areas Instancia = new Areas();

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string busca = txtBuscar.Text.Replace(" ", "%");

            Conexion.Paginar(
                String.Format("exec buscaAreas '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            TablaAreas.DataSource = Conexion.cargar();
            TablaAreas.DataMember = "DataMember1";

            Actualizar();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            tiempo += 1;

            switch (tiempo)
            {
                case 1:
                    Mensajes.Caja("Information", "Atención", "Cargando datos, espere por favor...");
                    comboCantidadReg.SelectedIndex = 0;
                    break;
                case 2:
                    Conexion.Paginar(
                        string.Format("select * from listarAreas order by id_area desc"),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(TablaAreas);
                    Actualizar();

                    SendKeys.SendWait("{ENTER}");
                    TablaAreas.Columns[2].Visible = false;
                    break;
                case 3:
                    break;
                default:
                    timerCarga.Stop();
                    break;
            }
        }

        private void Actualizar()
        {
            lblTotalReg.Text = Conexion.countRow().ToString();
            lblPagActual.Text = Conexion.numPag().ToString();
            lblTotalPag.Text = Conexion.countPag().ToString();
            Funcion.AjustaContenido(TablaAreas);
        }

        private void comboCantidadReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion.actualizaTope(Convert.ToInt16(comboCantidadReg.Text));
            Actualizar();
        }
        private void btnPrimerPagina_Click(object sender, EventArgs e)
        {
            Conexion.primeraPagina();
            Actualizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Conexion.atras();
            Actualizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Conexion.adelante();
            Actualizar();
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            Conexion.ultimaPagina();
            Actualizar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Conexion.Paginar(
                    string.Format("select * from listarAreas order by id_area desc"),
                    "DataMember1", Convert.ToInt16(comboCantidadReg.Text));
            TablaAreas.DataSource = Conexion.cargar();
            TablaAreas.DataMember = "DataMember1";

            Actualizar();
        }
    }
}
