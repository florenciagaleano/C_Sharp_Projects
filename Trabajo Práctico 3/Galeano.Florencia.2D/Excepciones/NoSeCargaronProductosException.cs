using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoSeCargaronProductosException : Exception
    {
        public NoSeCargaronProductosException(string mensaje)
            :base(mensaje)
        {

        }
    }
}
