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
        Controlador.Controlador con;
        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }
        private void tblLibros_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void GestionLibros_Load(object sender, EventArgs e) {
            int fila = 0;       //obtener desde libro
            int columna = 1;    //la misma wea de arriba
            string coords = "" + fila + "_" + columna;
            MessageBox.Show(coords);

            object asd = Resources.ResourceManager.GetObject(coords);
            imgUbicacion.Image = (Image)asd;
            imgUbicacion.Refresh();
        }

        private void chkPrestamo_CheckedChanged(object sender, EventArgs e) {
            con.cerrarVista(this);
        }
    }
}
