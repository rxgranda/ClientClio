using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;
/// <summary>
///Autor: Roger Granda
///Clase: Supervisor
///Descripción: Representa la clases que optiene las características de hardware del Pc
///</summary>

namespace ClienteClioService
{
    class Supervisor
    {
        public static String HardDrive(){
            string response = "";
            foreach (System.IO.DriveInfo label in System.IO.DriveInfo.GetDrives())
            {
                if (label.IsReady)
                {
                    response+=(label.Name + " TotalSize" + " " + label.TotalSize.ToString())+"&&";
                }
            }
            return response;

        }
        public static String Memory()
        {
            string response = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");
            foreach (ManagementObject mo in mos.Get())
            {
                response=((Convert.ToInt64(mo["TotalPhysicalMemory"]) / 1024) / 1024)+"";
            }
            return response;

        }
        public static String CPU()
        {
            string cpuInfo = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuInfo == String.Empty)
                {
                    // only return cpuInfo from first CPU
                    cpuInfo = obj.Properties["ProcessorId"].Value.ToString()+"&&";
                    cpuInfo+=obj.Properties["Description"].Value;
                    
                }
            }
            return cpuInfo;
         
        }
        public static String SystemProcess()
        {
            string respuesta = "";
            Process[] myProcesses = Process.GetProcesses();
            foreach (Process myProcess in myProcesses)
            {
                respuesta+=myProcess.ProcessName+"&&";
            }
            return respuesta;
        }

    }
}
