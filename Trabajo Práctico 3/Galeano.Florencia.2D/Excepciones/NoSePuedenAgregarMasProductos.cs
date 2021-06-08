using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoSePuedenAgregarMasProductos : Exception
    {
        public NoSePuedenAgregarMasProductos(string mensaje)
            :base(mensaje)
        {

        }
    }
}
