using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        /// <summary>
        /// Constructor de excepción ArchivoException
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar</param>
        /// <param name="innerException">InnerException cuyo mensaje se concatenará almensaje pasado por parámetro</param>
        public ArchivoException(string mensaje,Exception innerException)
            :base(mensaje + innerException.Message)
        {

        }
    }
}
