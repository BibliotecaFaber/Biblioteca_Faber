using BibliotecaFaber.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber.Vista {
    public partial class DevolverLibros :Form {

        Controlador.Controlador con = new Controlador.Controlador ();
        public DevolverLibros() {
            InitializeComponent ();
        }

        private void DevolverLibros_FormClosed(object sender, FormClosedEventArgs e) {
            new Controlador.Controlador ().devolverLibroToMenu (this);
        }

        public void updateTabla() {

            tablaPrestamos.DataSource = con.mostrarPrestamos (new Prestamo());

            tablaPrestamos.Columns [0].HeaderText = "Número de Prestamo";
            tablaPrestamos.Columns [1].Visible = false; // Estado prestamo;
            tablaPrestamos.Columns [2].HeaderText = "RUN del Cliente";
            tablaPrestamos.Columns [3].HeaderText = "ID del Libro";
            tablaPrestamos.Columns [4].HeaderText = "ID del Libro (2)";
            tablaPrestamos.Columns [5].HeaderText = "ID del Libro(3)";

        }
        public void updateTabla(DataTable dt) {
            tablaPrestamos.DataSource = dt;
            tablaPrestamos.Columns [0].HeaderText = "Número de Prestamo";
            tablaPrestamos.Columns [1].Visible = false; // Estado prestamo;
            tablaPrestamos.Columns [2].HeaderText = "RUN del Cliente";
            tablaPrestamos.Columns [3].HeaderText = "ID del Libro";
            tablaPrestamos.Columns [4].HeaderText = "ID del Libro (2)";
            tablaPrestamos.Columns [5].HeaderText = "ID del Libro(3)";

        }

        private void DevolverLibros_Load(object sender, EventArgs e) {
            updateTabla ();
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e) {
            string run = runTextBox.Text;

            if (!String.IsNullOrEmpty (run) && !String.IsNullOrWhiteSpace (run)) {
                //MessageBox.Show ("Funciona");
                run = validaRUN (run);

                DataTable cliente = con.buscarCliente (run);

                if (cliente.Rows.Count != 0) {
                    DataTable prestamos = con.buscarPrestamo (new Prestamo (), run);
                    updateTabla (prestamos);
                } else {
                    MessageBox.Show ("No se encuentra un prestamo asociado al cliente con RUN: "+ run);
                }

                
            } else {
                updateTabla ();
                MessageBox.Show ("Debes ingresar un RUN antes de intentar filtrar prestamos.");
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e) {
            con.devolverLibroToMenu (this);
        }

        private string validaRUN(string run) {


            bool validacion = false;

            try {
                run = run.ToUpper ();
                run = run.Replace (".", "");
                run = run.Replace ("-", "");

                int aux = int.Parse (run.Substring (0, run.Length - 1));

                char dv = char.Parse (run.Substring (run.Length - 1, 1));

                int m = 0, s = 1;

                for (; aux != 0; aux /= 10) {
                    s = (s + aux % 10 * (9 - m++ % 6)) % 11;
                }

                if (dv == (char) (s != 0 ? s + 47 : 75)) {
                    validacion = true;
                }


            } catch (Exception) {

            }

            return run;
        }

        private void buttonDevolverLibro_Click(object sender, EventArgs e) {

            int row = tablaPrestamos.CurrentCell.RowIndex;

            DataTable dt = (DataTable) tablaPrestamos.DataSource;

            int id_prestamo = int.Parse(dt.Rows [row] [0].ToString());

            int libro1 = int.Parse (dt.Rows [row] [3].ToString ());

            string updateLibro = "UPDATE LIBRO SET EN_PRESTAMO = 0 WHERE ID_LIBRO = ";
            string updL = updateLibro + libro1 + ";";
            con.updateLibro (new Libro (), updL);
            
            if (!String.IsNullOrEmpty (dt.Rows [row] [4].ToString ())) {
                int libro2 = int.Parse (dt.Rows [row] [4].ToString ());
                updL = updateLibro + libro2 + ";";
                con.updateLibro (new Libro (), updL);
            }
            if (!String.IsNullOrEmpty(dt.Rows [row] [5].ToString ())) {
                int libro3 = int.Parse (dt.Rows [row] [5].ToString ());
                updL = updateLibro + libro3 + ";";
                con.updateLibro (new Libro (), updL);
            }

            string sql = "UPDATE PRESTAMO SET ESTADO_PRESTAMO = 1 WHERE ID_PRESTAMO = " + id_prestamo + ";";

            con.updatePrestamo (new Prestamo (), sql);
            updateTabla ();

        }

        private void tablaPrestamos_SelectionChanged(object sender, EventArgs e) {
            if (tablaPrestamos.CurrentCell != null) {
                buttonDevolverLibro.Enabled = true;
            } else {
                buttonDevolverLibro.Enabled = false;
            }
        }
    }
}
