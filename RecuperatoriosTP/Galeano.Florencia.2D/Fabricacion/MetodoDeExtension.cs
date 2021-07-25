using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Fabricacion
{
    public static class MetodoDeExtension
    {
        /// <summary>
        /// Retorna la cantidad de productos entregados de una fabrica
        /// </summary>
        /// <param name="fabrica">Fábrica cuyos productos fabricados se contaran</param>
        /// <returns></returns>
        public static int CantidadDeProductosEntregados(this Fabrica fabrica)
        {
            int contador = 0;

            foreach (Producto item in fabrica.Productos)
            {
                if(item.EstadoActual == Producto.Estado.Entregado)
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
