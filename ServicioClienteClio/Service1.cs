using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace ClienteClioService
{
    public partial class ClienteClio : ServiceBase
    {
        public ClienteClio()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            FileStream fs = new FileStream(@"c:\ClioTest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SR = new StreamWriter(fs);
            SR.WriteLine("El servico se ha iniciado");
            SR.Flush();
            SR.Close();
            EventLog.WriteEntry("Iniciando Servicio");
        }

        protected override void OnStop()
        {
            FileStream fs = new FileStream(@"c:\ClioTest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SR = new StreamWriter(fs);
            SR.WriteLine("El servico ha parado");
            SR.Flush();
            SR.Close();
            EventLog.WriteEntry("Parando el servicio");
        }

       

    }
}
