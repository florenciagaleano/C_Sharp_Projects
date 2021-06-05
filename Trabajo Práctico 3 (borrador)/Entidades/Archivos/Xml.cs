using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases.Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string ruta, T info)
        {
            return true;
        }

        public T Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
