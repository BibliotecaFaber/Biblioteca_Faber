using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFaber.Modelo {
    class Persona {

        private string rut;
        private string nombre;
        private ArrayList idArray = new ArrayList ();
        private Dictionary<int, DateTime> idEntrega = new Dictionary<int, DateTime>();
        private Dictionary<int, DateTime> idDevolucion = new Dictionary<int, DateTime>();

        private readonly int MAXLIBROS = 3;




    }
}
