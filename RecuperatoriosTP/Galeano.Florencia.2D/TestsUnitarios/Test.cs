using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Fabricacion;
using Productos;
using Excepciones;

namespace TestsUnitarios
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Testea que funcione el Setter de Rimel
        /// </summary>
        [TestMethod]
        public void Asigna_Negro_Al_Rimel_Si_Color_Es_Invalido()
        {
            Rimel rimel = new Rimel(Rimel.Efecto.Curvar, ConsoleColor.Yellow);

            Assert.AreEqual(ConsoleColor.Black, rimel.Color);
        }

        /// <summary>
        /// Verifica que se lance una excepción al buscar una jornada inexistente
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NoHayActividadEnEsaFechaException))]
        public void Excepcion_Al_Buscar_Jornada_Inexistente()
        {
            DateTime fecha = new DateTime(2000, 12, 31);
            Fabrica f = new Fabrica(10);
            Jornada j = f.Jornadas[f.BuscarIndiceJornadaPorFecha(fecha)];
        }
  

        /// <summary>
        /// Verifica que si no se pueden agregar productos se agrega otra jornada a la lista de jornadas
        /// </summary>
        [TestMethod]
        public void Agrega_Jornada_Si_No_Queda_Tiempo()
        {
            Fabrica f = new Fabrica(1); //480
            Base b = new Base(60);

            f.HacerPedido(b, 60);
            Fabrica.IniciarFabricacion(f);

            Assert.AreEqual(2, f.Jornadas.Count);
        }

        /// <summary>
        /// Verifica que si se hace un pedido después de fabricar los productos se agreguen A LA MISMA JORNADA
        /// </summary>
        [TestMethod]
        public void Agrega_Productos_A_La_Misma_Jornada_Si_Hay_Tiempo()
        {
            List<Producto> lista = new List<Producto>();
            Fabrica f = new Fabrica(100);
            Rimel r = new Rimel(Rimel.Efecto.Alargar, ConsoleColor.White);
            Base b = new Base(203);

            f.HacerPedido(r, 8);
            Fabrica.IniciarFabricacion(f);
            lista.Add(b);
            lista.Add(r);
            f.HacerPedido(lista);
            Fabrica.IniciarFabricacion(f);

            Assert.AreEqual(f.Jornadas.Count, 1);
        }

    }
}
