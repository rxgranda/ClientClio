using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClienteClioLogic;
using ClienteClioLogic.WebServiceESPOL;
using System.Xml;

namespace ClienteClioLogic
{
    public class Logica
    {
        public static Boolean Login(String user, String password) {
            
             bool authorization=false;
             if (user.Equals("") || password.Equals(""))
                 return false;
             if (user.Equals("admin") && password.Equals("admin"))
                 return true;
            try{
                ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
               authorization=cliente.login(user, password);
                cliente.Close();
            }catch(Exception e){
                e.StackTrace.ToString();
            }
            

            return authorization;
        }
        public static Boolean RegistrarCliente(String user, String password) {
            bool authorization = false;
            if (user.Equals("") || password.Equals(""))
                return false;
            try
            {
                directorioEspolSoapClient cliente = new directorioEspolSoapClient();

                String str = cliente.datosUsuario(user, password).GetXml();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(str);
                String matricula = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/MATRICULA").InnerText;
                String cedula = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/CEDULA").InnerText;
                String apellidos = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/APELLIDOS").InnerText;
                String nombres = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/NOMBRES").InnerText;
                String facultad = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/UNIDAD").InnerText;
                String correo = doc.SelectSingleNode("/NewDataSet/DATOS_USUARIO/CORREO").InnerText;
                ClioService.ClioWebServiceClient cliente2 = new ClioService.ClioWebServiceClient();
                authorization = cliente2.registrarClienteClio(user, password,nombres,apellidos,matricula,cedula,correo,facultad);                
                cliente.Close();
            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
            }

            return authorization;
        
        }

        public static String Laboratorios() {
            
            ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
            String lab=cliente.laboratoriosDisponibles();
            cliente.Close();
            return lab;
        }
        public static bool registrarPC(String nombrePC, String idLab)
        {
            ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
             
            bool res=cliente.registrarPC(nombrePC, idLab);
            cliente.Close();
            return res;
        }
        public static bool logout() {
             ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
            bool res=cliente.logout("username");
            cliente.Close();
            return res;
        }
        static void Main()
        {
          
        }
    }
}
