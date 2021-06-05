using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Productos;
using Entidades.Archivos;

namespace Entidades.Fabrica
{
    public class Jornada
    {
        private DateTime fecha;
        private List<Producto> productosAFabricar;
        private int cantidadTrabajadores;

        private Jornada()
        {
            this.productosAFabricar = new List<Producto>();
        }

        public Jornada(DateTime fecha, int cantidadTrabajadores)
            : this()
        {
            this.fecha = fecha;
            this.cantidadTrabajadores = cantidadTrabajadores;
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public List<Producto> ProductosAFabricar
        {
            get
            {
                return this.productosAFabricar;
            }
        }

        public int CalcularTiempo()
        {
            int acum = 0;

            foreach (Producto p in this.productosAFabricar)
            {
                acum += p.MinutosPorUnidad;
            }

            return this.cantidadTrabajadores * 8 * 60 - acum;
        }

        public int CalcularTiempo(Producto p)
        {
            return CalcularTiempo() - p.MinutosPorUnidad;
        }

        public static bool operator +(Jornada j, Producto p)
        {
            //Console.Write(j.CalcularTiempo(p));
            //Console.WriteLine("|| {0}", j.CalcularTiempo());

            if ((j.CalcularTiempo(p) > j.CalcularTiempo()) || j.CalcularTiempo(p) <= 0)
            {
                return false;
            }

            j.productosAFabricar.Add(p);
            return true;
        }

        public string InformeResumido()
        {
            int contadorLabiales = 0;
            int contadorBases = 0;
            int contadorRimel = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"FECHA: {this.fecha}");
            sb.AppendLine("PRODUCTOS FABRICADOS:");

            foreach (Producto item in this.productosAFabricar)
            {
                if (item is Labial)
                {
                    contadorLabiales++;
                }
                else if (item is Base)
                {
                    contadorBases++;
                }
                else
                {
                    contadorRimel++;
                }
            }

            sb.AppendLine($"Rímeles fabricados: {contadorRimel}");
            sb.AppendLine($"Labiales fabricados: {contadorLabiales}");
            sb.AppendLine($"Bases fabricadas: {contadorBases}");


            return sb.ToString();
        }

        public string InformeDetallado()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"FECHA: {this.fecha}");
            sb.AppendLine("PRODUCTOS FABRICADOS:");

            foreach (Producto item in this.productosAFabricar)
            {
                sb.Append(item.Informe());
            }

            return sb.ToString();
        }

        public bool GuardarInformeDetalladoTxt()
        {
            Texto<List<Jornada>> txt = new Texto<List<Jornada>>();
            string ruta ="jornada.txt";
            return txt.Guardar(ruta, this.InformeDetallado());
        }

        public bool GuardarInformeDetalladoXml()
        {
            Xml<Jornada> xml = new Xml<Jornada>();
            string ruta = "Jornada.xml";
            return xml.Guardar(ruta, this);
        }

        public bool GuardarInformeResumidoTxt()
        {
            Texto<List<Jornada>> txt = new Texto<List<Jornada>>();
            string ruta = "jornada.txt";
            return txt.Guardar(ruta, this.InformeResumido());
        }
    }
}
