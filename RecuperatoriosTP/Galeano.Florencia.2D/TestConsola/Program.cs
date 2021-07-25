using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Excepciones;
using Fabricacion;
using System.Threading;
using Archivos;

namespace TestConsola
{
    class Program
    {
        static Fabrica f = new Fabrica(10);

        static void Main(string[] args)
        {
            Console.Title = "Galeano Florencia 2D";

            try
            {
                Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
                Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
                Base producBase = new Base(100);

                f.HacerPedido(labial, 2);
                f.HacerPedido(rimel, 3);
                /*---------------------------------------------------*/
                List<Producto> lista = new List<Producto>();
                lista.Add(new Labial(ConsoleColor.Black, Labial.Tipo.Gloss));
                lista.Add(new Base(204));
                f.HacerPedido(producBase, 5);

                f.HacerPedido(lista);

                foreach (Producto item in f.Productos)
                {
                    item.InformarEstado += Program.AuxHilos;
                    Fabrica.Fabricar(item, f);
                    DAO.Guardar(item);
                }

            }
            catch (NoSeCargaronProductosException e)
            {
                Console.WriteLine(e.Message);
            }

            Fabrica.CerrarFabrica(f);

            Console.Clear();
            Console.WriteLine(f.ToString());
            Console.WriteLine("-----------------------------------------------------");


            if (f.GuardarActividadTxt(f.ToString()))
                Console.WriteLine("Se guardo la actividad de la fabrica en un txt");

            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("PENDIENTES:\n");
            //Console.WriteLine(f.LeerPendientesXml());//muestro de forma detallada los que quedaron como pendientes
            Console.Clear();
            Console.WriteLine("Leido desde la base de datos:");
            foreach (Producto item in DAO.LeerActividad())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void AuxHilos(object sender, EventArgs e)
        {
            Console.Clear();
            foreach (Producto item in f.Productos)
            {
                Console.WriteLine(item.Informe());
            }
        }
    }
}
