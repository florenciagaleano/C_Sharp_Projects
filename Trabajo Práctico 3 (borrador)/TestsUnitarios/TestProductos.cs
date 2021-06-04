using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases;
using Clases.Fabrica;

namespace TestsUnitarios
{
    [TestClass]
    public class TestProductos
    {
        [TestMethod]
        public void Asigna_Negro_Al_Rimel_Si_Color_Es_Invalido()
        {
            Rimel rimel = new Rimel(Rimel.Efecto.Curvar, ConsoleColor.Yellow);

            Assert.AreEqual(ConsoleColor.Black, rimel.Color);
        }

        [TestMethod]
        public void Sobrecarga__Dos_Productos_Son_Iguales()
        {
            Labial l1 = new Labial(ConsoleColor.Red, Labial.Tipo.Gloss);
            Labial l2 = new Labial(ConsoleColor.Red, Labial.Tipo.Gloss);

            Assert.IsTrue(l1 == l2);
        }

        [TestMethod]
        public void No_Agrega_Productos_Si_No_Hay_Tiempo()
        {
            Base b = new Base(205);
            Fabrica f = new Fabrica(1);

            f.HacerPedido(b,60);
            Fabrica.Fabricar(f);

            Assert.AreEqual(f.Jornadas.Count,2);
        }

        
    }
}
