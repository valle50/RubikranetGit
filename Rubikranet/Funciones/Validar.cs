using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Funciones
{
    class Validar
    {
        /* Funcion para PlaceHolder cancelado, sí funciona para textbox normales, los de material skin
         * ya contienen una propiedad para realizar esta función. Por lo que esto ya no es necesario.
         * 
        public static void SetPlaceholder(object p)
        {
            var panel = p as Panel;
            foreach (var control in panel.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    var caja = control as MaterialSkin.Controls.MaterialSingleLineTextField;
                    caja.GotFocus += RemoverTexto;
                    caja.LostFocus += AgregarTexto;
                }
            }
        }

        private static void RemoverTexto(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            if (caja.Text.Contains("..."))
            {
                caja.Text = "";
            }
        }

        private static void AgregarTexto(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            if (string.IsNullOrWhiteSpace(caja.Text))
            {
                caja.Text = caja.Tag.ToString();
            }            
        }*/

        public static bool email = true, phone = true;

        //--------------------------------------------------------------------------------
        /*
         * Recibe el panel que contiene los controles de tipo TextBox, recorre cada uno
         * y les va aplicando el evento "MouseHover" dinámico llamado "ToolTipMensaje" 
         */
        public static void PlaceHolderFlotante(object p)
        {
            var panel = p as Panel;
            foreach (var control in panel.Controls.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = control as MaterialSkin.Controls.MaterialSingleLineTextField;
                caja.MouseHover += ToolTipMensaje;
            }
        }

        /*
         * Una vez aplicado este evento a todos los textbox encontrados, cada uno tendrá su toolTip
         * en el que al momento de pasar el cursor sobre ellos y mientras contengan algo, 
         * aparecerá el tooltip con el mensaje original de su placeHolder en su parte inferior.
         */
        private static void ToolTipMensaje(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            if (caja.Text != "")
            {
                int VisibleTime = 1000;
                ToolTip tt = new ToolTip();
                tt.Show(caja.Tag.ToString(), caja, 0, 20, VisibleTime);
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        /*
         * Recibe un array de objetos de los textBox a los que se les aplicará la validación
         * de solo números enteros en un evento "KeyPress" llamado "ValidaEnteros".
         * Si el array contiene un string, quiere decir que se validará para darle formato de 
         * teléfono y no de cifra.
         */

        private static int check = 0;
        public static void Enteros(object[] o)
        {
            for (var i = 0; i < o.Length; i++)
            {
                if (o[i] is string)
                {
                    check = 1;
                }
                if (check == 1 && o[i] is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    var caja = o[i] as MaterialSkin.Controls.MaterialSingleLineTextField;
                    caja.KeyPress += ValidaEnteros;
                    caja.LostFocus += FormatoTelefono;
                }
                else if (check != 1 && o[i] is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    check = 0;
                    var caja = o[i] as MaterialSkin.Controls.MaterialSingleLineTextField;
                    caja.KeyPress += ValidaEnteros;
                    caja.LostFocus += FormatoNumeros;
                }
            }
        }

        /*
         * Una vez aplicado este evento a los textbox enviados, validará que al ir escribiendo
         * solo reciba números sin punto decimal.
         */
        private static void ValidaEnteros(object sender, KeyPressEventArgs e)
        {
            var caja = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------

        public static void EnteroSinFormato(object[] o)
        {
            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                 var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                 caja.KeyPress += ValidaEnteroSinFormato;
            }
        }
        private static void ValidaEnteroSinFormato(object sender, KeyPressEventArgs e)
        {
            var caja = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        /*
         * Recibe un array de objetos de los textBox a los que se les aplicará la validación
         * de numeros con decimal en un evento "KeyPress" llamado "ValidaDecimales"
         * Y adicionalmente también se le aplica el evento "LostFocus" llamado "FormatoNumeros"
         */
        public static void Decimales(object[] o)
        {
            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                caja.KeyPress += ValidaDecimales;
                caja.LostFocus += FormatoNumeros;
            }
        }

        /*
         * Una vez aplicado este evento a los textbox enviados, validará que al ir escribiendo
         * reciba números con punto decimal.
         */
        private static void ValidaDecimales(object sender, KeyPressEventArgs e)
        {
            var caja = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && caja.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        /*
         * Se aplica este evento a los textbox a los que se les haya aplicado los eventos
         * para enteros y/o decimales, para que al momento de perder el foco, la cifra
         * numérica que contiene se le de formato.
         */
        private static void FormatoNumeros(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            if (caja.Text != "" && caja.Text.Contains("."))
            {
                double valor = Math.Round(Convert.ToDouble(caja.Text), 2);
                caja.Text = string.Format("{0:n}", valor);
            }
            else if (caja.Text != "" && !caja.Text.Contains("."))
            {
                double valor = Math.Round(Convert.ToDouble(caja.Text), 2);
                caja.Text = string.Format("{0:N0}", valor);
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        public static void Letras(object[] o)
        {
            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                caja.KeyPress += SoloLetras;
            }
        }
        private static void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        private static void FormatoTelefono(object sender, EventArgs e)
        {
            var caja = sender as TextBox;
            Int64 valor;
            string limpia = caja.Text;
            limpia = limpia.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");

            if (limpia != "" && limpia.Contains("(") && limpia.Length == 10)
            {
                valor = Convert.ToInt64(limpia);
                caja.Text = String.Format("{0:(###)-###-####}", valor);
                caja.BackColor = System.Drawing.Color.White;
                phone = true;
            }
            else if (!limpia.Contains("(") && limpia.Length == 10)
            {
                valor = Convert.ToInt64(limpia);
                caja.Text = String.Format("{0:(###)-###-####}", valor);
                caja.BackColor = System.Drawing.Color.White;
                phone = true;
            }
            else
            {
                caja.BackColor = System.Drawing.Color.LightSalmon;
                phone = false;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        /*
         * Recibe un array de objetos con los textbox a los que se les aplicará la validación
         * de que no se pueda copiar y pegar.
         */
        public static void EvitaCP(object[] o)
        {
            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                caja.MouseHover += CP;
            }
        }

        private static void CP(object sender, EventArgs ex)
        {
            var caja = sender as TextBox;
            caja.ShortcutsEnabled = false;
            caja.ContextMenu = new ContextMenu();
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        //Se obtiene el textbox para aplicarle el evento de la validación de correo.
        public static void Email(object o)
        {
            var caja = o as MaterialSkin.Controls.MaterialSingleLineTextField;
            caja.LostFocus += validarEmail;
        }
        /*
         * Se aplica este evento al textbox enviado para validar el email ingresado y
         * en caso de que sea incorrecto, al perder el foco, lanzará el mensaje de que 
         * no es correcto
         */
        private static void validarEmail(object sender, EventArgs e)
        {
            var caja = sender as TextBox;

            try
            {
                //puntos = Convert.ToInt16(caja.Text.LongCount(letra => letra.ToString() == "."));

                var addr = new System.Net.Mail.MailAddress(caja.Text);

                if (caja.Text.EndsWith(".") && caja.Text != "" || !caja.Text.EndsWith(".") && !caja.Text.Contains("."))
                {
                    caja.BackColor = System.Drawing.Color.LightSalmon;
                    email = false;
                }
                else
                {
                    caja.BackColor = System.Drawing.Color.White;
                    email = true;
                }
                //addr.Address == email bool
            }
            catch
            {
                caja.BackColor = System.Drawing.Color.LightSalmon;
                email = false;
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        public static void Limpiar(object[] o)
        {
            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                caja.Text = "";
            }
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        public static bool Requeridos(object[] o)
        {
            bool vacios = false, llenos = false;

            foreach (var ctrl in o.OfType<MaterialSkin.Controls.MaterialSingleLineTextField>())
            {
                var caja = ctrl as MaterialSkin.Controls.MaterialSingleLineTextField;
                if (caja.Text == "")
                {
                    caja.BackColor = System.Drawing.Color.LightSalmon;
                    vacios = true;
                }
                else 
                {
                    caja.BackColor = System.Drawing.Color.White;
                    llenos = true;
                }
            }            

            return (llenos && !vacios);
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        public static bool ComboRequerido(object[] o)
        {
            bool vacios = false, llenos = false;

            foreach (var ctrl in o.OfType<MetroFramework.Controls.MetroComboBox>())
            {
                var combo = ctrl as MetroFramework.Controls.MetroComboBox;
                if (combo.SelectedIndex == 0)
                {
                    vacios = true;
                }
                else
                {
                    llenos = true;
                }
            }
            return (llenos && !vacios);
        }
        //--------------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        public static void MaxLength(object o)
        {
            var caja = o as MaterialSkin.Controls.MaterialSingleLineTextField;
            caja.KeyPress += evento;                     
        }
        private static void evento(object sender, KeyPressEventArgs e)
        {
            var obj = sender as MaterialSkin.Controls.MaterialSingleLineTextField;
            MessageBox.Show(obj.AccessibleDescription.ToString());
        }
        //--------------------------------------------------------------------------------

    }
}
