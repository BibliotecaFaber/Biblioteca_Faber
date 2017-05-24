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
            run = validaRUN (run);
            string nombre = nombreTextBox.Text;
            int edad = int.Parse (edadTextBox.Text);
            string telefono = telefonoTextBox.Text;
            string email = emailTextBox.Text;


            Cliente cl = new Cliente (run, nombre, edad, telefono, email);

            con.insertCliente (cl);
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
    }
}
