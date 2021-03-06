﻿using BibliotecaFaber.Modelo;
using BibliotecaFaber.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber {
    public partial class BuscarLibros : Form {

        private int i = 0;
        public BuscarLibros() {
            InitializeComponent();
        }
        Controlador.Controlador con = new Controlador.Controlador ();

        public int I {
            get => i;
            set => i = value;
        }

        public void cargarControlador(Object cc) {
            this.con = (Controlador.Controlador)cc;
        }
        private void Form1_Load(object sender, EventArgs e) {

            updateTabla(0);
        }

        private void updateTabla(int t) {
            if (t == 0) {
                tablaLibros.DataSource = null;
                tablaLibros.DataSource = con.obtenerLibros(new Libro());
                tablaLibros.Columns[0].HeaderText = "Código del Libro";
                tablaLibros.Columns[1].HeaderText = "Nombre del libro";
                tablaLibros.Columns[2].HeaderText = "Autor";
                tablaLibros.Columns[3].HeaderText = "Editorial";
                tablaLibros.Columns[4].Visible = false;
                tablaLibros.Columns[5].Visible = false;
                tablaLibros.Columns[6].Visible = false;
                int columnNumber = 6;
                tablaLibros.Columns.Add("Prestamo", "Prestado");
                for (int i = 0; i < tablaLibros.Rows.Count; i++) {
                    if (tablaLibros[columnNumber, i].Value.ToString() == "0") { tablaLibros[7, i].Value = "No"; } else { tablaLibros[7, i].Value = "Si"; }
                }
            } else {
                tablaLibros.Columns[0].HeaderText = "Código del Libro";
                tablaLibros.Columns[1].HeaderText = "Nombre del libro";
                tablaLibros.Columns[2].HeaderText = "Autor";
                tablaLibros.Columns[3].HeaderText = "Editorial";
                tablaLibros.Columns[4].Visible = false;
                tablaLibros.Columns[5].Visible = false;
                tablaLibros.Columns[6].Visible = false;
                int columnNumber = 6;
                tablaLibros.Columns.Add("Prestamo", "Prestado");
                for (int i = 0; i < tablaLibros.Rows.Count; i++) {
                    if (tablaLibros[columnNumber, i].Value.ToString() == "0") { tablaLibros[7, i].Value = "No"; } else { tablaLibros[7, i].Value = "Si"; }
                }
            }
            
        }

        private void buscarClick(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace (nombrelibroTextBox.Text)) {

                string str = nombrelibroTextBox.Text;
                tablaLibros.Columns.RemoveAt(8);
                tablaLibros.DataSource = con.buscarLibros (new Libro (), str);
                updateTabla(1);



            } else {
                tablaLibros.Columns.RemoveAt(8);
                updateTabla(0);


                MessageBox.Show ("Ingrese un nombre de libro primero!");
            }
        }

        private void volverMenu(object sender, FormClosedEventArgs e) {
            con.buscarLibrosToMenu (this);

        }

        private void botonVolver_Clicked(object sender, EventArgs e) {
            con.buscarLibrosToMenu (this);
        }

        private void tablaLibros_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tablaLibros_SelectionChanged(object sender, EventArgs e) {
            if (I == 0) {
                lblUbicacion.Visible = true;
                imgEstante.Visible = true;
                if (tablaLibros.CurrentCell != null) {
                    int row = tablaLibros.CurrentCell.RowIndex;
                    ResourceManager rm = Resources.ResourceManager;
                    Bitmap tabla = (Bitmap)rm.GetObject(tablaLibros.Rows[row].Cells[4].Value.ToString() + "_" + tablaLibros.Rows[row].Cells[5].Value.ToString());
                    imgEstante.Image = tabla;
                }
            } else {
                lblUbicacion.Visible = false;
                imgEstante.Visible = false;
            }
            
        }

        private void imgEstante_Click(object sender, EventArgs e) {

        }
    }
}
