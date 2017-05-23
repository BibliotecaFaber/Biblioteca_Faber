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
    public partial class InicioSesion : Form {

        Controlador.Controlador con = new Controlador.Controlador ();

        public InicioSesion() {
            InitializeComponent();
        }
        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }
        
        private void label1_Click(object sender, EventArgs e) {

        }

        private void InicioSesion_Load(object sender, EventArgs e) {

        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            


            
            con.loginToMenu (this, txtUsuario.Text, txtPass.Text);

            //con.loginToMenu(this, txtUsuario.Text, txtPass.Text);
        }

        
        private void buscarLibro_Click(object sender, EventArgs e) {
            MessageBox.Show ("Estamos trabajando para usted.");
        }




        /* THIS IS FUCKING USELESS */
        private void button1_Click(object sender, EventArgs e) {

        }

        private void inicioSesion_CERRADO(object sender, FormClosedEventArgs e) {
            Application.Exit ();
        }
    }
}
