using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Excepciones;

namespace Clases.Fabrica
{
    public class Fabrica
    {
        private List<Producto> productos;
        private List<Jornada> jornadas;
        private int cantidadTrabajadores;

        /// <summary>
        /// 
        /// </summary>
        public Fabrica(int trabajadores)
        {
            this.productos = new List<Producto>();
            this.jornadas = new List<Jornada>();
            this.cantidadTrabajadores = trabajadores;
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
        }

        public void HacerPedido(Producto p, int cantidadUnidades)
        {
            for(int i = 0; i < cantidadUnidades; i++)
            {
                this.productos.Add(p);
            }
        }

        public void HacerPedido(List<Producto> listaPedido)
        {
            this.productos.AddRange(listaPedido);
        }

        public static int Fabricar(Fabrica f)//no deberia ser int mañana veo
        {
            DateTime fecha = DateTime.Now;
            Jornada j = new Jornada(fecha,f.cantidadTrabajadores);
            f.jornadas.Add(j);
            int contador = 0;

            for (int i = 0; i < f.productos.Count; i++)
            {
                if (j + f.productos[i])
                {
                    f.productos[i].SeFabrico = true;
                    contador++;
                }
                else
                {
                    fecha = DateTime.Now.AddDays(1);
                    j = new Jornada(fecha, f.cantidadTrabajadores);
                    f.jornadas.Add(j);
                }
            }

            return contador;
        }

        //public static bool Envasar(Fabrica f)
        //{
        //    for (int i = 0; i < f.productosAFabricar.Count; i++)
        //    {
        //        if(f.productosAFabricar[i].SeFabrico)
        //        {
        //            f.productosAFabricar.RemoveAt(i);
        //            f.productos[i].Vencimiento = f.AsignarVencimiento();
        //        }
        //    }

        //    return true;
        //}

        public string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Jornada j in this.Jornadas)
            {
                sb.AppendLine(j.ToString());
            }

            return sb.ToString();
        }

        private DateTime AsignarVencimiento()
        {
            DateTime start = new DateTime(2019, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
