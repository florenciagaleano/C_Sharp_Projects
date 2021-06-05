using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Entidades.Excepciones;

namespace Entidades.Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string ruta, T info)
        {
            bool seGuardo = false;
            try
            {
                using (XmlWriter writer = new XmlTextWriter(ruta,Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    ser.Serialize(writer,info); ;
                    seGuardo = true;
                }
            }catch(Exception)
            {
                throw new ArchivoException("Problemas para guardar el arechivo en formato XML");
            }

            return seGuardo;
        }

        public bool Leer(string ruta,out T info)
        {
            info = default;
            bool seLeyo = false;

            try
            {
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    info = (T)ser.Deserialize(reader);
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
