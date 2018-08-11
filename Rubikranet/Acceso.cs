using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MetroSet_UI;
using MetroSet_UI.Controls;
using System.IO.Ports;
using Rubikranet.Funciones;

namespace Rubikranet
{
    public partial class Acceso : MaterialSkin.Controls.MaterialForm
    {
        public Acceso()
        {
            InitializeComponent();
        }
       
        void conexion_puertos() {

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) {
                select_puertos.Items.Add(port);
             }
        }
        private void Acceso_Load(object sender, EventArgs e)
        {
            conexion_puertos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            select_puertos.Items.Clear();
            conexion_puertos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (select_puertos.Text != "")
            {
                Login login = new Login();
                login.puerto = select_puertos.Text;
                this.Hide();
                login.ShowDialog();
                this.Close();                
            }
            else {
                Mensajes.Caja("Information","Aviso.","Debe seleccionar un puerto para poder continuar.");
            }   
        }
    }
}
