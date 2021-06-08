using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Excepciones;
using Fabricacion;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Galeano Florencia 2D";

            Fabrica f = new Fabrica(5); // 5 * 8 * 60 = 2400

            try
            {
                DateTime d = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                //informe detallado e informa resumido Lista de pendientes Productos vencidos
                Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
                Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
                Base producBase = new Base(100);//deberia settear 200

                f.HacerPedido(producBase, 150);
                f.HacerPedido(labial, 100); 
                f.HacerPedido(rimel, 300);
                Fabrica.IniciarFabricacion(f);
                //Fabrica.Fabricar(f);
                //Fabrica.Envasar(f);
                //Fabrica.Distribuir(f);
                /*---------------------------------------------------*/
                List<Producto> lista = new List<Producto>();
                lista.Add(new Labial(ConsoleColor.Black, Labial.Tipo.Gloss));
                lista.Add(new Base(204));

                f.HacerPedido(lista); // 300* 5 = 1500

                Fabrica.IniciarFabricacion(f);
            }catch(NoSePuedenAgregarMasProductos e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(f.ToString());

            //f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)].GuardarInformeDetalladoXml();
            //Jornada j = f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)];
            //Console.WriteLine(j.ToString());

            Console.ReadKey();
        }
    }
}
