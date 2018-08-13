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
        public static string nombre = "", id_privilegio = "", id_empleado = "4";
        int check = 0;

        private void Panel_Clientes_Load(object sender, EventArgs e)
        {
            
            Conexion.Paginar(string.Format("select * from CLIENTES_MEMBRESIAS order by num desc"),"DataMember1", 20);
            Funcion.CargaTablaDatos_Estilos_Botones(tablaClientes);
            Actualizar();
            tablaClientes.Columns[2].Visible = false;
            tablaClientes.Columns[3].Visible = false;
            cargarCat();
            id_empleado = Administracion.id_empleado;
            nombre = Administracion.nombre;
            txtEmpleado.Text = nombre;
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.CustomFormat = "dd-MM-yyyy";
            dtFin.Format = DateTimePickerFormat.Custom;
            dtFin.CustomFormat = "dd-MM-yyyy";
        }
        private void Actualizar()
        {
            lblTotalReg.Text = Conexion.countRow().ToString();
            lblPagActual.Text = Conexion.numPag().ToString();
            lblTotalPag.Text = Conexion.countPag().ToString();
            Funcion.AjustaContenido(tablaClientes);
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
                    string.Format("select * from CLIENTES_MEMBRESIAS order by num desc"),
                    "DataMember1", Convert.ToInt16(comboCantidadReg.Text));
            tablaClientes.DataSource = Conexion.cargar();
            tablaClientes.DataMember = "DataMember1";

            Actualizar();
        }

        private void selectCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cargarCat (){

            foreach (var ctrl in panel1.Controls.OfType<MetroFramework.Controls.MetroComboBox>())
            {
                var combo = ctrl as MetroFramework.Controls.MetroComboBox;
                combo.Items.Clear();
            }
           
            Conexion.Consulta(String.Format("select * from categorias_membresias"));
            CargaCombos("Categorias...", selectCategoria, "id_categoria", "categoria");
            Conexion.con.Close();

        }

        private void addMembers_Click(object sender, EventArgs e)
        {
            Agregar_Miembros addMem = new Agregar_Miembros();
            addMem.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cat = (selectCategoria.SelectedItem as AttrCB).Value.ToString();

            Conexion.Ejecutar(String.Format("EXEC MEMBRESIA_CU '{0}','{1}','{2}','{3}','{4}','{5}' ", check,txtMembresia.Text,cat,id_empleado,dtInicio.Text,dtFin.Text));
        }

        private void comboCantidadReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion.actualizaTope(Convert.ToInt16(comboCantidadReg.Text));
            Actualizar();
        }

        private void txtMembresia_TextChanged(object sender, EventArgs e)
        {
            Conexion.Consulta(String.Format(""));
        }

        private void CargaCombos(string text0, object o, string value, string text)
        {
            var combo = o as MetroFramework.Controls.MetroComboBox;

            AttrCB item0 = new AttrCB();
            item0.Value = "0";
            item0.Text = text0;

            combo.Items.Add(item0);

            while (Conexion.result.Read())
            {
                AttrCB item = new AttrCB();

                item.Value = Conexion.result[value].ToString();
                item.Text = Conexion.result[text].ToString();

                combo.Items.Add(item);
            }
        }

        public class AttrCB
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

    }
}
