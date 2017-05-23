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
    public partial class GestionClientes : Form {

        Controlador.Controlador con = new Controlador.Controlador ();

        public GestionClientes() {
            InitializeComponent();

        }

        private void volverMenu(object sender, EventArgs e) {
            con.gestionClienteToMenu (this);
        }

        private void gestionCliente_closed(object sender, FormClosedEventArgs e) {
            con.gestionClienteToMenu (this);
        }

        private void GestionClientes_Load(object sender, EventArgs e) {

        }

        private void agregarClienteDB(object sender, EventArgs e) {
            string run = rutTextBox.Text;
            string nombre = nombreTextBox.Text;
            int edad = int.Parse (edadTextBox.Text);
            string telefono = telefonoTextBox.Text;
            string email = emailTextBox.Text;

            //Cliente cl = new Cliente ()

            //con.insertCliente ();
        }
    }
}
