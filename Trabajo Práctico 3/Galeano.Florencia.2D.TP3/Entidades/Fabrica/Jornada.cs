using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos;

namespace Entidades.Fabrica
{
    public class Jornada
    {
        private DateTime fecha;
        private List<Producto> productosAFabricar;
        private int cantidadTrabajadores;

        private Jornada()
        {
            this.productosAFabricar = new List<Producto>();
        }

        public Jornada(DateTime fecha, int cantidadTrabajadores)
            : this()
        {
            this.fecha = fecha;
            this.cantidadTrabajadores = cantidadTrabajadores;
        }

        public int CalcularTiempo()
        {
            int acum = 0;

            foreach (Producto p in this.productosAFabricar)
            {
                acum += p.MinutosPorUnidad;
            }

            return this.cantidadTrabajadores * 8 * 60 - acum;
        }

        public int CalcularTiempo(Producto p)
        {
            return CalcularTiempo() - p.MinutosPorUnidad;
        }

        public static bool operator +(Jornada j, Producto p)
        {
            //Console.Write(j.CalcularTiempo(p));
            //Console.WriteLine("|| {0}", j.CalcularTiempo());

            if ((j.CalcularTiempo(p) > j.CalcularTiempo()) || j.CalcularTiempo(p) <= 0)
            {
                return false;
            }

            j.productosAFabricar.Add(p);
            return true;
        }

        public override string ToString()
        {
            int contadorLabiales = 0;
            int contadorBases = 0;
            int contadorRimel = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha: {this.fecha}");
            sb.AppendLine("Productos:");

            foreach (Producto item in this.productosAFabricar)
            {
                if (item is Labial)
                {
                    contadorLabiales++;
                }
                else if (item is Base)
                {
                    contadorBases++;
                }
                else
                {
                    contadorRimel++;
                }
            }

            sb.AppendLine($"Rímeles fabricados: {contadorRimel}");
            sb.AppendLine($"Labiales fabricados: {contadorLabiales}");
            sb.AppendLine($"Bases fabricadas: {contadorBases}");


            return sb.ToString();
        }
    }
}
