using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Fabrica;
using Clases;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Labial labial = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
            Labial labial2 = new Labial(ConsoleColor.Red, Labial.Tipo.Liquido);
            Rimel rimel = new Rimel(Rimel.Efecto.Volumen);
            Base producBase = new Base(100);//deberia settear 200

            Fabrica f = new Fabrica(1);

            f.HacerPedido(producBase, 150);
            f.HacerPedido(labial, 200);
            f.HacerPedido(rimel, 300);
            
            Fabrica.Fabricar(f);


            //jornadas rompe
            //el + no anda
            Console.WriteLine(f.GenerarInforme());
 
            Console.ReadKey();

            //arreglar lo de jornada, fabricar es el que no anda

        //    public static Universidad operator +(Universidad u, EClases clase)
        //{
        //    //creo mi objeto jornada con el primer profesor disponible(operador ==) y la clase recibida.
        //    Jornada jornadaNueva = new Jornada(clase, u == clase);
        //    foreach (Alumno item in u.Alumnos)
        //    {
        //        if (item == clase)
        //        {
        //            jornadaNueva += item;
        //        }

        //    }

        //    int indice = u.Jornadas.Count;
        //    u[indice] = jornadaNueva;

        //    return u;
        //}
    }
    }
}
