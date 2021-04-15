using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*• El método ValidarOperador será privado y estático. Deberá validar que el operador
recibido sea +, -, / o *. Caso contrario retornará +.
  • El método Operar será de clase: validará y realizará la operación pedida entre
ambos números.*/

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            char operadorParseado = '+';//si el TryParse no funciona la operacion sera de suma
            double resultado = 0;

            if( Char.TryParse(operador,out operadorParseado) )
            {
                switch(ValidarOperador(operadorParseado))
                {
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    default:
                        resultado = num1 + num2;
                        break;
                }
            }

            return resultado;
        }

        private static string ValidarOperador(char operador)
        {
            string ret;

            switch(operador)
            {
                case '-':
                    ret = "-";
                    break;
                case '/':
                    ret = "/";
                    break;
                case '*':
                    ret = "*";
                    break;
                default:
                    ret = "+";
                    break;
            }

            return ret;
        }
    }
}
