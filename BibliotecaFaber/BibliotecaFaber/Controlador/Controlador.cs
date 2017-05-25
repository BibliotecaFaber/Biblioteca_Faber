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

        public Conexion conexion = new Conexion ();
        //InicioSesion inicio = new InicioSesion ();

        public void inicioPrograma() {

            Application.Run (new InicioSesion());
            

        }

       
        public void loginToMenu(InicioSesion inis, string u, string p) {
            
            DataTable dt = conexion.getQuery ("SELECT Pass FROM Usuarios WHERE Usuario =\"" + u + "\"");

            if (dt.Rows.Count > 0) {

                if (p.Equals (dt.Rows [0].ItemArray [0].ToString ())) {

                    MessageBox.Show ("Usuario y contraseña correctos, bienvenido!");
                    inis.Hide ();
                    new MenuInicial ().Show ();
                }
            }


        }

        public void menuToGestionLibros(MenuInicial mi) {

            mi.Dispose ();
            new GestionLibros ().Show ();
        }

        public void gestionToMenu(GestionLibros gl) {

            gl.Dispose ();
            new MenuInicial ().Show ();

        }

        public void menuToBuscarLibros(MenuInicial mi) {

            mi.Dispose ();
            new BuscarLibros ().Show ();

        }

        public void buscarLibrosToMenu(BuscarLibros bl) {

            bl.Dispose ();
            new MenuInicial ().Show ();
        }

        public void logout(MenuInicial mi) {

            mi.Dispose ();
            new InicioSesion ().Show ();
            
        }

        public void menuToGestionCliente(MenuInicial mi) {

            mi.Dispose ();
            new GestionClientes ().Show ();

        }

        public void gestionClienteToMenu(GestionClientes gc) {

            gc.Dispose ();
            new MenuInicial ().Show ();

        }

        public void menuToPrestamoLibros(MenuInicial mi) {

            mi.Dispose ();
            new PrestamoLibro ().Show ();

        }

        public void prestamoLibroToMenu(PrestamoLibro pl) {

            pl.Dispose ();
            new MenuInicial ().Show ();

        }


        public void insertCliente(Cliente c) {

            c.agregarCliente ();

        }

        public void eliminarCliente(Cliente c) {
            c.eliminarCliente();
        }

        public void modificarCliente(Cliente c, string currut) {
            c.modificarCliente(currut);
        }


        public DataTable obtenerClientes(Cliente c) {
            return c.cargarClientes();
        }

        public void insertLibro(Libro l) {

            l.agregarLibro();

        }

        public void eliminarLibro(Libro l) {
            l.eliminarLibro();
        }

        public void modificarLibro(Libro l, int curid) {
            l.modificarLibro(curid);
        }


        public DataTable obtenerLibros(Libro l) {
            return l.cargarLibros();
        }


    }
}
