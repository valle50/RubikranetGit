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
    public partial class Inventarios : UserControl
    {
        int tiempo = 0, check = 0;
        public static bool ventanaActiva = false;

        public Inventarios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();
        }

        public static Inventarios Instancia = new Inventarios();

        private void Limpia()
        {
            check = 0;
            txtNombre.Text = "";
            txtActual.Text = "";
            txtInicio.Text = "";
            txtDet.Text = "";
            txtNotas.Text = "";
            comboAreas.SelectedIndex = 0;

            btnGuardar.BackgroundImage = null;
            btnGuardar.BackgroundImage = Properties.Resources.diskette;
            TablaInv.Columns[1].Visible = true;//muestra botón eliminar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Focus();

            if (txtNombre.Text == "" || txtActual.Text == "" || txtInicio.Text == "" || txtDet.Text == "" || txtNotas.Text == "" || comboAreas.SelectedIndex == 0)
            {
                Mensajes.Caja("Warning", "Campos requeridos", "Todos los datos son necesarios a excepción de NOTAS.");
            }
            else if (MessageBox.Show("¿Continuar con la acción?", "Nuevo/Actualizar registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string idArea = (comboAreas.SelectedItem as AttrCB).Value.ToString(); 

                Conexion.Ejecutar(
                    String.Format("exec inventarios_aa  '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", check, idArea, txtNombre.Text, txtInicio.Text, txtActual.Text, txtDet.Text, txtNotas.Text));

                btnRefrescar_Click(null, null);
                ActualizaComboAreas();
                Limpia();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación?", "Cancelar acción.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpia();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string busca = txtBuscar.Text.Replace(" ", "%");

            Conexion.Paginar(
                String.Format("exec buscaInventario '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            TablaInv.DataSource = Conexion.cargar();
            TablaInv.DataMember = "DataMember1";

            Actualizar();
        }

        private void TablaInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TablaInv.Columns[1].Visible = false;//oculta botón eliminar
                    check = Convert.ToInt16(dgv.CurrentRow.Cells[2].Value);

                    Conexion.Consulta(
                        String.Format("select * from listarInventario where id = '{0}'", check));

                    while (Conexion.result.Read())
                    {
                        txtNombre.Text = Conexion.result["Nombre del artículo"].ToString();
                        txtInicio.Text = Conexion.result["Cantidad de inicio"].ToString();
                        txtActual.Text = Conexion.result["Cantidad actual"].ToString();
                        txtDet.Text = Conexion.result["Detalles del artículo"].ToString();
                        txtNotas.Text = Conexion.result["Notas adicionales"].ToString();
                        comboAreas.SelectedIndex = comboAreas.FindStringExact(Conexion.result["Área a la que pertenece"].ToString());
                    }

                    btnGuardar.BackgroundImage = null;
                    btnGuardar.BackgroundImage = Properties.Resources.edit1;

                    Conexion.con.Close();

                }
                else if (boton.Name == "btnEliminar" && MessageBox.Show("¿Eliminar registro?", "Eliminar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    check = Convert.ToInt16(dgv.CurrentRow.Cells[2].Value);
                    dgv.Rows.Remove(dgv.CurrentRow);

                    Conexion.Ejecutar(String.Format("update inventario_areas set estatus = 1 where id = '{0}'", check));

                    check = 0;
                    Mensajes.Caja("Information", "Información", "Registro eliminado correctamente.");
                }
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

        private void ActualizaComboAreas()
        {
            comboAreas.Items.Clear();

            AttrCB item0 = new AttrCB();
            item0.Value = "0";
            item0.Text = "Área...";

            comboAreas.Items.Add(item0);

            Conexion.Consulta(
                        string.Format("select id_area, nombre from areas where estatusEliminado <> 1"));

            while (Conexion.result.Read())
            {
                AttrCB item = new AttrCB();

                item.Value = Conexion.result["id_area"].ToString();
                item.Text = Conexion.result["nombre"].ToString();

                comboAreas.Items.Add(item);
            }
            comboAreas.SelectedIndex = 0;
            Conexion.con.Close();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            tiempo += 1;

            switch (tiempo)
            {
                case 1:
                    Mensajes.Caja("Information", "Atención", "Cargando datos, espere por favor...");

                    ActualizaComboAreas();

                    comboCantidadReg.SelectedIndex = 0;
                    break;
                case 2:
                    Conexion.Paginar(
                        string.Format("select * from listarInventario  order by id desc "),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(TablaInv);
                    Actualizar();

                    SendKeys.SendWait("{ENTER}");
                    TablaInv.Columns[2].Visible = false;
                    break;
                default:
                    timerCarga.Stop();
                    timerActualiza.Start();
                    break;
            }
        }

        private void Actualizar()
        {
            lblTotalReg.Text = Conexion.countRow().ToString();
            lblPagActual.Text = Conexion.numPag().ToString();
            lblTotalPag.Text = Conexion.countPag().ToString();
            Funcion.AjustaContenido(TablaInv);
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
                    string.Format("select * from listarInventario  order by id desc "),
                    "DataMember1", 20);
            TablaInv.DataSource = Conexion.cargar();
            TablaInv.DataMember = "DataMember1";

            Actualizar();
        }

        private void timerActualiza_Tick(object sender, EventArgs e)
        {
            if (ventanaActiva)
            {
                btnRefrescar_Click(null, null);
                ActualizaComboAreas();
                ventanaActiva = false;
            }
        }
    }
}
