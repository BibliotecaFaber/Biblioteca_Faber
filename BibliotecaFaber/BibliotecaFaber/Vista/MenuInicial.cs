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
    public partial class MenuInicial : Form {
        Controlador.Controlador con = new Controlador.Controlador();
        public MenuInicial() {
            InitializeComponent();
        }
        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }

        private void MenuInicial_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit ();
        }

        private void gestionLibros_Click(object sender, EventArgs e) {
            con.menuToGestionLibros (this);
        }

        private void buscarLibros_click(object sender, EventArgs e) {
            con.menuToBuscarLibros (this, 0);
        }


        private void logout_click(object sender, EventArgs e) {
            con.logout (this);
        }



        



        /* MOTHER FUCKING USELESS */
        private void MenuInicial_Load(object sender, EventArgs e) {

        }

        private void gestionClientes_click(object sender, EventArgs e) {
            con.menuToGestionCliente (this);
        }

        private void prestamoLibros_click(object sender, EventArgs e) {
            con.menuToPrestamoLibros (this);
        }
    }
}
