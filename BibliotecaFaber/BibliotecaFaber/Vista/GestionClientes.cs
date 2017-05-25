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
            updateTabla();
        }

        private void updateTabla() {
            tblClientes.DataSource = con.obtenerClientes(new Cliente("", "", 0, "", ""));
            tblClientes.Columns[0].HeaderText = "Rut Cliente";
            tblClientes.Columns[1].HeaderText = "Nombre";
            tblClientes.Columns[2].HeaderText = "Edad";
            tblClientes.Columns[3].HeaderText = "Telefono";
            tblClientes.Columns[4].HeaderText = "Email";
            tblClientes.Rows[0].Selected = true;
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
            updateTabla();
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

        private void tblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void tblClientes_SelectionChanged(object sender, EventArgs e) {
            if (tblClientes.CurrentCell != null) {
                int row = tblClientes.CurrentCell.RowIndex;
                rutTextBox.Text = tblClientes.Rows[row].Cells[0].Value.ToString();
                nombreTextBox.Text = tblClientes.Rows[row].Cells[1].Value.ToString();
                edadTextBox.Text = tblClientes.Rows[row].Cells[2].Value.ToString();
                telefonoTextBox.Text = tblClientes.Rows[row].Cells[3].Value.ToString();
                emailTextBox.Text = tblClientes.Rows[row].Cells[4].Value.ToString();
            }
        }

        private void picModificar_Click(object sender, EventArgs e) {
            int row = tblClientes.CurrentCell.RowIndex;
            int edad = 0;
            if (int.TryParse(edadTextBox.Text,out edad)) {
                string rut = tblClientes.Rows[row].Cells[0].Value.ToString();
                con.modificarCliente(new Cliente(rut, nombreTextBox.Text, edad, telefonoTextBox.Text, emailTextBox.Text), rutTextBox.Text);
                //Falta validar rut al hacer esto, esperando el commit que lo trae para conectarlo
                updateTabla();
            } else {
                MessageBox.Show("Ingrese Edad Valida");
            }
            
        }

        private void picEliminar_Click(object sender, EventArgs e) {
            int row = tblClientes.CurrentCell.RowIndex;
            string rut = tblClientes.Rows[row].Cells[0].Value.ToString();
            string nombre = tblClientes.Rows[row].Cells[1].Value.ToString();
            int edad = int.Parse(tblClientes.Rows[row].Cells[2].Value.ToString());
            string telefono = tblClientes.Rows[row].Cells[3].Value.ToString();
            string email = tblClientes.Rows[row].Cells[4].Value.ToString();
            con.eliminarCliente(new Cliente(rut,nombre,edad,telefono,email));
            updateTabla();
        }
    }
}
