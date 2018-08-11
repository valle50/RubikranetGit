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
        int tiempo = 10;
        public string puerto;
        string codigo = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            serialPort.PortName = puerto;
            serialPort.Open();
            timer.Start();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txt_RFID.Text != "" && txt_NIP.Text != "")
            {
                Conexion.Consulta(
                    string.Format("select * from empleados where rfid = '{0}' and nip = '{1}' and id_privilegio = 1 or rfid = '{0}' and nip = '{1}' and id_privilegio = 2", txt_RFID.Text, txt_NIP.Text.Replace("'", "`")));

                if (Conexion.result.HasRows)
                {
                    string nombre = "", id_privilegio = "", id_empleado = "";

                    while (Conexion.result.Read())
                    {
                        id_empleado = Conexion.result["id_empleado"].ToString();
                        nombre = Conexion.result["nombre"].ToString();
                        id_privilegio = Conexion.result["id_privilegio"].ToString();
                    }
                    
                    Administracion admin = new Administracion();
                    this.Hide();
                    Administracion.nombre = nombre;
                    Administracion.id_privilegio = id_privilegio;
                    Administracion.id_empleado = id_empleado;

                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    Mensajes.Caja("Error","Sin resultados", "RFID y/o PIN incorrecto(s)");
                }                
            }
            else
            {
                Mensajes.Caja("Warning", "Campos requeridos.", "Los campos deben estar llenos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Acceso access = new Acceso();
            serialPort.Close();
            this.Hide();
            access.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (codigo != "")
            {                
                txt_RFID.Text = codigo;
                //this.ActiveControl = txt_NIP;
                codigo = "";
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            codigo = serialPort.ReadLine().Trim();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Acceso access = new Acceso();
            serialPort.Close();
            this.Hide();
            access.ShowDialog();
        }
    }
}
