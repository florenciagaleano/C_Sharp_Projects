using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades.Productos;

namespace Entidades
{
    [XmlInclude(typeof(Labial))]
    [XmlInclude(typeof(Rimel))]
    [XmlInclude(typeof(Base))]
    public class Producto
    {
        public enum Estado
        {
            Nuevo,
            Fabricado,
            Envasado,
            Entregado,
        }

        private DateTime vencimiento;
        private int minutosPorUnidad;
        private Estado estado;

        public Producto()
        {

        }

        protected Producto(int minutos)
        {
            this.minutosPorUnidad = minutos;
            this.estado = Estado.Nuevo;
        }

        public int MinutosPorUnidad
        {
            get
            {
                return this.minutosPorUnidad;
            }
        }

        public Estado EstadoActual
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                this.vencimiento = value;
            }
        }

        /// <summary>
        /// Cadena que retornara fecha de vencimiento de producto
        /// </summary>
        /// <returns>String</returns>
        public virtual string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Vencimiento: {this.vencimiento.ToString("dd/MM/yy")} || ");
            if (this.EstadoActual is Producto.Estado.Entregado)
            {
                sb.AppendLine("ENTREGADO");
            }
            else if (this.EstadoActual is Producto.Estado.Nuevo)
            {
                sb.AppendLine("NUEVO");
            }
            else
            {
                sb.AppendLine("FABRICADO SIN ENTREGAR");
            }

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {

            if (p1.minutosPorUnidad == p2.minutosPorUnidad)
            {
                return true;
            }


            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
