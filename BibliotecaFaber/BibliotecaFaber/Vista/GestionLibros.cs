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
    public partial class GestionLibros : Form {
        public GestionLibros() {
            InitializeComponent();
        }
        Controlador.Controlador con = new Controlador.Controlador();

        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador) cc;
        }
        private void GestionLibros_Load(object sender, EventArgs e) {
            
        }

        private void GestionLibros_FormClosed(object sender, FormClosedEventArgs e) {
            con.gestionToMenu (this);
        }

        private void boton_volver(object sender, EventArgs e) {
            con.gestionToMenu (this);
        }
    }
}
