using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoHayActividadEnEsaFechaException : Exception
    {
        /// <summary>
        /// Constructor de la excepción
        /// Se lanza cuando se busca una jornada en la que no hay actividad
        /// </summary>
        public NoHayActividadEnEsaFechaException()
            :base("No hay actividad registrada en la fecha seleccionada")
        {

        }
    }
}
