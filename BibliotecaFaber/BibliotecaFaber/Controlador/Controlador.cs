using BibliotecaFaber.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Controlador {
    class Controlador {
        public Libro libro = new Libro(0,"",""); //Ver Constructor vacio
        public Persona persona = new Persona();
        public Almacenamiento almacenamiento = new Almacenamiento();
        public Prestamo prestamo = new Prestamo();

    }
}
