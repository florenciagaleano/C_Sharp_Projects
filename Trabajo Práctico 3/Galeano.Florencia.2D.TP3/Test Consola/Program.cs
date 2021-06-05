using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos;
using Entidades.Fabrica;

namespace Test_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //informe detallado e informa resumido Lista de pendientes Productos vencidos
            Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
            Labial labial2 = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
            Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
            Base producBase = new Base(100);//deberia settear 200

            Fabrica f = new Fabrica(5); // 5 * 8 * 60 = 2400

            f.HacerPedido(producBase, 150); // 150 * 9 = 1350
            f.HacerPedido(labial, 200); // 200 * 3 = 600
            f.HacerPedido(rimel, 300); // 300* 5 = 1500

            Fabrica.Fabricar(f);
            Fabrica.Envasar(f);
            Fabrica.Distribuir(f);

            Console.WriteLine(f.GenerarInforme());

            Console.ReadKey();
        }
    }
}
