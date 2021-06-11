using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Archivos;

namespace Fabricacion
{
    public class Jornada
    {
        private DateTime fecha;
        private List<Producto> productosAFabricar;
        private int cantidadTrabajadores;

        /// <summary>
        /// Constructor de jornada que inicializa la lista de productos
        /// </summary>
        public Jornada()
        {
            this.productosAFabricar = new List<Producto>();
        }

        /// <summary>
        /// Constructor de Jornada
        /// </summary>
        /// <param name="fecha">Fecha a asignar a jornada</param>
        /// <param name="cantidadTrabajadores">Cantidad de trabajadores a asignar</param>
        public Jornada(DateTime fecha, int cantidadTrabajadores)
            : this()
        {
            this.fecha = fecha;
            this.cantidadTrabajadores = cantidadTrabajadores;
        }

        /// <summary>
        /// Propiedad de lectura y escritura de cantidad de trabajadores
        /// </summary>
        public int CantidadTrabajadores
        {
            get
            {
                return this.cantidadTrabajadores;
            }set
            {
                this.cantidadTrabajadores = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de fecha de la jornada
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }set
            {
                this.fecha = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de losproductos a fabricar
        /// </summary>
        public List<Producto> ProductosAFabricar
        {
            get
            {
                return this.productosAFabricar;
            }
            set
            {
                this.productosAFabricar = value;
            }
        }

        /// <summary>
        /// Método que calcula la cantidad de tiempo isponible de acuerdo a la cantidad de trabajadores y a los productos a fabricar
        /// </summary>
        /// <returns>La cantidad de tiempo disponible en minutos</returns>
        private int CalcularTiempo()
        {
            int acum = 0;

            foreach (Producto p in this.productosAFabricar)
            {
                acum += p.MinutosPorUnidad;
            }

            return this.cantidadTrabajadores * 8 * 60 - acum;
        }

        /// <summary>
        /// Método que calcula la cantida de tiempo disponible restando la cantidad de tiempo de determinado producto
        /// </summary>
        /// <param name="p">Producto cuyo tiempo se restará</param>
        /// <returns>La cantidad de tiempo en miutos</returns>
        private int CalcularTiempo(Producto p)
        {
            return CalcularTiempo() - p.MinutosPorUnidad;
        }

        /// <summary>
        /// Sobrecarga del operador + que retorna falso y no agrega al producot si no hay tiempo o el producto ya está fabricado
        /// </summary>
        /// <param name="j">Jornada a la cual agregar prducto</param>
        /// <param name="p">Producto a agregar</param>
        /// <returns>True si se agrego el producto a la lista de productos a fabricar y sino false</returns>
        public static bool operator +(Jornada j, Producto p)
        {

            if (((j.CalcularTiempo(p) > j.CalcularTiempo()) || j.CalcularTiempo(p) <= 0)|| p.EstadoActual != Producto.Estado.Nuevo)
            {
                return false;
            }

            j.productosAFabricar.Add(p);
            return true;
        }

        /// <summary>
        /// Genera una informa resumido inidanco la cantidad de productos de cada tipo que se fabricaron
        /// </summary>
        /// <returns></returns>
        public string InformeResumido()
        {
            int contadorLabiales = 0;
            int contadorBases = 0;
            int contadorRimel = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"FECHA: {this.fecha.ToString("dd'/'MM'/'yy")}");
            sb.AppendLine("PRODUCTOS FABRICADOS:");

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

        /// <summary>
        /// Sobrecarga que retorna el informe detallado
        /// </summary>
        /// <returns>Informe detallado</returns>
        public override string ToString()
        {
            return this.InformeDetallado();
        }

        /// <summary>
        /// Informe detallado de los productos fabricados
        /// </summary>
        /// <returns></returns>
        public string InformeDetallado()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"FECHA: {this.fecha}");
            sb.AppendLine("PRODUCTOS FABRICADOS:");

            foreach (Producto item in this.productosAFabricar)
            {
                sb.Append(item.Informe());
            }

            return sb.ToString();
        }
        
    }
}
