using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;

/// <summary>
///Autor: Roger Granda
///Clase: ClienteClioViewMAIN
///Descripción: Esta clase representa el objeto que llama a todas las interfaces gráficas
///</summary>
namespace ClienteClioView
{
    public static class ClioViewMain
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        private static ClioGUI glass;
        [STAThread]
        public static void Main()
        {
            
                   
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            glass = new ClioGUI();
            Application.Run(glass);
        }
        public static void logout(){
            glass.logout();
        }
        public static void MostrarMensaje(String mensaje) {
            var ventana=new Mensaje(mensaje);
            Application.Run(ventana);

        }
        public static byte [] Imagen()
        {
            return glass.SaveScreenShot(@"c:\MyScreenShot.png", ImageFormat.Png);
        }
    }
}
