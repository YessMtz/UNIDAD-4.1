using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registro_Propietarios());
            Application.Run(new Registro_Ciudad());
            Application.Run(new Consultas());
            Application.Run(new Registro_Farmacias());
            Application.Run(new Registro_Medicamento());
        }
    }
}
