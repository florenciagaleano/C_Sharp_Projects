using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Threading;

namespace Productos
{
    public delegate void DelegadoEstados(object producto);

    [XmlInclude(typeof(Labial))]
    [XmlInclude(typeof(Rimel))]
    [XmlInclude(typeof(Base))]
    public abstract class Producto : ICloneable
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformarEstado;

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

            switch(this.EstadoActual)
            {
                case Estado.Entregado:
                    sb.Append($"Vencimiento: {this.vencimiento.ToString("dd/MM/yy")} || ");
                    sb.AppendLine("ENTREGADO");
                    break;
                case Estado.Nuevo:
                    sb.AppendLine("NUEVO");
                    break;
                default:
                    sb.Append($"Vencimiento: {this.vencimiento.ToString("dd/MM/yy")} || ");
                    sb.AppendLine("FABRICADO SIN ENTREGAR");
                    break;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Método a implementar de la interfaz ICloneable
        /// </summary>
        /// <returns></returns>
        public abstract object Clone();

        public void ActualizarEstados()
        {
            Random r = new Random();

            while (this.EstadoActual != Estado.Entregado)
            {
                switch (this.EstadoActual)
                {
                    case Estado.Nuevo:
                        Thread.Sleep(r.Next(4000, 6000));
                        this.EstadoActual = Estado.Fabricado;
                        this.InformarEstado.Invoke(this, EventArgs.Empty);
                        break;
                    case Estado.Fabricado:
                        Thread.Sleep(r.Next(3000, 6000));
                        this.EstadoActual = Estado.Envasado;
                        this.InformarEstado.Invoke(this, EventArgs.Empty);
                        break;
                    case Estado.Envasado:
                        Thread.Sleep(r.Next(3000, 6000));
                        this.EstadoActual = Estado.Entregado;
                        this.InformarEstado.Invoke(this, EventArgs.Empty);
                        break;
                    case Estado.Entregado:
                        Thread.Sleep(r.Next(3000, 6000));
                        this.EstadoActual = Estado.Entregado;
                        this.InformarEstado.Invoke(this, EventArgs.Empty);
                        break;
                }
            }

        }
    }
}
