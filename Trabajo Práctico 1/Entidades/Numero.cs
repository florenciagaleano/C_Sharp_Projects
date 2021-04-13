using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Los operadores realizarán las operaciones correspondientes entre dos números.
Si se tratara de una división por 0, retornará double.MinValue.*/

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
            :this(0)
        {
        
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        
        private double ValidarNumero(string strNumero)
        {
            double numValidado;

            if(!Double.TryParse(strNumero, out numValidado))
            {
                numValidado = 0;
            }

            return numValidado;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        public bool EsBinario(string binario)
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

        public string DecimalBinario(double numero)
        {
            string bin = "Valor invalido";
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

        public string DecimalBinario(string numero)
        {
            double numeroParseado;
            double.TryParse(numero, out numeroParseado);

            return DecimalBinario(numeroParseado);
        }

        public string BinarioDecimal(string numero)
        {
            string retorno = "Numero invalido";
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

        #region sobrecarga de operadores
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = Double.MinValue;

            if(n2.numero != 0)
            {
                retorno = n1 / n2;
            }

            return retorno;
        }
        #endregion
    }
}
