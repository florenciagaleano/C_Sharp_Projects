using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using Productos;

namespace Fabricacion
{
    public class Fabrica
    {
        private List<Producto> productos;
        private List<Jornada> jornadas;
        private int cantidadTrabajadores;

        public Fabrica() { }

        /// <summary>
        /// Constructor de fábrica
        /// </summary>
        /// <param name="trabajadores">Cantidad de trabajadores</param>
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

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
        }

        public int BuscarIndiceJornadaPorFecha(DateTime fecha)
        {
            int indice = -1;

            for (int i = 0; i < this.jornadas.Count; i++)
            {
                if (jornadas[i].Fecha == fecha)
                {
                    indice = i;
                }
            }

            if (indice == -1)
            {
                throw new NoHayActividadEnEsaFechaException();
            }

            return indice;
        }

        public void HacerPedido(Producto p, int cantidadUnidades)
        {
            for (int i = 0; i < cantidadUnidades; i++)
            {
                Producto nuevo = (Producto)p.Clone();
                this.productos.Add(nuevo);
            }
        }

        public void HacerPedido(List<Producto> listaPedido)
        {
            this.productos.AddRange(listaPedido);
        }

        public static Jornada operator +(Fabrica f, Jornada j)
        {
            if (f != j)
            {
                f.jornadas.Add(j);
            }
            else
            {
                j = f.jornadas[f.BuscarIndiceJornadaPorFecha(j.Fecha)];
            }

            return j;
        }

        public static int Fabricar(Fabrica f)//no deberia ser int mañana veo
        {
            DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Jornada j = f + new Jornada(fecha, f.cantidadTrabajadores);
            int contador = 0;

            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual == Producto.Estado.Nuevo)
                {
                    if (j + p)
                    {
                        contador++;
                    }
                }else
                {
                    fecha = new DateTime(DateTime.Now.AddDays(1).Year, DateTime.Now.AddDays(1).Month, DateTime.Now.AddDays(1).Day);
                    j = f + new Jornada(fecha, f.cantidadTrabajadores);
                }
            }

            return contador;
        }

        public static int Envasar(Fabrica f)
        {
            int contador = 0;
            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual is Producto.Estado.Fabricado)
                {
                    p.Vencimiento = f.AsignarVencimiento();
                    if (p.Vencimiento > DateTime.Now)
                    {
                        contador++;
                        p.EstadoActual = Producto.Estado.Envasado;
                    }

                }
            }

            return contador;
        }

        public static int Distribuir(Fabrica f)
        {
            int contador = 0;
            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual is Producto.Estado.Envasado)
                {
                    p.EstadoActual = Producto.Estado.Entregado;
                    contador++;
                }
            }

            return contador;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada j in this.Jornadas)
            {
                sb.AppendLine(j.InformeResumido());
            }

            return sb.ToString();
        }

        private DateTime AsignarVencimiento()
        {
            return DateTime.Now.AddDays(new Random().Next(3 * 365));
        }

        public static bool operator ==(Fabrica f, Jornada j)
        {
            foreach (Jornada item in f.jornadas)
            {
                if (item.Fecha.Day == j.Fecha.Day && item.Fecha.Month == j.Fecha.Month && item.Fecha.Year == j.Fecha.Year)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Fabrica f, Jornada j)
        {
            return !(f == j);
        }
    }
}
