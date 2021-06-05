using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clases.Excepciones;

namespace Clases.Archivos
{
    public class Texto<T> : IArchivo<T>
    {
        public bool Guardar(string ruta, T info)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (!File.Exists(ruta))
                    {
                        File.Create(ruta);
                    }


                    writer.WriteLine(info.ToString());
                }
            }
            catch (Exception)
            {
                throw new
                return false;
            }
        }

        public T Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
