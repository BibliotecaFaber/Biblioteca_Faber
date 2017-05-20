using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Libro {
        private int id;
        private string nombre;
        private string autor;
        private string editorial;
        private static uint cant;
        private static uint cant_disponible;
        private bool active = true;
        public Conexion con = new Conexion();

        public Libro(int id, string nombre, string editorial) {
            this.id = id;
            this.nombre = nombre;
            this.editorial = editorial;
        }

        public int Id {
            get => id;
            set => id = value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        public string Editorial {
            get => editorial;
            set => editorial = value;
        }
        public static uint Cant {
            get => cant;
            set => cant = value;
        }
        public static uint Cant_disponible {
            get => cant_disponible;
            set => cant_disponible = value;
        }
        public bool Active {
            get => active;
            set => active = value;
        }
        public string Autor { get => autor; set => autor = value; }

        public DataTable listarLibros() {
            return con.getQuery("SELECT * FROM Libros;");
        }

        public void agregarLibro() {
            string qr = "INSERT INTO Libros(Nombre,Autor,Editorial)VALUES(" + this.Nombre + this.Autor + this.Editorial + ")"; //Ver cantidad y cantidad disponible para añadir un libro nuevo (webeo con static)
            con.sendQuery(qr);
        }

        public DataTable buscarLibro(string busqueda, string filtro) {
            
            switch (filtro.ToLower()) {
                case "autor":
                    return con.getQuery("SELECT * FROM Libros WHERE Autor =" + busqueda + ";");
                    break;
                case "nombre":
                    return con.getQuery("SELECT * FROM Libros WHERE Nombre =" + busqueda + ";");
                    break;
                default:
                    //***CONTROLAR RETORNOS EN EL CONTROLADOR***
                    return null;
                    break;
            }

        }



    }
}
