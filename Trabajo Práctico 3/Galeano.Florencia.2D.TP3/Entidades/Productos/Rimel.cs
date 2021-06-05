using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public class  Rimel : Producto
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

        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rimel {this.color} || Efecto {this.efecto} || {base.Informe()}");

            return sb.ToString();
        }

        public static bool operator ==(Rimel r1, Rimel r2)
        {
            if (r1.color == r2.color && r1.efecto == r2.efecto)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Rimel r1, Rimel r2)
        {
            return !(r1 == r2);
        }
    }
}
