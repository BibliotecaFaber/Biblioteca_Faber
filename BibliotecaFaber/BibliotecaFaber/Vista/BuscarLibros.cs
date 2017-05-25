using BibliotecaFaber.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber {
    public partial class BuscarLibros : Form {

        private int i = 0;
        public BuscarLibros() {
            InitializeComponent();
        }
        Controlador.Controlador con = new Controlador.Controlador ();

        public int I {
            get => i;
            set => i = value;
        }

        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }
        private void Form1_Load(object sender, EventArgs e) {
            tablaLibros.DataSource = con.obtenerLibros (new Libro ());
            //EJEMPLO, SE DEBERÍAN SACAR DESDE LA CLASE LIBRO.ALGO
            tablaLibros.Columns [0].HeaderText = "Código del Libro";
            tablaLibros.Columns [1].HeaderText = "Nombre del libro";
            tablaLibros.Columns [2].HeaderText = "Autor";
            tablaLibros.Columns [3].HeaderText = "Editorial";
            tablaLibros.Columns [4].Visible = false;
            tablaLibros.Columns [5].Visible = false;
            tablaLibros.Columns [6].HeaderText = "Prestado";
            tablaLibros.Columns [7].Visible = false;

        }

        private void buscarClick(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace (nombrelibroTextBox.Text)) {

                string str = nombrelibroTextBox.Text;

                tablaLibros.DataSource = con.buscarLibros (new Libro (), str);
                tablaLibros.Columns [0].HeaderText = "Código del Libro";
                tablaLibros.Columns [1].HeaderText = "Nombre del libro";
                tablaLibros.Columns [2].HeaderText = "Autor";
                tablaLibros.Columns [3].HeaderText = "Editorial";
                tablaLibros.Columns [4].Visible = false;
                tablaLibros.Columns [5].Visible = false;
                tablaLibros.Columns [6].HeaderText = "Prestado";
                tablaLibros.Columns [7].Visible = false;


            } else {
                tablaLibros.DataSource = con.obtenerLibros (new Libro ());
                tablaLibros.Columns [0].HeaderText = "Código del Libro";
                tablaLibros.Columns [1].HeaderText = "Nombre del libro";
                tablaLibros.Columns [2].HeaderText = "Autor";
                tablaLibros.Columns [3].HeaderText = "Editorial";
                tablaLibros.Columns [4].Visible = false;
                tablaLibros.Columns [5].Visible = false;
                tablaLibros.Columns [6].HeaderText = "Prestado";
                tablaLibros.Columns [7].Visible = false;

                MessageBox.Show ("Ingrese un nombre de libro primero!");
            }
        }

        private void volverMenu(object sender, FormClosedEventArgs e) {
            con.buscarLibrosToMenu (this);

        }

        private void botonVolver_Clicked(object sender, EventArgs e) {
            con.buscarLibrosToMenu (this);
        }
    }
}
