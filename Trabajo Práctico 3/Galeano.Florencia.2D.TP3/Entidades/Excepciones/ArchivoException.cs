using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ArchivoException : Exception
    {
        public ArchivoException(string mensaje)
            :base(mensaje)
        {

        }

    }
}
