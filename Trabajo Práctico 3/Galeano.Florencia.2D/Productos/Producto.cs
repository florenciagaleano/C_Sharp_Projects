using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Productos
{
    [XmlInclude(typeof(Labial))]
    [XmlInclude(typeof(Rimel))]
    [XmlInclude(typeof(Base))]
    public abstract class Producto : ICloneable
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

        /// <summary>
        /// Constructor por defecto de Producto
        /// </summary>
        public Producto()
        {

        }

        /// <summary>
        /// Constructor de producto
        /// </summary>
        /// <param name="minutos">Minutos a asignar al atributo minutos</param>
        protected Producto(int minutos)
        {
            this.minutosPorUnidad = minutos;
            this.estado = Estado.Nuevo;
        }

        /// <summary>
        /// Propiedad de lectura de minutos por unidad
        /// </summary>
        public int MinutosPorUnidad
        {
            get
            {
                return this.minutosPorUnidad;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del estado del producto
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura del vencimiento del producto
        /// </summary>
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
        /// Cadena que retornara fecha de vencimiento de producto y el estado del mismo
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

        /// <summary>
        /// Método a implementar de la interfaz ICloneable
        /// </summary>
        /// <returns></returns>
        public abstract object Clone();
    }
}
