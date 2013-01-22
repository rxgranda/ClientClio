using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
///Autor: Roger Granda
///Interface: Caller
///Descripción: Interface de comunicaciones, para utilizar servicios de sockets
///</summary>
namespace CommunicationsClioLibrary
{
    public abstract class Caller
    {
        public abstract void Mensaje(String mensaje);
        public abstract String InfoPC();
        public abstract void ApagarPC();        
        public abstract byte [] Imagen();
        public abstract void logout();     
    }
}
