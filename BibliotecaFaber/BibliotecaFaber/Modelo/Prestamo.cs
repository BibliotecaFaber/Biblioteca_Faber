using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Prestamo {
        private int ID_prestamo;
        private bool estado_prestamo;
        private Cliente cliente;
        private Libro libro;
        private Libro libro2;
        private Libro libro3;

        public Prestamo(int iD_prestamo, bool estado_prestamo, Cliente cliente, Libro libro, Libro libro2, Libro libro3) {
            ID_prestamo1 = iD_prestamo;
            this.Estado_prestamo = estado_prestamo;
            this.Cliente = cliente;
            this.Libro = libro;
            this.Libro2 = libro2;
            this.Libro3 = libro3;
        }

        public int ID_prestamo1 {
            get => ID_prestamo;
            set => ID_prestamo = value;
        }
        public bool Estado_prestamo {
            get => estado_prestamo;
            set => estado_prestamo = value;
        }
        internal Cliente Cliente {
            get => cliente;
            set => cliente = value;
        }
        internal Libro Libro {
            get => libro;
            set => libro = value;
        }
        internal Libro Libro2 {
            get => libro2;
            set => libro2 = value;
        }
        internal Libro Libro3 {
            get => libro3;
            set => libro3 = value;
        }
    }
}