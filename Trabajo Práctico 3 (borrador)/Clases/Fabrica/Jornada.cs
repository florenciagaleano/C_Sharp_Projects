using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Fabrica
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

        public Jornada(DateTime fecha,int cantidadTrabajadores)
            :this()
        {
            this.fecha = fecha;
            this.cantidadTrabajadores = cantidadTrabajadores;
        }

        public int CalcularTiempo()
        {

            return this.cantidadTrabajadores * 8 * 60;
        }

        public int CalcularTiempo(Producto p)
        {
            int acum = p.MinutosPorUnidad;

            foreach (Producto item in this.productosAFabricar)
            {
                acum += item.MinutosPorUnidad;
            }

            return acum;
        }

        public static bool operator +(Jornada j,Producto p)
        {

            if (j.CalcularTiempo(p) > j.CalcularTiempo())
            {
                return false;
            }

            j.productosAFabricar.Add(p);
            return true;
        }
    }
}
