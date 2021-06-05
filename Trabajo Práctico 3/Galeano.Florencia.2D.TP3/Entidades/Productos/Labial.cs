using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
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

        public Labial(ConsoleColor color, Tipo tipo)
            : base(minutos)
        {
            this.color = color;
            this.tipo = tipo;
        }

        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Labial {this.tipo} || {this.color} || {base.Informe()}");

            return sb.ToString();
        }

        public static bool operator ==(Labial l1, Labial l2)
        {
            if (l1.color == l2.color && l1.tipo == l2.tipo)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Labial l1, Labial l2)
        {
            return !(l1 == l2);
        }
    }
}
