using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Estante {

        private int ID_estante;
        private int[,] matriz = new int[3, 5];
        private readonly int max_size = 10;

        public Estante(int iD_estante) {
            ID_estante = iD_estante;
        }

        public int ID_estante1 {
            get => ID_estante;
            set => ID_estante = value;
        }
        public int[,] Matriz {
            get => matriz;
            set => matriz = value;
        }
    }
}