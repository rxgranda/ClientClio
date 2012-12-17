using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using CommunicationsClioLibrary;
using System.Threading;

namespace ClienteClioService
{
    public class Program:Caller
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        static AsynchronousSocketListener server;
        public Program()
        {
            server = new AsynchronousSocketListener(this);
        }
        static void Main()
        {
            new Program();
            ThreadStart param = delegate { server.StartListening(11002); };
            Thread serverThread = new Thread(param);
            serverThread.Start();
            while (!serverThread.IsAlive);
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new ClienteClio() 
			};
            ServiceBase.Run(ServicesToRun);


        }
        public override void Procesar(string mensaje)
        {
            ApagarPC();
        }
        
        public void ApagarPC()
        {
            System.Diagnostics.Process.Start("Shutdown", "-s -t 10");        
        }
    }
}
