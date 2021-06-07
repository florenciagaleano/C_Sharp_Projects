using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto<T> : IArchivo<string>
    {
        public bool Guardar(string ruta, string info)
        {
            bool seGuardo = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (!File.Exists(ruta))
                    {
                        File.Create(ruta);
                    }

                    writer.WriteLine(info.ToString());
                    seGuardo = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Problema al guardar en formato texto. " + e.Message);
            }

            return seGuardo;
        }

        public string Leer(string ruta)
        {
            try
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw new ArchivoException("Problemas para leer el archivo en formato XML");
            }
        }
    }
}
