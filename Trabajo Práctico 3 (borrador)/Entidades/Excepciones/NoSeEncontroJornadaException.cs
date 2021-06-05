using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class NoSeEncontroJornadaException : Exception
    {
        public NoSeEncontroJornadaException()
            :base("No hay ninguna jornada cargada en esa fecha")
        {

        }
    }
}
