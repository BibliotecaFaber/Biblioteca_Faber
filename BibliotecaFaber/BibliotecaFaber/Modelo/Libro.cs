using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Libro {
        private int id;
        private string nombre;
        private string editorial;
        private static uint cant;
        private static uint cant_disponible;
        private bool active = true;

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
    }
}
