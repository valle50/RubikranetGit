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
using System.Threading;

namespace Rubikranet.Administrador
{
    public partial class Empleados : UserControl
    {
        int tiempo = 0;
        string check = "";
        object[] txts;
        object[] combos;
        public Empleados()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();
        }

        public static Empleados Instancia = new Empleados();
        private void Limpia()
        {
            foreach (var ctrl in panel1.Controls.OfType<MetroFramework.Controls.MetroComboBox>())
            {
                var combo = ctrl as MetroFramework.Controls.MetroComboBox;
                combo.SelectedIndex = 0;
            }

            comboCantidadReg.SelectedIndex = 0;

            check = "";
            radioSexo.Checked = false;
            radioSexo2.Checked = false;

            Validar.Limpiar(txts);            

            dtNacimiento.Value = DateTime.Now;
            btnGuardar.BackgroundImage = null;
            btnGuardar.BackgroundImage = Properties.Resources.diskette;
        }

        //LLena el combo de municipios de acuerdo al estado seleccionado
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstado.SelectedIndex != 0)
            {
                comboMunicipio.Items.Clear();
                Conexion.Consulta(
                    String.Format("select * from municipios where id_estado = {0}", (comboEstado.SelectedItem as AtributosCombo).Value.ToString()));

                CargaCombos("Municipio...", comboMunicipio, "id_municipio", "nombre_municipio");
                comboMunicipio.SelectedIndex = 0;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string busca = txtBuscar.Text.Replace(" ", "%");

            Conexion.Paginar(
                String.Format("exec buscaEmpleados '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            tablaEmpleados.DataSource = Conexion.cargar();
            tablaEmpleados.DataMember = "DataMember1";

            Actualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Focus();//Se pone el foco en el botón, porque despues al verificar las validaciones, se comporta algo extraño cuando el foco lo tiene un campo de texto.
            char sexo = ' ';
            if (radioSexo.Checked)
            {
                sexo = Convert.ToChar(radioSexo.Tag);
            }
            else if (radioSexo2.Checked)
            {
                sexo = Convert.ToChar(radioSexo2.Tag);
            }            

            if (!Validar.Requeridos(txts) || !Validar.ComboRequerido(combos) || sexo == ' ' || !Validar.email || !Validar.phone)
            {
                Mensajes.Caja("Warning", "Campos requeridos", "Ningún dato debe quedar vacío y/o con información incorrecta (campos de color).");
            }
            else if(MessageBox.Show("¿Continuar con la acción?", "Nuevo/Actualizar registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string estado = (comboEstado.SelectedItem as AtributosCombo).Value.ToString();
                string municipio = (comboMunicipio.SelectedItem as AtributosCombo).Value.ToString();
                string estatus = (comboEstatus.SelectedItem as AtributosCombo).Value.ToString();
                string cargo = (comboCargo.SelectedItem as AtributosCombo).Value.ToString();
                string privilegio = (comboPrivilegio.SelectedItem as AtributosCombo).Value.ToString();
                string area = (comboArea.SelectedItem as AtributosCombo).Value.ToString();


                Conexion.Ejecutar(
                    String.Format("exec empleados_aa  '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}'", check, txtId.Text, txtNombre.Text, txtAP.Text, txtAM.Text, sexo, dtNacimiento.Text, txtDirección.Text, txtCP.Text, estado, municipio, txtTelefono.Text, txtCorreo.Text, txtRFID.Text, txtNIP.Text, estatus, cargo, privilegio, area));

                Conexion.Paginar(
                            string.Format("select * from listarEmpleados order by num desc"),
                            "DataMember1", Convert.ToInt16(comboCantidadReg.Text));
                tablaEmpleados.DataSource = Conexion.cargar();
                tablaEmpleados.DataMember = "DataMember1";

                Actualizar();
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
        private void tablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            string auxMunicipio = "";

            if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Aquí el check toma el id del empleado de la columna que se ocultó y que se encuentra en la posición 3... (Se ocultaron en la carga) 
                    //El 0 es el botón editar, 1 = btnEliminar, 2 = columna "num" y 3 = columna "id_empleado", los últimos dos se ocultaron, pero siguen ahí
                    check = dgv.CurrentRow.Cells[3].Value.ToString(); 

                    Conexion.Consulta(
                        string.Format("select * from listarEmpleados where id_empleado = '{0}'", check));

                    while (Conexion.result.Read())
                    {
                        txtId.Text = Conexion.result["id_empleado"].ToString();
                        txtNombre.Text = Conexion.result["Nombre"].ToString();
                        txtAP.Text = Conexion.result["Apellido paterno"].ToString();
                        txtAM.Text = Conexion.result["Apellido materno"].ToString();
                        if (Conexion.result["Sexo"].ToString() == radioSexo.Tag.ToString())
                        {
                            radioSexo.Checked = true;
                        }
                        else
                        {
                            radioSexo2.Checked = true;
                        }
                        dtNacimiento.Text = Conexion.result["Fecha de nacimiento"].ToString();
                        txtDirección.Text = Conexion.result["Dirección"].ToString();
                        txtCP.Text = Conexion.result["Código postal"].ToString();
                        txtTelefono.Text = Conexion.result["Teléfono"].ToString();
                        txtCorreo.Text = Conexion.result["Correo"].ToString();
                        txtRFID.Text = Conexion.result["RFID"].ToString();
                        txtNIP.Text = Conexion.result["NIP"].ToString();

                        auxMunicipio = Conexion.result["Municipio"].ToString();
                        comboEstatus.SelectedIndex = comboEstatus.FindStringExact(Conexion.result["Estatus"].ToString());
                        comboCargo.SelectedIndex = comboCargo.FindStringExact(Conexion.result["Cargo"].ToString());
                        comboPrivilegio.SelectedIndex = comboPrivilegio.FindStringExact(Conexion.result["Privilegio"].ToString());
                        comboArea.SelectedIndex = comboArea.FindStringExact(Conexion.result["Área"].ToString());
                        comboEstado.SelectedIndex = comboEstado.FindStringExact(Conexion.result["Estado"].ToString());

                    }

                    comboMunicipio.SelectedIndex = comboMunicipio.FindStringExact(auxMunicipio);

                    btnGuardar.BackgroundImage = null;
                    btnGuardar.BackgroundImage = Properties.Resources.edit1;
                    Validar.Requeridos(txts);

                    Conexion.con.Close();

                }else if (boton.Name == "btnEliminar" && MessageBox.Show("¿Eliminar registro?", "Eliminar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    check = dgv.CurrentRow.Cells[3].Value.ToString();
                    dgv.Rows.Remove(dgv.CurrentRow);

                    Conexion.Ejecutar(
                        String.Format("update empleados set id_estatus = 1 where id_empleado = '{0}'", check));

                    Mensajes.Caja("Information","Información","Registro eliminado correctamente.");
                }
            }
        }

        public class AtributosCombo
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void CargaCombos(string text0, object o, string value, string text)
        {
            var combo = o as MetroFramework.Controls.MetroComboBox;

            AtributosCombo item0 = new AtributosCombo();
            item0.Value = "0";
            item0.Text = text0;

            combo.Items.Add(item0);

            while (Conexion.result.Read())
            {
                AtributosCombo item = new AtributosCombo();

                item.Value = Conexion.result[value].ToString();
                item.Text = Conexion.result[text].ToString();

                combo.Items.Add(item);
            }
        }

        private void timerEmpleados_Tick(object sender, EventArgs e)
        {
            tiempo += 1;

            switch (tiempo)
            {
                case 1:
                    Mensajes.Caja("Information","Atención", "Cargando datos, espere por favor...");
                    dtNacimiento.Format = DateTimePickerFormat.Custom;
                    dtNacimiento.CustomFormat = "yyyy-MM-dd";

                    txts = new object[] { txtId, txtNombre, txtAP, txtAM, txtCorreo, txtDirección, txtNIP, txtRFID, txtTelefono, txtCP };
                    combos = new object[] { comboArea, comboCargo, comboEstado, comboEstatus, comboMunicipio, comboPrivilegio };

                    Validar.EvitaCP(txts);
                    Validar.EvitaCP(new object[] { txtBuscar });
                    Validar.PlaceHolderFlotante(panel1);
                    Validar.Email(txtCorreo);
                    Validar.EnteroSinFormato(new object[] { txtNIP, txtCP });
                    Validar.Enteros(new object[] { "tel", txtTelefono });
                    Validar.Letras(new object[] { txtNombre, txtAP, txtAM });

                    break;

                case 2:
                    Conexion.Paginar(
                        string.Format("select * from listarEmpleados order by num desc"),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(tablaEmpleados);
                    Actualizar();                    

                    tablaEmpleados.Columns[2].Visible = false;
                    tablaEmpleados.Columns[3].Visible = false;
                    
                    break;

                case 3:
                    Conexion.Consulta(String.Format("select * from estados"));
                    CargaCombos("Estado...", comboEstado, "id_estado", "nombre_estado");
                    Conexion.con.Close();

                    Conexion.Consulta("select * from estatus_empleados");
                    CargaCombos("Estatus...", comboEstatus, "id_estatus", "nombre_estatus");
                    Conexion.con.Close();

                    Conexion.Consulta("select * from cargos");
                    CargaCombos("Cargo...", comboCargo, "id_cargo", "nombre");
                    Conexion.con.Close();

                    Conexion.Consulta("select * from privilegios");
                    CargaCombos("Privilegios...", comboPrivilegio, "id_privilegio", "privilegio");
                    Conexion.con.Close();

                    Conexion.Consulta("select id_area, nombre from areas");
                    CargaCombos("Area...", comboArea, "id_area", "nombre");
                    Conexion.con.Close();

                    AtributosCombo item0 = new AtributosCombo();
                    item0.Value = "0";
                    item0.Text = "Municipio...";

                    comboMunicipio.Items.Add(item0);

                    SendKeys.SendWait("{ENTER}");
                    break;

                case 4:
                    foreach (var ctrl in panel1.Controls.OfType<MetroFramework.Controls.MetroComboBox>())
                    {
                        var combo = ctrl as MetroFramework.Controls.MetroComboBox;
                        combo.SelectedIndex = 0;
                    }

                    comboCantidadReg.SelectedIndex = 0;                    
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
            Funcion.TablaReadOnly(tablaEmpleados);
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
                    string.Format("select * from listarEmpleados order by num desc"),
                    "DataMember1", Convert.ToInt16(comboCantidadReg.Text));
            tablaEmpleados.DataSource = Conexion.cargar();
            tablaEmpleados.DataMember = "DataMember1";

            Actualizar();
        }
    }
}
