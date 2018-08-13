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
    public partial class Promociones : UserControl
    {
        int tiempo = 0, check = 0;
        public static bool ventanaActiva = false;
        public Promociones()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();
        }

        public static Promociones Instancia = new Promociones();

        private void Limpia()
        {
            check = 0;
            txtNombre.Text = ""; txtDesc.Text = ""; dtInicio.Value = DateTime.Now; dtFin.Value = DateTime.Now;
            numPorcentaje.Value = 0;
            radioEstatus.Checked = false; radioEstatus2.Checked = false;

            btnGuardar.BackgroundImage = null;
            btnGuardar.BackgroundImage = Properties.Resources.diskette;
            TablaProm.Columns[1].Visible = true;//muestra botón eliminar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Focus();
            string estatus = "";

            if (radioEstatus.Checked)
            {
                estatus = radioEstatus.Tag.ToString();
            }
            else if (radioEstatus2.Checked)
            {
                estatus = radioEstatus2.Tag.ToString();
            }

            if (estatus == "" || txtNombre.Text == "" || txtDesc.Text == "" || numPorcentaje.Value == 0)
            {
                Mensajes.Caja("Warning", "Campos requeridos", "Todos los datos son necesarios.");
            }
            else if (MessageBox.Show("¿Continuar con la acción?", "Nuevo/Actualizar registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexion.Ejecutar(
                    String.Format("exec promociones_aa  '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", check, txtNombre.Text, txtDesc.Text, numPorcentaje.Value, estatus, dtInicio.Text, dtFin.Text));

                btnRefrescar_Click(null, null);
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
                String.Format("exec buscaPromociones '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            TablaProm.DataSource = Conexion.cargar();
            TablaProm.DataMember = "DataMember1";

            Actualizar();
        }

        private void TablaProm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TablaProm.Columns[1].Visible = false;//oculta botón eliminar
                    check = Convert.ToInt16(dgv.CurrentRow.Cells[2].Value);

                    Conexion.Consulta(
                        String.Format("select * from listarPromociones where id_promocion = '{0}'", check));

                    while (Conexion.result.Read())
                    {
                        txtNombre.Text = Conexion.result["Nombre de promoción"].ToString();
                        txtDesc.Text = Conexion.result["Descripción de la promoción"].ToString();
                        numPorcentaje.Value = Convert.ToInt32(Conexion.result["Porcentaje de descuento"].ToString().Replace("%",""));
                        dtInicio.Text = Conexion.result["Fecha de inicio"].ToString();
                        dtFin.Text = Conexion.result["Fecha de fin"].ToString();

                        var accesibilidad = Conexion.result["Estatus de la promoción"].ToString() == radioEstatus.Text ?
                            radioEstatus.Checked = true :
                            radioEstatus2.Checked = true;
                    }

                    btnGuardar.BackgroundImage = null;
                    btnGuardar.BackgroundImage = Properties.Resources.edit1;

                    Conexion.con.Close();

                }
                else if (boton.Name == "btnEliminar" && MessageBox.Show("¿Eliminar registro?", "Eliminar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    check = Convert.ToInt16(dgv.CurrentRow.Cells[2].Value);
                    dgv.Rows.Remove(dgv.CurrentRow);

                    Conexion.Ejecutar(String.Format("update promociones set estatus = 1 where id_promocion = '{0}'", check));

                    check = 0;
                    Mensajes.Caja("Information", "Información", "Registro eliminado correctamente.");
                }
            }
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            tiempo += 1;

            switch (tiempo)
            {
                case 1:
                    Mensajes.Caja("Information", "Atención", "Cargando datos, espere por favor...");
                    dtInicio.Format = DateTimePickerFormat.Custom;
                    dtInicio.CustomFormat = "dd-MM-yyyy";
                    dtFin.Format = DateTimePickerFormat.Custom;
                    dtFin.CustomFormat = "dd-MM-yyyy";
                    comboCantidadReg.SelectedIndex = 0;
                    break;

                case 2:
                    Conexion.Paginar(
                        string.Format("select * from listarPromociones order by id_promocion desc"),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(TablaProm);
                    Actualizar();

                    SendKeys.SendWait("{ENTER}");
                    TablaProm.Columns[2].Visible = false;
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
            Funcion.AjustaContenido(TablaProm);
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
                   string.Format("select * from listarPromociones order by id_promocion desc"),
                   "DataMember1", 20);
            TablaProm.DataSource = Conexion.cargar();
            TablaProm.DataMember = "DataMember1";

            Actualizar();
        }

        private void timerActualiza_Tick(object sender, EventArgs e)
        {
            if (ventanaActiva)
            {
                btnRefrescar_Click(null, null);
                ventanaActiva = false;
            }
        }
    }
}
