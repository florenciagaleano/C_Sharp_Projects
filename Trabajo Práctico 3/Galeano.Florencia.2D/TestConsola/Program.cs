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
            DateTime d = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day);
            //informe detallado e informa resumido Lista de pendientes Productos vencidos
            Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
            Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
            Base producBase = new Base(100);//deberia settear 200
            
            Fabrica f = new Fabrica(5); // 5 * 8 * 60 = 2400
            f.HacerPedido(producBase, 150); // 150 * 9 = 1350
            f.HacerPedido(labial, 200); // 200 * 3 = 600
            f.HacerPedido(rimel, 300); // 300* 5 = 1500

            Fabrica.Fabricar(f);
            Fabrica.Envasar(f);
            Fabrica.Distribuir(f);
            /*---------------------------------------------------*/
            List<Producto> lista = new List<Producto>();
            lista.Add(new Labial(ConsoleColor.Black,Labial.Tipo.Gloss));
            lista.Add(new Base(204));
            lista.Add(labial);
            lista.Add(rimel);
            lista.Add(producBase);
            f.HacerPedido(lista); // 300* 5 = 1500

            Fabrica.Fabricar(f);
            Fabrica.Envasar(f);
            Fabrica.Distribuir(f);

            //se crean dos jornadas porque no alcanza el tiempo para fabricar todo en una sola

            Console.WriteLine(f.ToString());
            //f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)].GuardarInformeDetalladoXml();
            //f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)].GuardarInformeResumidoTxt();

            //Console.WriteLine(f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)].LeerInformeDetalladoXml());
            //Console.WriteLine(f.Jornadas[f.BuscarIndiceJornadaPorFecha(DateTime.Today)].LeerInformeResumidoTxt());

            Console.ReadKey();
        }
    }
}
