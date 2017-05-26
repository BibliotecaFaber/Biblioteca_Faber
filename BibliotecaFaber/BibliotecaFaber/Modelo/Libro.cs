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
        //private int ID_estante;
        private bool en_prestamo;

        public Libro(int id, string nombre, string autor, string editorial, int fila, int columna) {
            this.Id = id;
            this.Nombre = nombre;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Fila = fila;
            this.Columna = columna;
            //this.ID_estante = id_estante;

            this.En_prestamo = false;
        }

        public Libro() {
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
        /*public int id_estante {
            get => ID_estante;
            set => ID_estante = value;
        } PA LA CASA */
        public bool En_prestamo {
            get => en_prestamo;
            set => en_prestamo = value;
        }

        public void agregarLibro() {
            int prestamo = (en_prestamo ? 1 : 0);
            string insert = "INSERT INTO LIBRO VALUES (" + this.id + ", \"" + this.nombre + "\",  \"" + this.autor +
                "\", \"" + this.editorial + "\", " + this.fila + ","+this.columna + "," + prestamo + "," + 0 + ");";

            new Conexion().sendQuery(insert);
        }
        public void modificarLibro(int nueid) {
            int prestamo = (en_prestamo ? 1 : 0);
            string delete = "DELETE FROM LIBRO WHERE ID_LIBRO='" + this.id + "';";
            string insert = "INSERT INTO LIBRO VALUES (" + nueid + ", \"" + this.nombre + "\",  \"" + this.autor +
                "\", \"" + this.editorial + "\", " + this.fila + "," + this.columna + "," + prestamo + "," + 0 + ");";
            new Conexion().sendQuery(delete);
            new Conexion().sendQuery(insert);
        }

        public void eliminarLibro() {
            string delete = "DELETE FROM LIBRO WHERE ID_LIBRO='" + this.id + "';";
            new Conexion().sendQuery(delete);
        }

        public System.Data.DataTable cargarLibros() {
            string select = "SELECT * FROM LIBRO";
            return new Conexion().getQuery(select);
        }

        public System.Data.DataTable cargarLibrosDisponibles() {
            string sql = "SELECT * FROM LIBRO WHERE EN_PRESTAMO = 0;";
            return new Conexion ().getQuery (sql);
            
        }

        public System.Data.DataTable buscaLibros(string str) {
            string sql = "SELECT * FROM LIBRO WHERE NOMBRE LIKE \"%" + str + "%\";";
            return new Conexion ().getQuery (sql);
        }

        //
        
        
    }
}