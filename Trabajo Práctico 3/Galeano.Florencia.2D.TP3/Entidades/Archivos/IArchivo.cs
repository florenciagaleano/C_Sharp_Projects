using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivo<T>
    {
        bool Guardar(string ruta, T info);
        bool Leer(string ruta,out T info);
    }
}
