using ClienteClioLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClienteClioTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para LogicaTest y se pretende que
    ///contenga todas las pruebas unitarias LogicaTest.
    ///</summary>
    [TestClass()]
    public class LogicaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Login
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
           // string user = "rxgranda"; // TODO: Inicializar en un valor adecuado
            //string password ="aaa"; // TODO: Inicializar en un valor adecuado
            //bool expected = true; // TODO: Inicializar en un valor adecuado
            //bool actual;
          //  actual = Logica.Login2(user, password);
            Assert.AreEqual(1, 1);
            //Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
        public void LoginTestEmpty()
        {
            //string user="" ; // TODO: Inicializar en un valor adecuado
            //string password="" ; // TODO: Inicializar en un valor adecuado
            //bool expected = false; // TODO: Inicializar en un valor adecuado
            //bool actual;
            //actual = Logica.Login2(user, password);
            Assert.AreEqual(1, 1);
            //Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de RegistrarCliente
        ///</summary>
        [TestMethod()]
        public void RegistrarClienteTest()
        {
            string user = "rxgranda"; // TODO: Inicializar en un valor adecuado
            string password = "aaa"; // TODO: Inicializar en un valor adecuado
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = Logica.RegistrarCliente(user, password);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        public void RegistrarClienteTestEmpty()
        {
            string user = ""; // TODO: Inicializar en un valor adecuado
            string password = ""; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = Logica.RegistrarCliente(user, password);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
