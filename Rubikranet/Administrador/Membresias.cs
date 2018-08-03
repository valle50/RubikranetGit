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
    public partial class Membresias : UserControl
    {
        int tiempo = 0;
        public Membresias()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();
        }

        public static Membresias Instancia = new Membresias();

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
                        string.Format("select * from listarCategorias order by id_categoria desc"),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(TablaMem);
                    Actualizar();

                    SendKeys.SendWait("{ENTER}");
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
            Funcion.AjustaContenido(TablaMem);
        }

    }
}
