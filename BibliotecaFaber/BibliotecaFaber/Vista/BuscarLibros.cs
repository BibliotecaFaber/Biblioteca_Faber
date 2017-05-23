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

namespace BibliotecaFaber {
    public partial class BuscarLibros : Form {
        public BuscarLibros() {
            InitializeComponent();
        }
        Controlador.Controlador con = new Controlador.Controlador ();
        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }
        private void Form1_Load(object sender, EventArgs e) {
            tablaLibros.DataSource = con.conexion.getQuery("SELECT * FROM LIBRO");
            //EJEMPLO, SE DEBERÍAN SACAR DESDE LA CLASE LIBRO.ALGO
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void volverMenu(object sender, FormClosedEventArgs e) {
            con.buscarLibrosToMenu (this);

        }
    }
}
