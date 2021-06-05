using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Excepciones;

namespace Entidades.Archivos
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
            catch (Exception)
            {
                throw new ArchivoException("Problema al guardar en formato texto");
            }

            return seGuardo;
        }

        public bool Leer(string ruta,out string info)
        {
            info = default;
            bool seLeyo = false;

            try
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    info = reader.ReadToEnd();
                }
                seLeyo = true;
            }
            catch (Exception)
            {
                throw new ArchivoException("Problemas para leer el archivo en formato XML");
            }

            return seLeyo;
        }
    }
}
