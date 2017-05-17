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
        public InicioSesion() {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        MenuInicial mi = new MenuInicial();
        private void label1_Click(object sender, EventArgs e) {

        }

        private void InicioSesion_Load(object sender, EventArgs e) {

        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            DataTable t = cn.selectQuery("SELECT Pass FROM Usuarios WHERE Usuario=\"" + textBox1.Text+"\"");
            if (t.Rows.Count>0) {
                
                if (textBox2.Text.Equals(t.Rows[0].ItemArray[0].ToString())) {
                    MessageBox.Show("Inicio de Sesion Correcto");
                    mi.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Contraseña Incorrecta");
                }

            } else {
                MessageBox.Show("No Existe el Usuario");
            }
            //MessageBox.Show(x.Rows[0].ItemArray[1].ToString());
        }
    }
}
