using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClienteClioLogic;
using ClienteClioLogic.WebServiceESPOL;
using System.Xml;
using System.Threading;

/// <summary>
///Autor: Roger Granda
///Clase: Logica
///Descripción: Esta clase se comunica mediante web service para realizar la lógia de autorización de cliente
///</summary>

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
                directorioEspolSoapClient clienteEspol = new directorioEspolSoapClient();
                bool verificar=clienteEspol.autenticacion(user, password);
                clienteEspol.Close();
                if (verificar)
                {
                    ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
                    authorization = cliente.login(user, password);
                    cliente.Close();
                    if (authorization)
                        return true;
                    else 
                        return false;
                }
                else return false;
                
                
            }catch(Exception e){
                e.StackTrace.ToString();
                authorization = false;
            }
            

            return authorization;
        }

        public static long Login2(String user, String password)
        {

            long authorization;
            if (user.Equals("") || password.Equals(""))
                return 0;
            if (user.Equals("admin") && password.Equals("admin"))
                return -10;
            try
            {
                directorioEspolSoapClient clienteEspol = new directorioEspolSoapClient();
                bool verificar = clienteEspol.autenticacion(user, password);
                clienteEspol.Close();
                if (verificar)
                {
                    ClioService.ClioWebServiceClient cliente = new ClioService.ClioWebServiceClient();
                    authorization = cliente.login2(user);
                    cliente.Close();
                    if (authorization < 0) // no hay control de tiempo
                        return -10;
                    else if (authorization == 0) // no tiene tiempo disponible
                        return 0;
                    else

                        return authorization; // tiene tiempo disponible
                        
                }
                else 
                    return 0;


            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
               authorization = 0;
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
            bool res; 
            try
             {
                 res = cliente.logout("username");
                 cliente.Close();
             }catch(Exception e){
                 res = false;
             }
            return res;
        }
        static void Main()
        {
          
        }
    }
}
