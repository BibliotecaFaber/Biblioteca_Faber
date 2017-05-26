using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber.Modelo {
    class Cliente {

       

        private string run;
        private string nombre;
        private int edad;
        private string telefono;
        private string email;

        public Cliente(string run, string nombre, int edad, string telefono, string email) {
            this.Run = run;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Email = email;
        }

        public Cliente() {
        }

        public string Run {
            get => run;
            set => run = value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }
        public int Edad {
            get => edad;
            set => edad = value;
        }
        public string Telefono {
            get => telefono;
            set => telefono = value;
        }
        public string Email {
            get => email;
            set => email = value;
        }


        public void agregarCliente() {
            string insert = "INSERT INTO CLIENTE VALUES (\"" + this.run + "\", \"" + this.nombre + "\",  " + this.edad +
                ", \"" + this.telefono + "\", \"" + this.email + "\");";

            new Conexion ().sendQuery (insert);
        }
        public void modificarCliente(string nuerut) {
            string delete = "DELETE FROM CLIENTE WHERE RUN_CLIENTE='" + this.run + "';"; 
            string insert = "INSERT INTO CLIENTE VALUES (\"" + nuerut + "\", \"" + this.nombre + "\",  " + this.edad +
                ", \"" + this.telefono + "\", \"" + this.email + "\");";
            new Conexion().sendQuery(delete);
            new Conexion().sendQuery(insert);
        }

        public void eliminarCliente() {
            string delete = "DELETE FROM CLIENTE WHERE RUN_CLIENTE='" + this.run + "';";
            new Conexion().sendQuery(delete);
        }

        public System.Data.DataTable cargarClientes() {
            string select = "SELECT * FROM CLIENTE";
            return new Conexion().getQuery(select);
        }

        public System.Data.DataTable buscarCliente(string s) {

            string sql = "SELECT * FROM CLIENTE WHERE RUN_CLIENTE = '" + s + "';";
            return new Conexion ().getQuery (sql);
        }
    }
}