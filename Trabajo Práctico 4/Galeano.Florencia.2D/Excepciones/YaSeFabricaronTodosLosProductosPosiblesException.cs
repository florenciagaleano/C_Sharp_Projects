using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class YaSeFabricaronTodosLosProductosPosiblesException : Exception
    {
        public YaSeFabricaronTodosLosProductosPosiblesException()
            :base("Ya no se pueden fabricar mas productos por hoy")
        {

        }
    }
}
