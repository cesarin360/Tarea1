using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1
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
             Application.Run(new Form1());
            /*var estructura = new clsEstructura().cargaDatosXLS();
            foreach (var datos in estructura)
            {
                Console.WriteLine(datos.nombre);
            }*/
        }
    }
}
