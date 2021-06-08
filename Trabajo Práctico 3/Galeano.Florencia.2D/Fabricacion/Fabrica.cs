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

        /// <summary>
        /// Constructor por defecto de Fabrica
        /// </summary>
        public Fabrica()
        { 

        }

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

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de Jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }set
            {
                this.jornadas = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura delalista de Productos
        /// </summary>
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }set
            {
                this.productos = value;
            }
        }

        /// <summary>
        /// Metodo que busca el indice de una jornada de acuerdo a una fecha
        /// </summary>
        /// <param name="fecha">Fecha a buscar</param>
        /// <returns>Jornada encontrada con esa fecha o lanza una excepción si no se encontró</returns>
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

        /// <summary>
        /// Método para hacer pedido de una determinada cantidad de unidades de un mismo producto
        /// </summary>
        /// <param name="p">Producto del pedido</param>
        /// <param name="cantidadUnidades">Cantidad de unidades de dicho producto</param>
        public void HacerPedido(Producto p, int cantidadUnidades)
        {
            for (int i = 0; i < cantidadUnidades; i++)
            {
                Producto nuevo = (Producto)p.Clone();
                this.productos.Add(nuevo);
            }
        }

        /// <summary>
        /// Método para hacer pedido de una lista de productos
        /// </summary>
        /// <param name="listaPedido">Lista de productos a agregar al pedido</param>
        public void HacerPedido(List<Producto> listaPedido)
        {
            this.productos.AddRange(listaPedido);
        }

        /// <summary>
        /// Sobrecarga de operador + que agrega una jornada a la lista de jornadas
        /// </summary>
        /// <param name="f">Fábrica en la qie se cargará la jornada</param>
        /// <param name="j">Jornada a agregar</param>
        /// <returns>La nueva jornada si no hay ninguna en esa fecha o sino la jornada de esa fecha</returns>
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


        public static void IniciarFabricacion(Fabrica f)
        {
            Fabrica.Fabricar(f);
            Fabrica.Envasar(f);
            Fabrica.Distribuir(f);
        }

        public static int Fabricar(Fabrica f)//no deberia ser int mañana veo
        {
            DateTime fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Jornada j = f + new Jornada(fecha, f.cantidadTrabajadores);
            int contador = 0;
            bool agregarJornada = false;

            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual == Producto.Estado.Nuevo)
                {
                    if (j + p)
                    {
                        p.EstadoActual = Producto.Estado.Fabricado;
                        contador++;
                    }else
                    {
                        agregarJornada = true;
                    }
                }
            }

            if(agregarJornada)
            {
                f.ActualizarPendientes();
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

        public void ActualizarPendientes()
        {
            DateTime fecha = new DateTime(DateTime.Now.AddDays(1).Year, DateTime.Now.AddDays(1).Month, DateTime.Now.AddDays(1).Day);
            Jornada j = this + new Jornada(fecha,this.cantidadTrabajadores);
            bool seAgrego;

            foreach (Producto item in this.productos)
            {
                if(item.EstadoActual == Producto.Estado.Nuevo)
                {
                    seAgrego = j + item;
                }
            }

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

        public bool GuardarPendientesTxt()
        {
            Texto<string> txt = new Texto<string>();
            List<string> pendientes = new List<string>();

            foreach (Producto item in this.productos)
            {
                if(item.EstadoActual == Producto.Estado.Nuevo)
                {
                    pendientes.Add(item.Informe());
                }
            }

            return txt.Guardar("Pendientes.txt", pendientes.ToString());
        }
    }
}
