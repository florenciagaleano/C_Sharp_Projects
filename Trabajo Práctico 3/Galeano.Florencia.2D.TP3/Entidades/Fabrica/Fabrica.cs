using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Archivos;

namespace Entidades.Fabrica
{
    public class Fabrica
    {
        private List<Producto> productos;
        private List<Jornada> jornadas;
        private int cantidadTrabajadores;
        
        /// <summary>
        /// Constructor de fábrica
        /// </summary>
        /// <param name="trabajadores">Cantidad de trabajadores</param>
        public Fabrica(int trabajadores)
        {
            this.productos = new List<Producto>();
            this.jornadas = new List<Jornada>();
            this.cantidadTrabajadores = trabajadores;
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
        }

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
        }

        public int BuscarIndiceJornadaPorFecha(DateTime fecha)
        {
            int indice = -1;

            for (int i = 0; i < this.jornadas.Count; i++)
            {
                if(jornadas[i].Fecha == fecha)
                {
                    indice = i;
                }
            }

            if(indice == -1)
            {
                throw new NoHayActividadEnEsaFechaException();
            }

            return indice;
        }

        public void HacerPedido(Producto p, int cantidadUnidades)
        {
            for (int i = 0; i < cantidadUnidades; i++)
            {
                this.productos.Add(p);
            }
        }

        public void HacerPedido(List<Producto> listaPedido)
        {
            this.productos.AddRange(listaPedido);
        }

        public static int Fabricar(Fabrica f)//no deberia ser int mañana veo
        {
            DateTime fecha = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            Jornada j = new Jornada(fecha, f.cantidadTrabajadores);
            f.jornadas.Add(j);
            int contador = 0;

            for (int i = 0; i < f.productos.Count; i++)
            {
                if (j + f.productos[i])
                {
                    f.productos[i].EstadoActual = Producto.Estado.Fabricado;
                    if (fecha == DateTime.Now)
                    {
                        contador++;
                    }
                }
                else
                {
                    fecha = DateTime.Now.AddDays(1);
                    j = new Jornada(fecha, f.cantidadTrabajadores);
                    f.jornadas.Add(j);
                }
            }

            return contador;
        }

        public static int Envasar(Fabrica f)
        {
            int contador = 0;
            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual is Producto.Estado.Fabricado)
                {
                    p.Vencimiento = f.AsignarVencimiento();
                    if(p.Vencimiento > DateTime.Now)
                    {
                        contador++;
                        p.EstadoActual = Producto.Estado.Envasado;
                    }

                }
            }

            return contador;
        }

        public static int Distribuir(Fabrica f)
        {
            int contador = 0;
            foreach (Producto p in f.productos)
            {
                if (p.EstadoActual is Producto.Estado.Envasado)
                {
                    p.EstadoActual = Producto.Estado.Entregado;
                    contador++;
                }
            }

            return contador;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada j in this.Jornadas)
            {
                sb.AppendLine(j.InformeResumido());
            }

            return sb.ToString();
        }

        private DateTime AsignarVencimiento()
        {
            return DateTime.Now.AddDays(new Random().Next(3*365));
        }

        public bool GuardarListaPendientesXml()
        {
            Xml<List<Jornada>> txt = new Xml<List<Jornada>>();
            string ruta = "Pendientes.xml";
            List <Producto>  pendientes= new List<Producto>();

            if(this.jornadas.Count > 0)
            {
                for(int i = 1; i<jornadas.Count; i++)
                {
                    pendientes.AddRange(this.jornadas[i].ProductosAFabricar);
                }
            }
           
            return txt.Guardar(ruta,this.Jornadas);
        }

        //public string LeerPendientes()
        //{
        //    Xml<List<Producto>> xml = new Xml<List<Producto>>();
        //    string ruta = "Pendientes.xml";
        //    List<Producto> pendientes = new List<Producto>();

        //    return (xml.Leer(ruta)).ToString();
        //}
    }
}
