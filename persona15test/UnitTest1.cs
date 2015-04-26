using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_4_4_15;

namespace Persona15Test
{
    [TestClass]
    public class Persona15Test
    {
        static int peso = 80;
        static int altura = 172;
        static string ollos = "verde";
        static string pelo = "marrón";

        Persona15 eu = new Persona15(altura, peso, ollos, pelo);

        [TestMethod]
        public void Lentillas15Test()
        {
            string lentillas1 = "rosa";
            string lentillas2 = "azul";

            eu.PonerLentillas15(lentillas1);
            Assert.AreEqual(eu.ColorOjos15, "verde");

            eu.PonerLentillas15(lentillas2);
            Assert.AreEqual(eu.ColorOjos15, "azul");
        }

        [TestMethod()]
        public void Adelgazar15Test()
        {
            eu.Adelgazar15(15);
            Assert.AreEqual(65, eu.Peso15);

            eu.Adelgazar15(150);
            Assert.AreEqual(65, eu.Peso15);

            eu.Adelgazar15(-15);
            Assert.AreEqual(65, eu.Peso15);
        }
    }
}
