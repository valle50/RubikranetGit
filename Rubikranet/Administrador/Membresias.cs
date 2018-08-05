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
        int tiempo = 0, check = 0;
        double precioPromocion = 0, iva = 0, precioTotal = 0;
        string[] arr;

        public static bool ventanaActiva = false;
        public Membresias()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timerCarga.Start();             
        }

        public static Membresias Instancia = new Membresias();

        private void Limpia()
        {
            Validar.Limpiar(new object[] { txtNombre, txtPrecio});
            numIVA.Value = 0;
            comboPromocion.SelectedIndex = 0;
            lblIVA.Text = "$0";
            lblPrecioPromo.Text = "$0";
            lblTotal.Text = "$0";

            check = 0;
            radioEstatus.Checked = false;
            radioEstatus2.Checked = false; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Calculos()
        {
            if (txtPrecio.Text != "")
            {
                int id_promo = Convert.ToInt32((comboPromocion.SelectedItem as AttrCB).Value.ToString());
                int porcentaje = 0;
                double precio = Convert.ToDouble(txtPrecio.Text.Replace(",", ""));

                Conexion.Consulta(
                    string.Format("select porcentaje_descuento from promociones where id_promocion = '{0}'", id_promo));

                while (Conexion.result.Read())
                {
                    porcentaje = Convert.ToInt32(Conexion.result["porcentaje_descuento"].ToString());
                }

                Conexion.con.Close();

                precioPromocion = precio - ((precio * porcentaje) / 100);
                lblPrecioPromo.Text = "$" + precioPromocion.ToString();

                iva = (precioPromocion * numIVA.Value) / 100;
                lblIVA.Text = "$" + iva.ToString();

                precioTotal = precioPromocion + iva;
                lblTotal.Text = "$" + precioTotal.ToString();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Calculos();
        }
        private void comboPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculos();
        }

        private void numIVA_MouseClick(object sender, MouseEventArgs e)
        {
            Calculos();
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TablaMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            string auxCosto = "", auxPromo = "";

            if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var boton = dgv.Columns[e.ColumnIndex] as DataGridViewImageColumn;

                if (boton.Name == "btnEditar" && MessageBox.Show("¿Editar registro?", "Edición de datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    check = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value);

                    Conexion.Consulta(
                        string.Format("select * from listarCategorias where id_categoria = '{0}'", check));

                    while (Conexion.result.Read())
                    {
                        txtNombre.Text = Conexion.result["Categoría"].ToString();                        
                        if (radioEstatus.Text == Conexion.result["Estatus de categoría"].ToString())
                        {
                            radioEstatus.Checked = true;
                        }
                        else
                        {
                            radioEstatus2.Checked = true;
                        }
                        numIVA.Value = Convert.ToInt32(Conexion.result["IVA"].ToString().Replace("%",""));
                        auxCosto = Conexion.result["Costo"].ToString();
                        auxPromo = Conexion.result["Promoción"].ToString();

                    }

                    txtPrecio.Text = auxCosto;

                    if (auxPromo != "Sin promoción")
                    {
                        comboPromocion.SelectedIndex = comboPromocion.FindStringExact(auxPromo);
                    }
                    else
                    {
                        comboPromocion.SelectedIndex = 0;
                    }

                    btnGuardar.BackgroundImage = null;
                    btnGuardar.BackgroundImage = Properties.Resources.edit1;

                    Conexion.con.Close();

                }
                else if (boton.Name == "btnEliminar" && MessageBox.Show("¿Eliminar registro?", "Eliminar datos.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    check = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value);
                    dgv.Rows.Remove(dgv.CurrentRow);

                    Conexion.Ejecutar(
                        String.Format("update categorias_membresias set estatus = 1 where id_categoria = '{0}'", check));

                    Mensajes.Caja("Information", "Información", "Registro eliminado correctamente.");
                    check = 0;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.Items.IndexOf("uno");
            checkedListBox1.SetItemChecked(index, true);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string busca = txtBuscar.Text.Replace(" ", "%");

            Conexion.Paginar(
                String.Format("exec buscaCategorias '{0}'", busca),
                "DataMember1",
                Convert.ToInt16(comboCantidadReg.Text));

            TablaMem.DataSource = Conexion.cargar();
            TablaMem.DataMember = "DataMember1";

            Actualizar();
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

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            tiempo += 1;

            switch (tiempo)
            {
                case 1:
                    Mensajes.Caja("Information", "Atención", "Cargando datos, espere por favor...");
                    arr = new string[] { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once" };
                    comboCantidadReg.SelectedIndex = 0;
                    checkedListBox1.Items.AddRange(arr);

                    Validar.PlaceHolderFlotante(panel1);
                    Validar.Decimales(new object[] { txtPrecio });
                    Validar.EvitaCP(new object[] { txtPrecio, txtNombre });

                    break;

                case 2:
                    Conexion.Paginar(
                        string.Format("select * from listarCategorias order by id_categoria desc"),
                        "DataMember1", 20);

                    Funcion.CargaTablaDatos_Estilos_Botones(TablaMem);
                    Actualizar();

                    TablaMem.Columns[2].Visible = false;
                    SendKeys.SendWait("{ENTER}");
                    break;

                case 3:
                    Conexion.Consulta(String.Format("select * from promociones"));
                    CargaCombos("Promoción...", comboPromocion, "id_promocion", "nombre");
                    Conexion.con.Close();

                    Conexion.Consulta(String.Format("select * from categorias_membresias"));
                    CargaCombos("Categoría...", comboCategoria, "id_categoria", "categoria");
                    Conexion.con.Close();

                    comboCategoria.SelectedIndex = 0;
                    comboPromocion.SelectedIndex = 0;
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
            Funcion.AjustaContenido(TablaMem);
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
                    string.Format("select * from listarCategorias order by id_categoria desc"),
                    "DataMember1", 20);
            TablaMem.DataSource = Conexion.cargar();
            TablaMem.DataMember = "DataMember1";

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
