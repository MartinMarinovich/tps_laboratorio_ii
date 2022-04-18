using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo estatico operarar recibe dos objetos de tipo operando que repesentan los operandos y un char que es el operador
        /// devuelve un double que es el resultado y sino un 0 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double result = double.MinValue;

            if (num1 != null && num2 != null)
            {
                switch (ValidarOperador(operador))
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                       result =  num1 - num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// Validar operando metodo estatico de la clase estatica que devuelve el string del operador que se va a utilizar
        /// //valida que el que se eligio sea uno de los disponibles y sino devuelve un +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if (!char.IsWhiteSpace(operador) && !char.IsDigit(operador) && (operador == '-' ||
                operador == '+' || operador == '*' || operador == '/'))
            {
                return operador;
            }

            operador = '+';

            return operador;
        }
    }
}

