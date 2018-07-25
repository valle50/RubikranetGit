using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Funciones
{
    class Mensajes
    {
        public static void Caja(string tipo,string cabecera, string contenido)
        {
            switch (tipo)
            {
                case "Information":
                    MessageBox.Show(contenido, cabecera, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case "Warning":
                    MessageBox.Show(contenido, cabecera , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Question":
                    MessageBox.Show(contenido, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "Error":
                    MessageBox.Show(contenido, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
