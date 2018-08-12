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

namespace Rubikranet.Clientes
{
    public partial class Panel_Clientes : UserControl
    {
        public Panel_Clientes()
        {
            InitializeComponent();
        }

        public static Panel_Clientes Instancia = new Panel_Clientes();

        private void Panel_Clientes_Load(object sender, EventArgs e)
        {
            Conexion.Paginar(string.Format("select * from CLIENTES_MEMBRESIAS order by num desc"),"DataMember1", 20);
            Funcion.CargaTablaDatos_Estilos_Botones(tablaClientes);
            Actualizar();
            tablaClientes.Columns[2].Visible = false;
            tablaClientes.Columns[3].Visible = false;
        }
        private void Actualizar()
        {
            lblTotalReg.Text = Conexion.countRow().ToString();
            lblPagActual.Text = Conexion.numPag().ToString();
            lblTotalPag.Text = Conexion.countPag().ToString();
            Funcion.AjustaContenido(tablaClientes);
        }
    }
}
