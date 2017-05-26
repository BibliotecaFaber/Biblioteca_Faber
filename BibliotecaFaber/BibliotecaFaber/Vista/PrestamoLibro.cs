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
    public partial class PrestamoLibro : Form {

        DataTable dtcopy = new DataTable();
        Controlador.Controlador con = new Controlador.Controlador ();

        public PrestamoLibro() {
            InitializeComponent();
        }

        private void prestamoLibro_CLOSED(object sender, FormClosedEventArgs e) {
            con.prestamoLibroToMenu (this);
        }

        private void volverMenu(object sender, EventArgs e) {
            con.prestamoLibroToMenu (this);
        }

        private void buttonConfirmar_Clicked(object sender, EventArgs e) {

            if (!runTextBox.Text.ToString().Equals("")) {
                string run = runTextBox.Text.ToString ();
                run = validaRUN (run);
                DataTable dt = con.buscarCliente (run);
                try {
                    string dtRUN = dt.Rows [0].Field<string> ("RUN_CLIENTE");
                    if (dtRUN.Equals(run)) {
                        MessageBox.Show ("Todo calza pollo");
                    }
                } catch (Exception) {
                    MessageBox.Show ("El rut ingresado no pertenece a ningún cliente ingresado.");
                }

            }

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

        private void PrestamoLibro_Load(object sender, EventArgs e) {
            updateTabla ();
            DataTable dt = new DataTable() ;
            updateTablaLibrosAPrestar (dt);
        }

        private void updateTabla() {
            
            tablaLibros.DataSource = con.obtenerLibrosDisponibles (new Libro ());
            tablaLibros.MultiSelect = false;
            tablaLibros.Columns [0].HeaderText = "Codigo del Libro";
            tablaLibros.Columns [1].HeaderText = "Nombre";
            tablaLibros.Columns [2].HeaderText = "Autor";
            tablaLibros.Columns [3].HeaderText = "Editorial";
            tablaLibros.Columns [4].Visible = false; // fila
            tablaLibros.Columns [5].Visible = false; // columna
            tablaLibros.Columns [6].Visible = false;

        }

        private void updateTablaLibros(DataTable dt) {

            tablaLibros.DataSource = dt;
            tablaLibros.MultiSelect = false;
            tablaLibros.Columns [0].HeaderText = "Codigo del Libro";
            tablaLibros.Columns [1].HeaderText = "Nombre";
            tablaLibros.Columns [2].HeaderText = "Autor";
            tablaLibros.Columns [3].HeaderText = "Editorial";
            tablaLibros.Columns [4].Visible = false; // fila
            tablaLibros.Columns [5].Visible = false; // columna
            tablaLibros.Columns [6].Visible = false;

        }
        private void updateTablaLibrosAPrestar(DataTable dt) {
            if (dt!=null && dt.Rows.Count>0) {

                tablaLibrosParaPrestar.DataSource = dt;
                tablaLibrosParaPrestar.MultiSelect = false;
                tablaLibrosParaPrestar.Columns [0].HeaderText = "Codigo del Libro";
                tablaLibrosParaPrestar.Columns [1].HeaderText = "Nombre";
                tablaLibrosParaPrestar.Columns [2].HeaderText = "Autor";
                tablaLibrosParaPrestar.Columns [3].HeaderText = "Editorial";
                //tablaLibrosParaPrestar.Columns [4].Visible = false; // fila
                //tablaLibrosParaPrestar.Columns [5].Visible = false; // columna
                //tablaLibrosParaPrestar.Columns [6].Visible = false;
            } else {
                if (!dt.Columns.Contains ("Código del Libro") && !dt.Columns.Contains ("Nombre")
                    && !dt.Columns.Contains ("Autor") && !dt.Columns.Contains ("Editorial")) {
                    dt.Columns.Add ("Código del Libro", typeof (string));
                    dt.Columns.Add ("Nombre", typeof (string));
                    dt.Columns.Add ("Autor", typeof (string));
                    dt.Columns.Add ("Editorial", typeof (string));
                }

                tablaLibrosParaPrestar.DataSource = dt;
                tablaLibrosParaPrestar.MultiSelect = false;
            }

        }



        private void tablaLibros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

        }
        //bs
        private void tablaLibros_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {

                ContextMenu m = new ContextMenu ();
                
                int currentRow = tablaLibros.HitTest (e.X, e.Y).RowIndex;

                if (currentRow >= 0) {
                    m.MenuItems.Add (new MenuItem ("Agregar Libro"));
                    m.MenuItems.Add (new MenuItem ("Quitar Libro"));

                }

                m.Show (tablaLibros, new Point (e.X, e.Y));
            }
        }
        //bs
        private void pictureBox2_Click(object sender, EventArgs e) {

        }
        //TODO
        private void buttonNoPrestar_Click(object sender, EventArgs e) {
            DataTable dt = (DataTable) tablaLibros.DataSource;
            DataTable dtcpy = (DataTable) tablaLibrosParaPrestar.DataSource;

            if (dtcpy.Rows.Count == 0) {
                MessageBox.Show ("Deben existir libros en la tabla Libros a Prestar " +
                    "antes de intentar devolverlos a Libros Disponibles.");
            } else {
                int row = tablaLibrosParaPrestar.CurrentCell.RowIndex;

                for (int i = 0; i < dtcpy.Rows.Count; i++) {
                    if (i == row) {
                        Object cellvalue = dtcpy.Rows [i] [0];
                        DataRow dr = dtcpy.Rows [i];
                        dt.ImportRow (dr);
                        dtcpy.Rows.Remove (dr);
                        int n = dt.Rows.Count;
                        dt.Rows [--n] [0] = int.Parse (cellvalue.ToString ());
                    }
                }

                updateTablaLibros (dt);
                updateTablaLibrosAPrestar (dtcopy);
            }


        }

        private void buttonPrestar_Click(object sender, EventArgs e) {
            DataTable dt = (DataTable) tablaLibros.DataSource;

            int row = tablaLibros.CurrentCell.RowIndex;
             dtcopy = dt.Clone ();
             dtcopy = (DataTable) tablaLibrosParaPrestar.DataSource;
            //dtcopy = (DataTable) tablaLibrosParaPrestar.DataSource;
            if (dtcopy.Rows.Count >= 3) {
                MessageBox.Show ("El máximo de libros a pedir es 3.");
            } else {
                for (int i = 0; i < dt.Rows.Count; i++) {
                    if (i == row) {
                        Object cellvalue = dt.Rows [i] [0];
                        DataRow dr = dt.Rows [i];
                        dtcopy.ImportRow (dr);
                        dt.Rows.Remove (dr);
                        int n = dtcopy.Rows.Count;
                        dtcopy.Rows [--n] [0] = int.Parse(cellvalue.ToString ());
                    }
                }
                }

            updateTablaLibros (dt);
            updateTablaLibrosAPrestar (dtcopy);
        }

        private void tablaLibrosParaPrestar_SelectionChanged(object sender, EventArgs e) {
            if (tablaLibrosParaPrestar.CurrentCell != null) {
                buttonNoPrestar.Enabled = true;
            } else {
                buttonNoPrestar.Enabled = false;
            }
        }

        private void tablaLibros_SelectionChanged(object sender, EventArgs e) {
            if (tablaLibros.CurrentCell != null) {

                buttonPrestar.Enabled = true;

            } else {
                buttonPrestar.Enabled = false;
            }
        }

        private void buttonRealizarPrestamo_Click(object sender, EventArgs e) {
            string run = runTextBox.Text;
            if (!String.IsNullOrWhiteSpace(run) && !String.IsNullOrEmpty(run)) {
                DataTable dt = con.buscarCliente(run);

                if (dt.Rows.Count != 0) {
                    Cliente c = new Cliente ();
                    c.Run = dt.Rows [0] [0].ToString ();
                    c.Nombre = dt.Rows [0] [1].ToString ();
                    c.Edad = int.Parse (dt.Rows [0] [2].ToString ());
                    c.Telefono = dt.Rows [0] [3].ToString ();
                    c.Email = dt.Rows [0] [4].ToString ();

                    DataTable libros = (DataTable) tablaLibrosParaPrestar.DataSource;

                    if (libros.Rows.Count != 0) {
                        string sql = "INSERT INTO PRESTAMO VALUES (null, 0,'" + c.Run + "', "
                            + libros.Rows[0][0];
                        if (libros.Rows.Count == 3) {
                            for (int i = 1; i < libros.Rows.Count; i++) {
                                sql += ", " + libros.Rows [i] [0];
                            }
                        } else if (libros.Rows.Count == 2) {
                            for (int i = 1; i < libros.Rows.Count; i++) {
                                sql += ", " + libros.Rows [i] [0];
                            }
                            sql += ", null";
                        } else {
                            sql += ",null, null";
                        }


                        sql += ");";

                        con.crearPrestamo (sql);

                    } else {
                        MessageBox.Show ("Deben existir libros en la tabla Libros a Prestar.");
                    }

                } else {
                    MessageBox.Show ("No existe un cliente con el rut ingresado.");
                }




            } else {
                MessageBox.Show ("Debe ingresar el rut del cliente.");
            }
        }
    }
}
