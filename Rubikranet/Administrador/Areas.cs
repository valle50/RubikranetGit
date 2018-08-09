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

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series["campo1"].Points.AddXY("Max",33);
            //chart1.Series["campo2"].Points.AddXY("Max", 70);

            //chart1.Series["campo1"].Points.AddXY("Carl", 15);
            //chart1.Series["campo2"].Points.AddXY("Max", 80);

            //chart1.Series["campo1"].Points.AddXY("Marc", 50);
            //chart1.Series["campo2"].Points.AddXY("Max", 90);

            //chart1.Series["campo1"].Points.AddXY("Paco", 10);
            //chart1.Series["campo2"].Points.AddXY("Max", 100);
            //chart1.Series.Add("nombre");

            chart1.Series.Add("Cupo máximo");
            chart1.Series.Add("Cupo actual");

            chart1.Series["Cupo máximo"].ChartType = SeriesChartType.Column;
            chart1.Series["Cupo actual"].ChartType = SeriesChartType.Column;

            chart1.Series["Cupo máximo"].Color = Color.DeepSkyBlue;
            chart1.Series["Cupo actual"].Color = Color.DarkRed;

            chart1.Series["Cupo máximo"].IsValueShownAsLabel = true;
            chart1.Series["Cupo actual"].IsValueShownAsLabel = true;


            Conexion.Consulta("select top(10) nombre, cupo_maximo, cupo_actual from areas");
            while (Conexion.result.Read())
            {      
                chart1.Series["Cupo máximo"].Points.AddXY(Conexion.result["nombre"].ToString(), Conexion.result["cupo_maximo"].ToString());
                chart1.Series["Cupo actual"].Points.AddY(Conexion.result["cupo_actual"].ToString());
            }

            Conexion.con.Close();
        }
    }
}
