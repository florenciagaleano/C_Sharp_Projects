using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoSeCargaronProductosException : Exception
    {
        /// <summary>
        /// Constructor de la excepción
        /// Se lanza cuando se quiere iniciar un proceso de la fabricación sin que se haya hecho un pedido
        /// </summary>
        /// <param name="mensaje"></param>
        public NoSeCargaronProductosException(string mensaje)
            :base(mensaje)
        {

        }
    }
}
