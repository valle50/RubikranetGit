using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rubikranet
{
    class Conexion
    {
        public static SqlConnection con; //variable de conexión
        public static SqlDataReader result; // variable pública que contendrá los valores devueltos de una consulta del método Consulta().

        //private String  ps_cadena= "data source =VAIO-PC;initial catalog = AdventureWorks2012; user id =sa;password =123";
        private static String cadenaConexion = "Data Source=DESKTOP-MUTGHBB\\SQLSERVER;Initial Catalog=membresias_club;Integrated Security=True";


        private static int inicio = 0;
        private static int tope = 0;

        private static int numeroPagina = 1;
        private static int cantidadRegistros = 0;
        private static int ultima_Pagina = 0;

        private static string datamember;
        private static SqlDataAdapter dataAdapter;
        private static DataSet datos;

        public static void Ejecutar(string comando)
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();

                SqlCommand query = con.CreateCommand();
                query.CommandText = comando;

                int AffectedRows = query.ExecuteNonQuery();

                var result = AffectedRows > 0 ? 0 : MessageBox.Show("No se ejecutó correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Ejecutar()': " + e.ToString(), "Error de base de datos.");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public static void Consulta(string comando)
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();

                SqlCommand query = con.CreateCommand();
                query.CommandText = comando;

                result = query.ExecuteReader();

            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Consulta()': " + e.ToString(), "Error de base de datos.");
            }
        }


        //s_query:          El query de conexion
        //sdatamember:     se asigna al datagridview despues del datasource
        //i_canidadxpagina: cantidad de registros por pagina
        public static void Paginar(string s_query, string sdatamember, int i_cantidadxpagina)
        {
            try
            {
                inicio = 0;
                tope = i_cantidadxpagina;
                datamember = sdatamember;

                DataTable DT;

                con = new SqlConnection(cadenaConexion);

                dataAdapter = new SqlDataAdapter(s_query, con);
                datos = new DataSet();
                DT = new DataTable();

                con.Open();
                dataAdapter.Fill(datos, inicio, tope, datamember);
                dataAdapter.Fill(DT);
                con.Close();
                cantidadRegistros = DT.Rows.Count;

                asignarTope();
            }
            catch (Exception e)
            {
                MessageBox.Show("Se generó un error en 'Paginar()': \n" + e.ToString());
            }
        }

        private static void asignarTope()
        {
            ultima_Pagina = cantidadRegistros / tope;


            int aux = cantidadRegistros % tope;
            if (ultima_Pagina == 0)
            {
                ultima_Pagina = 1;
            }
            else if (ultima_Pagina >= 1 && (aux > 0))
            {
                ultima_Pagina = ultima_Pagina + 1;
            }

            numeroPagina = 1;
        }

        public static DataSet cargar()
        {
            return datos;
        }

        public static DataSet primeraPagina()
        {
            numeroPagina = 1;
            inicio = 0;
            datos.Clear();
            dataAdapter.Fill(datos, inicio, tope, datamember);

            return datos;
        }

        public static DataSet ultimaPagina()
        {
            numeroPagina = ultima_Pagina;
            inicio = (ultima_Pagina - 1) * tope;
            datos.Clear();
            dataAdapter.Fill(datos, inicio, tope, datamember);

            return datos;
        }

        public static DataSet atras()
        {
            if (numeroPagina == 1)
            {
                return datos;
            }

            numeroPagina--;
            inicio = inicio - tope;
            datos.Clear();
            dataAdapter.Fill(datos, inicio, tope, datamember);

            return datos;
        }

        public static DataSet adelante()
        {
            if (ultima_Pagina == numeroPagina)
            {
                return datos;
            }

            numeroPagina++;
            inicio = inicio + tope;
            datos.Clear();
            dataAdapter.Fill(datos, inicio, tope, datamember);

            return datos;
        }

        public static DataSet actualizaTope(int itope)
        {
            tope = itope;
            inicio = 0;
            asignarTope();

            if (datos != null)
            {
                datos.Clear();
                dataAdapter.Fill(datos, inicio, tope, datamember);
            }
            return datos;
        }


        public static int countRow()
        {
            return cantidadRegistros;
        }

        public static int countPag()
        {
            return ultima_Pagina;
        }

        public static int numPag()
        {
            return numeroPagina;
        }

        public static int limitRow()
        {
            return tope;
        }
    }
}
