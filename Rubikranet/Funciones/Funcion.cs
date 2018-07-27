using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet.Funciones
{
    class Funcion
    {
        public static void CargaTablaDatos_Estilos_Botones(object a)
        {
            var Tabla = a as DataGridView;

            //Agrega botón imagen editar
            DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
            btnEditar.Image = Properties.Resources.edit;
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Editar";
            Tabla.Columns.Add(btnEditar);
            //Agrega botón imagen editar

            //Agrega botón imagen eliminar
            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
            btnEliminar.Image = Properties.Resources.cross;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            Tabla.Columns.Add(btnEliminar);
            //Agrega botón imagen eliminar

            //Carga datos a la tabla
            Tabla.DataSource = Conexion.cargar();
            Tabla.DataMember = "DataMember1";
            //Carga datos a la tabla    

            Tabla.Columns[0].Frozen = true;
            Tabla.Columns[1].Frozen = true;

            //estilo
            Tabla.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(135, 206, 250);
            Tabla.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            Tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Tabla.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Tabla.DefaultCellStyle.SelectionForeColor = Color.Black;
            Tabla.BackgroundColor = Color.White;

            Tabla.EnableHeadersVisualStyles = false;
            Tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Tabla.DefaultCellStyle.Font = new Font("Century Gothic", 9);
            //estilo

            /*Código para agregar botón*/
            //DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            //btn.Text = "Editar";
            //btn.HeaderText = "tf54tg45";
            //btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //btn.UseColumnTextForButtonValue = true;
            /*Código para agregar botón*/
        }

        public static void AjustaContenido(object a)
        {
            var Tabla = a as DataGridView;

            for (var i = 0; i < Tabla.RowCount; i++)
            {
                for (var j = 0; j < Tabla.ColumnCount; j++)
                {
                    Tabla.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    Tabla.Rows[i].Height = 30;
                }
            }
        }

    }
}
