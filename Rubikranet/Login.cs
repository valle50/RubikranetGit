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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        int tiempo;
        public string puerto;
        string codigo;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //serialPort.PortName = puerto;
            //serialPort.Open();
            //tiempo = 10;
            //txt_RFID.Enabled = true;
            //txt_RFID.Focus();
            //txt_NIP.Enabled = true;
            timer.Start();
        }

        void conteo()
        {
            //if (tiempo >= 0)
            //{
            //    mensaje_segundos.Text = "Tienes " + tiempo + " segundos para ingresar tus datos:";
            //    tiempo = tiempo - 1;
            //}
            //else
            //{
            //    txt_RFID.Enabled = false;
            //    txt_NIP.Enabled = false;
            //    timer.Stop();
            //    serialPort.Close();
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_RFID.Text != "" && txt_NIP.Text != "")
            {
                Administracion admin = new Administracion();
                Acceso access = new Acceso();
                access.Hide();
                this.Hide();
                admin.ShowDialog();
                access.Close();
                this.Close();
            }
            else {
                Mensajes.Caja("Warning","Campos requeridos.","Los campos deben estar llenos.");
            }          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Acceso access = new Acceso();
            //serialPort.Close();
            this.Hide();
            access.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //conteo();
            //txt_RFID.Text = codigo;

            //if (txt_RFID.Text == ""){

            //}
            //else {

            //    txt_NIP.Focus();
            //}
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //codigo = serialPort.ReadLine().Trim();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Acceso access = new Acceso();
            //serialPort.Close();
            this.Hide();
            access.ShowDialog();
        }
    }
}
