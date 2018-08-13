using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using MetroSet_UI.Controls;

namespace Rubikranet.Clientes
{
    public partial class Agregar_Miembros : MaterialSkin.Controls.MaterialForm
    {
        public Agregar_Miembros()
        {
            InitializeComponent();
        }

        public int num_cli = 1;
        public string cod = "" , check = "0";
        public int status = 1, limit_members = 0;


        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            Conexion.Consulta(String.Format("select * from precio_por_miembro"));
            CargaCombos("Precios...", selectPrecios, "id_precio_miembro", "precio_extra");
            Conexion.con.Close();
 
            txtMembre.Text = cod;

            Conexion.Consulta(String.Format("EXEC CONTAR '{0}'", cod));
            if (Conexion.result.Read()) {

                num_cli = Convert.ToInt32(Conexion.result["Registros"]);
                num_cli = num_cli + 1;
                Conexion.con.Close();
            }

            lblNum.Text = "Miembro # " + num_cli;
            lblmiembros.Text = "Puedes agregar hasta " + limit_members + " miembros:";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (num_cli > limit_members)
            {
                lblNum.Text = "Miembros al máximo ";
                MessageBox.Show("Limite de Miembros Completos");
            }
            else
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

                string price = (selectPrecios.SelectedItem as AttrCB).Value.ToString();

                Conexion.Ejecutar(String.Format("EXEC addMEMBERS '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' ", check, txtMembre.Text, txtMembreFam.Text, txtNombres.Text, txtAP.Text, txtAM.Text, sexo, price, status));

                num_cli = num_cli + 1;
                lblNum.Text = "Miembro # " + num_cli;
                limpiar();
            }

        }

        private void txtMembre_TextChanged(object sender, EventArgs e)
        {

        }

        void limpiar() {

            txtMembreFam.Text = "";
            txtNombres.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            selectPrecios.SelectedIndex = 0;
            check = "0";
            radioSexo.Checked = false;
            radioSexo2.Checked = false;
        }
    }
}
