using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Rimel : Producto
    {
        public enum Efecto
        {
            Alargar,
            Curvar,
            Volumen
        }

        Efecto efecto;
        const int minutosPorUnidad = 5;
        ConsoleColor color;

        /// <summary>
        /// Constructor por defecto de Rimel
        /// </summary>
        public Rimel()
        {

        }

        /// <summary>
        /// Constructor de rimel
        /// </summary>
        /// <param name="efecto">Efecto a asignar al atributo efecto</param>
        public Rimel(Efecto efecto)
            : base(minutosPorUnidad)
        {
            this.efecto = efecto;
            color = ConsoleColor.Black;
        }

        
        
        /// <summary>
        /// Constructor de rimel
        /// </summary>
        /// <param name="efecto">Efecto a asignar al atributo efecto</param>
        /// <param name="color">Color a asignar al atributo color</param>
        public Rimel(Efecto efecto, ConsoleColor color)
            : this(efecto)
        {
            this.Color = color;
        }

        /// <summary>
        /// Settea el color de un rimel siempre y cuando sea negro, azul o bordo, de no ser asi asignara el color negro al atributo color
        /// </summary>
        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value == ConsoleColor.Black || value == ConsoleColor.Blue || value == ConsoleColor.DarkRed)
                {
                    this.color = value;
                }
                else
                {
                    this.color = ConsoleColor.Black;
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo efecto de Rimel
        /// </summary>
        public Efecto EfectoRimel
        {
            get
            {
                return this.efecto;
            }set
            {
                this.efecto = value;
            }
        }

        /// <summary>
        /// Recopila los datos de Rimel
        /// </summary>
        /// <returns>Cadena con la información de Rimel</returns>
        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Rimel {this.color} || Efecto {this.efecto} || {base.Informe()}");

            return sb.ToString();
        }

        /// <summary>
        /// Clona una Rimel
        /// </summary>
        /// <returns>Objeto clonado casteado a Rimel</returns>
        public override object Clone()
        {
            return new Rimel(this.efecto,this.color);
        }

        public override string ToString()
        {
            return this.Informe();
        }
    }
}
