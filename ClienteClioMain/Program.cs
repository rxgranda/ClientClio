using System;
using System.Collections.Generic;
using System.Linq;
using ClienteClioView;
using System.Threading;
using CommunicationsClioLibrary;


namespace ClienteClioMain
{
    public class Program: Caller
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        static AsynchronousSocketListener server;
        public Program()
        {
           server= new AsynchronousSocketListener(this);
        }
        [STAThread]
        static void Main()
        {
            new Program();
            ThreadStart param = delegate { server.StartListening(11001); };
            Thread serverThread = new Thread(param);
            serverThread.Start();
            while (!serverThread.IsAlive) ;
            Thread guiThread = new Thread(new ThreadStart(ClioViewMain.Main));
            guiThread.Start();
            while (!guiThread.IsAlive) ;                                      
        }
        public override void Procesar(String mensaje){
            ClioViewMain.MostrarMensaje(mensaje);
        }
    }
}