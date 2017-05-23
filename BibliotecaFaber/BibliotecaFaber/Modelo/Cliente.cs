﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}