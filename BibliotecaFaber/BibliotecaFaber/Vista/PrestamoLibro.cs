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
    }
}
