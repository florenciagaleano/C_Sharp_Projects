using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Método usado para guardar archivo
        /// </summary>
        /// <param name="ruta">Ruta del archivo</param>
        /// <param name="info">Información a guardar en el archivo</param>
        /// <returns></returns>
        bool Guardar(string ruta, T info);

        /// <summary>
        /// Método usado para leer un archivo
        /// </summary>
        /// <param name="ruta">Ruta de la cuál se leerá el archivo</param>
        /// <returns>Información que contiene el archivo</returns>
        T Leer(string ruta);
    }
}
