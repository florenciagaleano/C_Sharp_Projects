using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Fabrica
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

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
        }

        public void HacerPedido(Producto p, int cantidadUnidades)
        {
            for (int i = 0; i < cantidadUnidades; i++)
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
            Jornada j = new Jornada(fecha, f.cantidadTrabajadores);
            f.jornadas.Add(j);
            int contador = 0;

            for (int i = 0; i < f.productos.Count; i++)
            {
                if (j + f.productos[i])
                {
                    f.productos[i].EstadoActual = Producto.Estado.Fabricado;
                    if (fecha == DateTime.Now)
                    {
                        contador++;
                    }
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

        public static int Envasar(Fabrica f)
        {
            int contador = 0;
            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual is Producto.Estado.Fabricado)
                {
                    p.Vencimiento = f.AsignarVencimiento();
                    if (f.ValidarVencimiento(p))
                    {
                        contador++;
                        p.EstadoActual = Producto.Estado.Envasado;
                    }
                    else
                    {
                        p.EstadoActual = Producto.Estado.Vencido;
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

        public bool ValidarVencimiento(Producto p)
        {
            if (p.Vencimiento <= DateTime.Now)
            {
                return false;
            }

            return true;
        }

        public string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada j in this.Jornadas)
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
