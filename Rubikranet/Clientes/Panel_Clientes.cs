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
        public int limit_mem = 0;
        string check = "0", RFID = "";
        Agregar_Miembros admem = new Agregar_Miembros();

        private void Panel_Clientes_Load(object sender, EventArgs e)
        {
            
            Conexion.Paginar(string.Format("select * from CLIENTES_MEMBRESIAS order by num desc"),"DataMember1", 20);
            Funcion.CargaTablaDatos_Estilos_Botones(tablaClientes);
            Actualizar();
            tablaClientes.Columns[2].Visible = false;
            tablaClientes.Columns[3].Visible = false;
            cargarCat();
            //id_empleado = Administracion.id_empleado;
            nombre = Administracion.nombre;
            txtEmpleado.Text = nombre;
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.CustomFormat = "yyyy-MM-dd";
            dtFin.Format = DateTimePickerFormat.Custom;
            dtFin.CustomFormat = "yyyy-MM-dd";
            dtNacimiento.Format = DateTimePickerFormat.Custom;
            dtNacimiento.CustomFormat = "yyyy-MM-dd";

            Conexion.Consulta(String.Format("select * from estados"));
            CargaCombos("Estado...", selectEstado, "id_estado", "nombre_estado");
            Conexion.con.Close();

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
            addMem.cod = txtMemb.Text;
            addMem.limit_members = limit_mem;
            addMem.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cat = (selectCategoria.SelectedItem as AttrCB).Value.ToString();
            Conexion.Ejecutar(String.Format("EXEC MEMBRESIA_CU '{0}','{1}','{2}','{3}','{4}','{5}'",check,txtMembresia.Text,cat,id_empleado,dtInicio.Text,dtFin.Text));
            txtMemb.Text = txtMembresia.Text;
            limpiar();
            check = "0";
        }

        private void comboCantidadReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion.actualizaTope(Convert.ToInt16(comboCantidadReg.Text));
            Actualizar();
        }

        private void txtMemb_TextChanged(object sender, EventArgs e)
        {
            if (txtMemb.Text == "") {

                addMembers.Visible = false;
            }

            Conexion.Consulta(String.Format("EXEC VERIFICAR '{0}' ", txtMemb.Text));
            if (Conexion.result.Read() == true)
            {
                if (Convert.ToInt32(Conexion.result["id_categoria"]) == 4)
                {
                    addMembers.Visible = true;
                    admem.cod = txtMemb.Text;
                    limit_mem = 5;
                }
                else {

                    if (Convert.ToInt32(Conexion.result["id_categoria"]) == 14) {

                        addMembers.Visible = true;
                        admem.cod = txtMemb.Text;
                        limit_mem = 1;
                    }
                }
            }
            else{

                addMembers.Visible = false;
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación?", "Cancelar acción.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
                clean();
                btnGuardar.BackgroundImage = null;
                btnGuardar.BackgroundImage = Properties.Resources.diskette;
                tablaClientes.Columns[1].Visible = true;//muestra botón eliminar
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            char sexo = ' ';
            if (radioSexo.Checked)
            {
                sexo = Convert.ToChar(radioSexo.Tag);
            }
            else if (radioSexo2.Checked)
            {
                sexo = Convert.ToChar(radioSexo2.Tag);
            }

            string estado = (selectEstado.SelectedItem as AttrCB).Value.ToString();
            string municipio = (selectMunicipio.SelectedItem as AttrCB).Value.ToString();
            Conexion.Ejecutar(String.Format("EXEC MEM_CLI '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'", check, txtMemb.Text, txtNombres.Text, txtApeP.Text, txtApeM.Text, sexo, dtNacimiento.Text, txtDir.Text, txtCP.Text, estado, municipio, txtTel.Text, txtMail.Text));
            clean();

            check = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la operación?", "Cancelar acción.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiar();
                clean();
                btnGuardar.BackgroundImage = null;
                btnGuardar.BackgroundImage = Properties.Resources.diskette;
                tablaClientes.Columns[1].Visible = true;//muestra botón eliminar
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

        private void selectEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectEstado.SelectedIndex != 0)
            {
                selectMunicipio.Items.Clear();
                Conexion.Consulta(
                    String.Format("select * from municipios where id_estado = {0}", (selectEstado.SelectedItem as AttrCB).Value.ToString()));

                CargaCombos("Municipio...", selectMunicipio, "id_municipio", "nombre_municipio");
                selectMunicipio.SelectedIndex = 0;
            }
            else
            {
                selectMunicipio.Items.Clear();
                AttrCB item0 = new AttrCB();
                item0.Value = "0";
                item0.Text = "Municipio...";

                selectMunicipio.Items.Add(item0);
                selectMunicipio.SelectedIndex = 0;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busca = txtBuscar.Text.Replace(" ", "%");

            Conexion.Paginar(
                String.Format("exec CLIENTES_MEMBRESIAS '{0}'", busca),
                "DataMember1",
                Convert.ToInt32(comboCantidadReg.Text));

            tablaClientes.DataSource = Conexion.cargar();
            tablaClientes.DataMember = "DataMember1";

            Actualizar();
        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            
            if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Aquí el check toma el id del empleado de la columna que se ocultó y que se encuentra en la posición 3... (Se ocultaron en la carga) 
                    //El 0 es el botón editar, 1 = btnEliminar, 2 = columna "num" y 3 = columna "id_empleado", los últimos dos se ocultaron, pero siguen ahí

                    tablaClientes.Columns[1].Visible = false;//oculta botón eliminar
                    RFID = dgv.CurrentRow.Cells[3].Value.ToString();

                    Conexion.Consulta(
                        string.Format("EXEC SEE_MEMBER '{0}'", RFID));

                    while (Conexion.result.Read())
                    {
                        txtMembresia.Text = Conexion.result["Membresia"].ToString();
                        selectCategoria.SelectedIndex = selectCategoria.FindStringExact(Conexion.result["Categoria"].ToString());
                        txtEmpleado.Text = Conexion.result["Empleado"].ToString();
                        dtInicio.Text = Conexion.result["Inicio"].ToString();
                        dtFin.Text = Conexion.result["Fin"].ToString();

                    }

                    check = "1";
                    btnGuardar.BackgroundImage = null;
                    btnGuardar.BackgroundImage = Properties.Resources.edit1;
                    Conexion.con.Close();

                }
                else if (boton.Name == "btnEliminar" && MessageBox.Show("¿Eliminar registro?", "Eliminar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    RFID = dgv.CurrentRow.Cells[3].Value.ToString();
                    dgv.Rows.Remove(dgv.CurrentRow);


                    Conexion.Ejecutar(
                        String.Format("update clientes set estatus = 1  where id_membresia = '{0}'", RFID));

                    /*Conexion.Ejecutar(
                        String.Format("update membresias set estatus = 1 where id_membresia = '{0}'", RFID));
                        */

                    Mensajes.Caja("Information", "Información", "Registro eliminado correctamente.");
                    check = "0";
                }
            }
        }





        void limpiar() {

            foreach (var ctrl in panel1.Controls.OfType<MetroFramework.Controls.MetroComboBox>())
            {
                var combo = ctrl as MetroFramework.Controls.MetroComboBox;
                combo.SelectedIndex = 0;
            }
            selectCategoria.SelectedIndex = 0;

            dtInicio.Value = DateTime.Now;
            dtFin.Value = DateTime.Now;
          
            comboCantidadReg.SelectedIndex = 0;

            txtMembresia.Text = "";
            txtEmpleado.Text = "";

        }

        void clean(){

            check = "0";
            txtMemb.Text = "";
            txtNombres.Text = "";
            txtApeP.Text = "";
            txtApeM.Text = "";
            radioSexo.Checked = false;
            radioSexo2.Checked = false;
            dtNacimiento.Value = DateTime.Now;
            txtDir.Text = "";
            txtCP.Text = "";
            selectEstado.SelectedIndex = 0;
            selectMunicipio.SelectedIndex = 0;
            txtTel.Text = "";
            txtMail.Text = "";
        }

       
    }
}
