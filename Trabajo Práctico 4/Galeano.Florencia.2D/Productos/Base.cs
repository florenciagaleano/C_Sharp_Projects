using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Base: Producto
    {
        int tono;
        const int minutosPorUnidad = 9;

        /// <summary>
        /// Constructor de base opr defcto
        /// </summary>
        public Base()
        {

        }

        /// <summary>
        /// Constructor de base con un tono a asignar
        /// </summary>
        /// <param name="tono">Tono a asignar</param>
        public Base(int tono)
            : base(minutosPorUnidad)
        {
            this.Tono = tono;
        }


        /// <summary>
        /// Propiedad de lectura y escritura, solo permite settear tono si está entre 200 y 210, sino settea 200
        /// </summary>
        public int Tono
        {
            get
            {
                return this.tono;
            }
            set
            {
                if (this.tono >= 200 && this.tono <= 210)
                {
                    this.tono = value;
                }
                else
                {
                    this.tono = 200;
                }
            }
        }

        /// <summary>
        /// Recopila los datos de Labial
        /// </summary>
        /// <returns>Cadena con la información de Labial</returns>
        public override string Informe()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Base || {this.tono} || {base.Informe()} ");

            return sb.ToString();
        }

        /// <summary>
        /// Clona una Base
        /// </summary>
        /// <returns>Objeto clonado casteado a Base</returns>
        public override object Clone()
        {
            return (Base)new Base(this.tono);
        }

        public override string ToString()
        {
            return this.Informe();
        }
    }
}
