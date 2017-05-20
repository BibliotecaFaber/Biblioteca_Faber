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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Conexion xx = new Conexion();
        private void Form1_Load(object sender, EventArgs e) {
            //MessageBox.Show("Holi");
            
        }

        private void button1_Click(object sender, EventArgs e) {
            //DataTable x = xx.selectQuery("SELECT * FROM Libros");
            //MessageBox.Show(x.Rows[0].ItemArray[1].ToString());
         //   dataGridView1.DataSource = x;
        }
    }
}
