﻿using BibliotecaFaber.Modelo;
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
        private DataTable dt;

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
                } else {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            } else {
                MessageBox.Show("No Existe el Usuario");
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

        public void menuToBuscarLibros(Form form, int i) {
            if (i == 0) {
                BuscarLibros bl = new BuscarLibros();
                form.Dispose ();
                bl.I = 0;
                bl.Show ();
            } else {
                BuscarLibros bl = new BuscarLibros ();
                form.Hide ();
                bl.I = 1;
                bl.Show ();
            }
        }

        public void buscarLibrosToMenu(BuscarLibros bl) {
            if (bl.I == 0) {
                bl.Dispose ();
                new MenuInicial ().Show ();
            } else {
                bl.Dispose ();
                new InicioSesion ().Show ();
            }

        }

        public void logout(MenuInicial mi) {

            mi.Dispose ();
            new InicioSesion ().Show ();
            
        }

        public void menuToGestionCliente(MenuInicial mi) {

            mi.Dispose ();
            new GestionClientes ().Show ();

        }

        public void menuToDevolverLibro(MenuInicial mi) {
            mi.Dispose ();
            new DevolverLibros ().Show ();
        }

        public void devolverLibroToMenu(DevolverLibros dl) {
            dl.Dispose ();
            new MenuInicial ().Show ();
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

        public DataTable buscarCliente(string run) {
            return new Cliente ().buscarCliente (run);
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

        public DataTable obtenerLibrosDisponibles(Libro l) {
            return l.cargarLibrosDisponibles ();
        }

        public DataTable obtenerLibros(Libro l) {
            return l.cargarLibros();
        }

        public DataTable buscarLibros(Libro l, string nombre) {
            return l.buscaLibros (nombre);
        }


        public void crearPrestamo(string sql) {
            new Conexion ().sendQuery (sql);
        }

        public void libroPrestado(string sql) {
            new Conexion ().sendQuery (sql);
        }

        public DataTable mostrarPrestamos(Prestamo p) {

            return p.cargarPrestamos();
        }

        public DataTable buscarPrestamo(Prestamo p, string run) {
            return p.buscarPrestamo (run);
        }

        public void updatePrestamo(Prestamo p, string sql) {
            p.updatePrestamo (sql);
        }

        public void updateLibro(Libro l, string sql) {
            l.updateLibro (sql);
        }

    }
}
