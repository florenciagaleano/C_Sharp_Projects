using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoHayActividadEnEsaFechaException : Exception
    {
        public NoHayActividadEnEsaFechaException()
            :base("No hay actividad registrada en la fecha seleccionada")
        {

        }
    }
}
