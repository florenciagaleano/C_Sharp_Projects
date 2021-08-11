using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que inicializa a Numero en 0
        /// </summary>
        public Numero()
            :this(0)
        {
        
        }

        /// <summary>
        /// Constructor que asigna a número el valor pasado por parámetro
        /// </summary>
        /// <param name="numero">Valor con que se inicializará el atributo numero de Numero</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asigna a número el valor pasado por parámetro convertido a double
        /// </summary>
        /// <param name="numero">Valor con que se inicializará el atributo numero de Numero</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Valida que el valor sea númerico y se lo asigna al atributo numero de Numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Valida que la cadena pasada por parámetro sea numérica
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>La cadena numérica como un double o 0 si la cadena no era numérica</returns>
        private double ValidarNumero(string strNumero)
        {
            double numValidado;

            if(!Double.TryParse(strNumero, out numValidado))
            {
                numValidado = 0;
            }

            return numValidado;
        }

        /// <summary>
        /// Valida que la cadena pasada por parámetro solo contenga '0' y/o '1'
        /// </summary>
        /// <param name="binario">Cadena a validar</param>
        /// <returns>True si la cadena solo esta formada por '1' y '0', sino False</returns>
        private bool EsBinario(string binario)
        {

            foreach(char item in binario)
            {
                if( item != '1' && item != '0' )
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convierte un número de decimal a binario
        /// </summary>
        /// <param name="numero">Número que se convertirá a binario</param>
        /// <returns>Número convertido a binario o "Valor inválido" si el número no se puede convertir</returns>
        public string DecimalBinario(double numero)
        {
            string bin = "Valor inválido";
            long num;

            if(numero > 0)
            {
                num = (long)numero;
                bin = "";
                while (num > 0)
                {
                    bin = (num % 2).ToString() + bin;
                    num /= 2;
                }
            }else if(numero == 0)
            {
                bin = "0";
            }
 

            return bin;
        }

        /// <summary>
        /// Convierte una cadena numérica de decimal a binario
        /// </summary>
        /// <param name="numero">Cadena númerica que se convertirá a binario</param>
        /// <returns>Cadena numérica convertida a binario o "Valor inválido" si el número no se puede convertir</returns>
        public string DecimalBinario(string numero)
        {
            double numeroParseado;
            double.TryParse(numero, out numeroParseado);

            return DecimalBinario(numeroParseado);
        }

        /// <summary>
        /// Convierte un número de binario a decimal
        /// </summary>
        /// <param name="numero">Cadena binaria a convertir</param>
        /// <returns>El número en formato cadena o "Valor inválido" si no se pudo convertir</returns>
        public string BinarioDecimal(string numero)
        {
            string retorno = "Valor inválido";
            double numASumar = 0;

            if(EsBinario(numero))
            {
                for (int i = 0; i < numero.Length; i++)
                {

                    if (numero[i] == '1')
                    {
                        double len = numero.Length - 1 - i;
                        numASumar += Math.Pow(2, len);//los voy sumando here
                    }
                }

                retorno = numASumar.ToString();
            }

            return retorno;
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador "-"
        /// </summary>
        /// <param name="n1">Primer Numero a restar</param>
        /// <param name="n2">Segundo Número a restar</param>
        /// <returns>La resta de ambos Números</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador "+"
        /// </summary>
        /// <param name="n1">Primer Numero a sumar</param>
        /// <param name="n2">Segundo Número a sumar</param>
        /// <returns>La suma de ambos Números</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador "*"
        /// </summary>
        /// <param name="n1">Primer Numero a multiplicar</param>
        /// <param name="n2">Segundo Número a multiplicar</param>
        /// <returns>La multiplicación de ambos Números</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador "/"
        /// </summary>
        /// <param name="n1">Primer Numero a dividir</param>
        /// <param name="n2">Segundo Número a dividir</param>
        /// <returns>La suma de ambos Números</returns>
        public static double operator /(Numero n1, Numero n2)
        {

            if (n2.numero == 0)
            {
                return Double.MinValue;
            }

            return n1.numero / n2.numero;

        }
        #endregion
    }
}
