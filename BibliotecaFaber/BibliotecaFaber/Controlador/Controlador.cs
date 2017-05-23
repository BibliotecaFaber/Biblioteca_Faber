using BibliotecaFaber.Modelo;
using BibliotecaFaber.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber.Controlador {
    class Controlador {
        //MODELO
        //public Libro libro = new Libro(0,"",""); //Ver Constructor vacio
        //public Persona persona = new Persona();
        //public Almacenamiento almacenamiento = new Almacenamiento();
        //public Prestamo prestamo = new Prestamo();
        public Conexion conexion = new Conexion();
        //public Estante estante = new Estante();

        //VISTA
        public InicioSesion inicio = new InicioSesion();
        public MenuInicial menu = new MenuInicial();
        public GestionLibros gestionLibros = new GestionLibros();
        public GestionClientes gestionClientes = new GestionClientes();
        public PrestamoLibro prestamoLibro = new PrestamoLibro();
        public BuscarLibros buscarLibros = new BuscarLibros();

        
        public void inicioPrograma() {
            inicio.cargarControlador(this);
            menu.cargarControlador(this);
            buscarLibros.cargarControlador(this);
            Application.Run(inicio);
            //inicio.Show(); *No funciona asi si es la primera vista*
        }

        public void iniciarSesion(string u, string p) {
            DataTable t = conexion.getQuery("SELECT Pass FROM Usuarios WHERE Usuario=\"" + u + "\""); //cn.selectQuery("SELECT Pass FROM Usuarios WHERE Usuario=\"" + u +"\"");
            if (t.Rows.Count>0) {
                
                if (p.Equals(t.Rows[0].ItemArray[0].ToString())) {
                    MessageBox.Show("Inicio de Sesion Correcto"); //Aqui o en la vista??
                    iniciarVista(menu);
                    inicio.Hide();
                } else {
                    MessageBox.Show("Contraseña Incorrecta"); //Lo mismo
                }

            } else {
                MessageBox.Show("No Existe el Usuario"); //...
            }
        }

        public void iniciarVista(Form vista) {
            vista.Show();
            //buscarLibros.Show();
        }




    }
}
