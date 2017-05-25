using BibliotecaFaber.Modelo;
using BibliotecaFaber.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber.Vista {
    public partial class GestionLibros : Form {
        public GestionLibros() {
            InitializeComponent();
        }
        Controlador.Controlador con = new Controlador.Controlador();

        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador) cc;
        }
        private void GestionLibros_Load(object sender, EventArgs e) {
            updateTabla();
        }
        private void updateTabla() {
            tblLibros.DataSource = con.obtenerLibros(new Libro(0,"","","",0,0));
            tblLibros.Columns[0].HeaderText = "Codigo Libro";
            tblLibros.Columns[1].HeaderText = "Nombre";
            tblLibros.Columns[2].HeaderText = "Autor";
            tblLibros.Columns[3].HeaderText = "Editorial";
            tblLibros.Columns[4].Visible = false; //Fila
            tblLibros.Columns[5].Visible = false; //Columna
            //tblLibros.Columns[6].HeaderText = "En Prestamo";
            tblLibros.Columns[6].Visible = false;
            tblLibros.Columns[7].Visible = false; //Id Estante (DEP)
            //tblLibros.Columns[1].HeaderText = "";
            tblLibros.Rows[0].Selected = true;
        }

        private void GestionLibros_FormClosed(object sender, FormClosedEventArgs e) {
            con.gestionToMenu (this);
        }

        private void boton_volver(object sender, EventArgs e) {
            con.gestionToMenu (this);
        }

        private void picAgregar_Click(object sender, EventArgs e) {
            int id = 0;
            if (int.TryParse(txtCodigo.Text, out id)) {
                if (filat != 10 && columnat != 10) {
                    con.insertLibro(new Libro(id, txtNombre.Text, txtAutor.Text, txtEditorial.Text, filat, columnat));
                    updateTabla();
                } else {
                    MessageBox.Show("Ingrese Fila y Columna Valida");
                }

            } else {
                MessageBox.Show("Ingrese Codigo Valido");
            }
        }

        private void tblLibros_SelectionChanged(object sender, EventArgs e) {
            if (tblLibros.CurrentCell != null) {
                int row = tblLibros.CurrentCell.RowIndex;
                txtCodigo.Text = tblLibros.Rows[row].Cells[0].Value.ToString();
                txtNombre.Text = tblLibros.Rows[row].Cells[1].Value.ToString();
                txtAutor.Text = tblLibros.Rows[row].Cells[2].Value.ToString();
                txtEditorial.Text = tblLibros.Rows[row].Cells[3].Value.ToString();
                string fila = tblLibros.Rows[row].Cells[4].Value.ToString();
                string col = tblLibros.Rows[row].Cells[5].Value.ToString();
                string Pos_Tabla = fila + "_" + col;
                txtUbicacion.Text = fila + "," + col;
                ResourceManager rm = Resources.ResourceManager;
                Bitmap tabla = (Bitmap)rm.GetObject(Pos_Tabla);
                tablaEstante.Image = tabla;
                if(tblLibros.Rows[row].Cells[6].Value.ToString() != "") {
                    int pres = int.Parse(tblLibros.Rows[row].Cells[6].Value.ToString());
                    chkPrestamo.Checked = (pres == 0 ? false : true);
                }
                
                //emailTextBox.Text = tblClientes.Rows[row].Cells[4].Value.ToString();
            }
        }

        private void tblLibros_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        int filat = 0;
        int columnat = 0;
        private void txtUbicacion_TextChanged(object sender, EventArgs e) {
            string[] test = txtUbicacion.Text.Split(',');
            int f, c;
            if (test.Length >1) {
                if (int.TryParse(test[0], out f) && int.TryParse(test[1], out c)) {
                    ResourceManager rm = Resources.ResourceManager;
                    Bitmap tabla = (Bitmap)rm.GetObject(f + "_" + c);
                    tablaEstante.Image = tabla;
                    filat = f;
                    columnat = c;
                } else {
                    ResourceManager rm = Resources.ResourceManager;
                    Bitmap tabla = (Bitmap)rm.GetObject("error_tabla");
                    tablaEstante.Image = tabla;
                    filat = 10;
                    columnat = 10;
                }
            }

        }

        private void picModificar_Click(object sender, EventArgs e) {
            int row = tblLibros.CurrentCell.RowIndex;
            int id = 0;
            if (int.TryParse(txtCodigo.Text, out id)) {
               int codigo = int.Parse(tblLibros.Rows[row].Cells[0].Value.ToString());
                if (filat != 10 && columnat != 10) {
                    con.modificarLibro(new Libro(codigo, txtNombre.Text, txtAutor.Text, txtEditorial.Text, filat, columnat), id);
                    //Falta validar rut al hacer esto, esperando el commit que lo trae para conectarlo
                    updateTabla();
                } else {
                    MessageBox.Show("Ingrese Fila y Columna Valida");
                }
                
            } else {
                MessageBox.Show("Ingrese Codigo Valido");
            }
        }
    }
}
