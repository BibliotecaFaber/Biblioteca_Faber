﻿using System;
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
        Controlador.Controlador con;
        public MenuInicial() {
            InitializeComponent();
        }
        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }

        private void MenuInicial_Load(object sender, EventArgs e) {

        }

        private void icoBuscar_Click(object sender, EventArgs e) {
            con.iniciarVista(con.buscarLibros);
        }
    }
}
