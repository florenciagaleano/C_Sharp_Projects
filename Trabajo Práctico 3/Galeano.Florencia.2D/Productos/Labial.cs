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

        public Labial()
        {

        }

        public Labial(ConsoleColor color, Tipo tipo)
            : base(minutos)
        {
            this.color = color;
            this.tipo = tipo;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

        public Tipo TipoLabial
        {
            get
            {
                return this.tipo;
            }
        }

        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Labial {this.tipo} || {this.color} || {base.Informe()}");

            return sb.ToString();
        }

        public override object Clone()
        {
            return new Labial(this.color,this.tipo);
        }
    }
}
