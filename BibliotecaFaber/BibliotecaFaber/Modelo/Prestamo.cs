using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Prestamo {
        private int ID_prestamo;
        private bool estado_prestamo;
        private string runCliente;
        private int idLibro;
        private int idLibro2;
        private int idLibro3;

        public Prestamo() {
        }

        public Prestamo(string runCliente, int idLibro, int idLibro2, int idLibro3) {
            this.RunCliente = runCliente;
            this.IdLibro = idLibro;
            this.IdLibro2 = idLibro2;
            this.IdLibro3 = idLibro3;
        }

        public int ID_prestamo1 {
            get => ID_prestamo;
            set => ID_prestamo = value;
        }
        public bool Estado_prestamo {
            get => estado_prestamo;
            set => estado_prestamo = value;
        }
        public string RunCliente {
            get => runCliente;
            set => runCliente = value;
        }
        public int IdLibro {
            get => idLibro;
            set => idLibro = value;
        }
        public int IdLibro2 {
            get => idLibro2;
            set => idLibro2 = value;
        }
        public int IdLibro3 {
            get => idLibro3;
            set => idLibro3 = value;
        }


        public System.Data.DataTable buscarPrestamo(string run) {

            string sql = "SELECT * FROM PRESTAMO WHERE ESTADO_PRESTAMO = 0 AND RUN_CLIENTE = '" + run + "';";
            return new Conexion ().getQuery (sql);
        }

        public System.Data.DataTable cargarPrestamos() {
           
            string sql = "SELECT * FROM PRESTAMO WHERE ESTADO_PRESTAMO = 0;";

            return new Conexion().getQuery(sql);
        }

        public void updatePrestamo(string sql) {
            new Conexion ().sendQuery (sql);
        }
    }
}