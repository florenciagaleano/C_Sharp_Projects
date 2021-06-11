using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excepciones;


namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda datos en un archivo XML
        /// </summary>
        /// <param name="ruta">Ruta en la que se guardará el archivo</param>
        /// <param name="info">Información a guadar</param>
        /// <returns>True si se pudo guardar, sino se lanza una excepción</returns>
        public bool Guardar(string ruta, T info)
        {
            bool seGuardo;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, info);
                }
                seGuardo = true;
            }
            catch (Exception e)
            {
                throw new ArchivoException("Problemas para guardar el archivo en formato XML. ",e);
            }

            return seGuardo;
        }

        /// <summary>
        /// Lee un archivo de tipo XML
        /// </summary>
        /// <param name="ruta">Ruta de la cuál se lee el archivo</param>
        /// <returns>La información contenida en el archivo</returns>
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
            catch (Exception e)
            {
                throw new ArchivoException("Problemas para leer el archivo en formato XML. ",e);
            }
        }

    }
}
