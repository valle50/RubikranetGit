using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Rubikranet.Funciones;

namespace Rubikranet.Administrador
{
    public partial class Areas : UserControl
    {
        int tiempo = 0;
        int check = 0;
        public static bool ventanaActiva = false;
        bool actualizaGrafica = false;

        public Areas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();
        }
        
        public static Areas Instancia = new Areas();

        private void Limpia()
        {
            check = 0;
            txtNombre.Text = ""; txtNormas.Text = ""; txtHorario.Text = "";  txtMensaje.Text = "";
            radioAccesibilidad.Checked = false; radioAccesibilidad2.Checked = false;
            radioEstatus.Checked = false; radioEstatus2.Checked = false;
            scrollActual.Value = 0;
            scrollMaximo.Value = 20;

            btnGuardar.BackgroundImage = null;
            btnGuardar.BackgroundImage = Properties.Resources.diskette;
            TablaAreas.Columns[1].Visible = true;//muestra botón eliminar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Focus();
            string accesibilidad = "";
            string estatus = "";

            if (radioAccesibilidad.Checked)
            {
                accesibilidad = radioAccesibilidad.Tag.ToString();
            }
            else if (radioAccesibilidad2.Checked)
            {
                accesibilidad = radioAccesibilidad2.Tag.ToString();
            }

            if (radioEstatus.Checked)
            {
                estatus = radioEstatus.Tag.ToString();
            }
            else if (radioEstatus2.Checked)
            {
                estatus = radioEstatus2.Tag.ToString();
            }

            if (accesibilidad == "" || estatus == "" || txtNombre.Text == "" || txtNormas.Text == "" || txtHorario.Text == "" || txtMensaje.Text =="")
            {
                Mensajes.Caja("Warning", "Campos requeridos", "Todos los datos son necesarios, a excepción de los rangos numéricos.");
            }
            else if (MessageBox.Show("¿Continuar con la acción?", "Nuevo/Actualizar registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexion.Ejecutar(
                    String.Format("exec areas_aa  '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'", check, txtNombre.Text, txtMensaje.Text, txtNormas.Text, numMaximo.Value, numActual.Value, txtHorario.Text, estatus, accesibilidad));

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
                String.Format("exec buscaAreas '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            TablaAreas.DataSource = Conexion.cargar();
            TablaAreas.DataMember = "DataMember1";

            Actualizar();
        }

        private void TablaAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;

            if(dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TablaAreas.Columns[1].Visible = false;//oculta botón eliminar
                    check = Convert.ToInt16(dgv.CurrentRow.Cells[2].Value);

                    Conexion.Consulta(
                        String.Format("select * from listarAreas where id_area = '{0}'", check));

                    while (Conexion.result.Read())
                    {
                        txtNombre.Text = Conexion.result["Nombre del área"].ToString();
                        numMaximo.Value = Convert.ToInt16(Conexion.result["Cupo máximo"]);
                        scrollMaximo.Value = Convert.ToInt16(Conexion.result["Cupo máximo"]);
                        numActual.Value = Convert.ToInt16(Conexion.result["Cupo actual"]);
                        scrollActual.Value = Convert.ToInt16(Conexion.result["Cupo actual"]);
                        txtHorario.Text = Conexion.result["Horario"].ToString();
                        txtMensaje.Text = Conexion.result["Mensaje para el cliente"].ToString();
                        txtNormas.Text = Conexion.result["Normas del área"].ToString();

                        var accesibilidad = Conexion.result["Accesibilidad del área"].ToString() == radioAccesibilidad.Text ?
                            radioAccesibilidad.Checked = true :
                            radioAccesibilidad2.Checked = true;

                        var estatus = Conexion.result["Estado del área"].ToString() == radioEstatus.Text ?
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

                    Conexion.Ejecutar(String.Format("update areas set estatusEliminado = 1 where id_area = '{0}'", check));

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
                    "DataMember1", 20);
            TablaAreas.DataSource = Conexion.cargar();
            TablaAreas.DataMember = "DataMember1";

            Actualizar();
        }

        private void timerActualiza_Tick(object sender, EventArgs e)
        {
            if (ventanaActiva)
            {
                btnRefrescar_Click(null,null);
                ventanaActiva = false;
            }

            if (actualizaGrafica)
            {
                llenaGrafica();
            }
        }

        private void scrollMaximo_ValueChanged(object sender, EventArgs e)
        {
            numMaximo.Value = scrollMaximo.Value;
        }

        private void scrollActual_ValueChanged(object sender, EventArgs e)
        {
            numActual.Value = scrollActual.Value;  
        }

        private void scrollActual_MouseUp(object sender, MouseEventArgs e)
        {
            validaCupoActual();
        }

        private void numActual_MouseClick(object sender, MouseEventArgs e)
        {
            validaCupoActual();
        }

        private void scrollActual_MouseHover(object sender, EventArgs e)
        {
            validaCupoActual();
        }

        private void validaCupoActual()
        {
            if (numActual.Value >= numMaximo.Value)
            {
                numActual.Value = numMaximo.Value;
                scrollActual.Value = numMaximo.Value;
            }
        }

        private void llenaGrafica()
        {
            string[] series = new string[] { "Visitas al año", "Visitas al mes", "Visitas a la semana", "Visitas al día", "Cupo máximo", "Cupo actual" };
            
            //chartAreasVisitadas.Series.Clear();
            foreach (var serie in chartAreasVisitadas.Series)
            {
                serie.Points.Clear();
            }

            if (chartAreasVisitadas.Series.Count == 0)
            {
                chartAreasVisitadas.Titles.Add("Área visitada");                

                for (var i = 0; i < series.Length; i++)
                {
                    chartAreasVisitadas.Series.Add(series[i]);
                    chartAreasVisitadas.Series[series[i]].ChartType = SeriesChartType.Column;
                    chartAreasVisitadas.Series[series[i]].IsValueShownAsLabel = true;
                    chartAreasVisitadas.Series[series[i]]["PointWidth"] = "1.5";
                }                
            }

            Conexion.Consulta(string.Format("exec contadorVisitasAreas '{0}'", 4));
            while (Conexion.result.Read())
            {
                chartAreasVisitadas.Series["Visitas al año"].Points.AddXY(Conexion.result["Nombre"].ToString(), Conexion.result["Año"].ToString());
                chartAreasVisitadas.Series["Visitas al mes"].Points.AddY(Conexion.result["Mes"].ToString());
                chartAreasVisitadas.Series["Visitas a la semana"].Points.AddY(Conexion.result["Semana"].ToString());
                chartAreasVisitadas.Series["Visitas al día"].Points.AddY(Conexion.result["Día"].ToString());

                chartAreasVisitadas.Series["Cupo máximo"].Points.AddY(Conexion.result["Cupo máximo"].ToString());
                chartAreasVisitadas.Series["Cupo actual"].Points.AddY(Conexion.result["Cupo actual"].ToString());
            }
            
            Conexion.con.Close();
        }

        private void TabAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabAreas.SelectedTab == TabAreas.TabPages["paginaGrafica"])
            {
                actualizaGrafica = true;                
            }else
            {
                actualizaGrafica = false;
            }
        }
    }
}
