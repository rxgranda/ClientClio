using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicationsClioLibrary
{
    public abstract class Caller
    {
        public abstract void Mensaje(String mensaje);
        public abstract String InfoPC();
        public abstract void ApagarPC();        
        public abstract byte [] Imagen();
    }
}
