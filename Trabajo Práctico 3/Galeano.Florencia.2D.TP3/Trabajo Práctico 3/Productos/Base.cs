using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Base : Producto
    {
        int tono;
        const int minutosPorUnidad = 9;

        public Base(int tono)
            :base(minutosPorUnidad)
        {
            this.Tono = tono;
        }

        /// <summary>
        /// Propiedad de solo escritura que solo asignara un tono si el valor esta entre 200 y 210, de no estarlo se asignara 200
        /// </summary>
        protected int Tono
        {
            set
            {
                if(this.tono >= 200 && this.tono <= 210)
                {
                    this.tono = value;
                }else
                {
                    this.tono = 200;
                }
            }
        }

        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Base || {this.tono} || {base.Informe()} || ");
            if(this.EstadoActual is Producto.Estado.Entregado)
            {
                sb.AppendLine("ENTREGADO");
            }else if(this.EstadoActual is Producto.Estado.Nuevo)
            {
                sb.AppendLine("NUEVO");
            }
            else
            {
                sb.AppendLine("FABRICADO SIN ENTREGAR");
            }


            return sb.ToString();
        }

        public static bool operator ==(Base b1, Base b2)
        {
            if (b1.tono == b2.tono)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Base b1, Base b2)
        {
            return !(b1 == b2);
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("Producto: Base");
        //    sb.AppendLine($"Color: {this.tono}");

        //    return sb.ToString();
        //}

    }
}
