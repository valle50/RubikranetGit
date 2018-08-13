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
        public string cod = "";
        public int status = 1;


        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            Conexion.Consulta(String.Format("select * from precio_por_miembro"));
            CargaCombos("Precios...", selectPrecios, "id_precio_miembro", "precio_extra");
            Conexion.con.Close();

            lblNum.Text = "Miembro # " + num_cli;
            txtMembre.Text = cod;
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
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            Conexion.Ejecutar(String.Format("EXEC addMEMBERS '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}' ", txtMembre.Text,txtMembreFam.Text,txtNombres.Text,txtAP.Text,txtAM.Text,sexo,price,status));
        }
    }
}
