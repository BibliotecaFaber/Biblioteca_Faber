using BibliotecaFaber.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFaber {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controlador.Controlador inicial = new Controlador.Controlador();
            inicial.inicioPrograma();
            //Application.Run(new Controlador());
            //Application.Run(new Form1());


               //esta wea es porque puedo
        }
    }
}
