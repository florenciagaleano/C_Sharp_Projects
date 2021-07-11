using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Labial : Producto
    {
        public enum Tipo
        {
            Mate,
            Gloss,
            Liquido
        }

        private ConsoleColor color;
        private const int minutos = 3;//3 minutos por labial
        private Tipo tipo;

        /// <summary>
        /// Constructor por defecto de Labial
        /// </summary>
        public Labial()
        {

        }

        /// <summary>
        /// Constructor de labial con color y tipo a asignar
        /// </summary>
        /// <param name="color">Color a asignar</param>
        /// <param name="tipo">Tipo a asignar</param>
        public Labial(ConsoleColor color, Tipo tipo)
            : base(minutos)
        {
            this.color = color;
            this.tipo = tipo;
        }

        /// <summary>
        /// Propiedad de lectura y escritura de color
        /// </summary>
        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }set
            {
                this.color = value;
            }
        }


        /// <summary>
        /// Propiedad de lectura y escritura del atributo tipo de Labial
        /// </summary>
        public Tipo TipoLabial
        {
            get
            {
                return this.tipo;
            }set
            {
                this.TipoLabial = value;
            }
        }

        /// <summary>
        /// Recopila los datos de Labial
        /// </summary>
        /// <returns>Cadena con la información de Labial</returns>
        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Labial {this.tipo} || {this.color} || {base.Informe()}");

            return sb.ToString();
        }

        /// <summary>
        /// Clona un Labial
        /// </summary>
        /// <returns>Objeto clonado casteado a Labial</returns>
        public override object Clone()
        {
            return new Labial(this.color,this.tipo);
        }

        public override string ToString()
        {
            return this.Informe();
        }

    }
}
