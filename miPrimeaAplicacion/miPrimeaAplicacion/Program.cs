using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion {
    internal static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Se inicia con el formulario de login.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
