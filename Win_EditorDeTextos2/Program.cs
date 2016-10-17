/*---------------------------------------------------------------------------------------
 *    Nombre: Editor Estilado
 *     Autor: José Antonio Barranquero
 *   Versión: 0.9.8
 *     Fecha: 3/3/2016 - 11/3/2016
 *Comentario: Editor de texto plano
 *-----------------------------------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBF.EditorEstilado
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)    // Si hay un solo parametro, intentará cargar el archivo, sino lo ignorará
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmBloc(args[0]));
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmBloc());
            }
        }
    }
}
