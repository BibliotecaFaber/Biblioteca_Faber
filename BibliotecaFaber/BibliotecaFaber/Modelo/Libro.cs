using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Libro {

        private int id;
        private string nombre;
        private string autor;
        private string editorial;
        private int fila;
        private int columna;
        private int ID_estante;
        private bool en_prestamo;

        public Libro(int id, string nombre, string autor, string editorial, int fila, int columna, int id_estante) {
            this.Id = id;
            this.Nombre = nombre;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Fila = fila;
            this.Columna = columna;
            this.ID_estante = id_estante;

            this.En_prestamo = false;
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        public string Autor {
            get => autor;
            set => autor = value;
        }
        public string Editorial {
            get => editorial;
            set => editorial = value;
        }
        public int Fila {
            get => fila;
            set => fila = value;
        }
        public int Columna {
            get => columna;
            set => columna = value;
        }
        public int id_estante {
            get => ID_estante;
            set => ID_estante = value;
        }
        public bool En_prestamo {
            get => en_prestamo;
            set => en_prestamo = value;
        }
    }
}