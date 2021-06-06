using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Entidades.Excepciones;
using Entidades.Fabrica;
using System.IO;

namespace Entidades.Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string ruta, T info)
        {
            bool seGuardo = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, info);
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Problemas para guardar el archivo en formato XML. " + e.InnerException.Message);
            }

            return seGuardo;
        }

        public T Leer(string ruta)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    return (T)ser.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                throw new ArchivoException("Problemas para leer el archivo en formato XML");
            }
        }

    }
}
