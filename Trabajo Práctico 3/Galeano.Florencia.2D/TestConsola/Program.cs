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

            Fabrica f = new Fabrica(5);

            try
            {
                Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
                Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
                Base producBase = new Base(100);

                f.HacerPedido(producBase, 50);
                f.HacerPedido(labial, 100); 
                f.HacerPedido(rimel, 10);
                Fabrica.IniciarFabricacion(f);
                /*---------------------------------------------------*/
                List<Producto> lista = new List<Producto>();
                lista.Add(new Labial(ConsoleColor.Black, Labial.Tipo.Gloss));
                lista.Add(new Base(204));
                f.HacerPedido(producBase, 250);//no se fabrican todas las bases en la misma jornada

                f.HacerPedido(lista);

                Fabrica.IniciarFabricacion(f);
            }catch(NoSeCargaronProductosException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine(f.ToString());

            Console.ReadKey();
        }
    }
}
