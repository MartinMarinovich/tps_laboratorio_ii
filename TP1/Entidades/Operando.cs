using System;

namespace Entidades
{
    public class Operando
    {
        double numero;

        /// <summary>
        /// Constructor sin parametros asigna el 0 al campo numero
        /// </summary>
        public Operando(): this(0)
        {
          
        }
        /// <summary>
        /// Constructor double de operando
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
       /// <summary>
       /// Constructor string que utiliza la propiedad Numero
       /// </summary>
       /// <param name="sNumero"></param>
        public Operando(string sNumero)
        {
            this.Numero = sNumero;
        }

        /// <summary>
        /// Propiedad set de tipo string del atributo numero
        /// </summary>
        public string Numero
        {

            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Metodo validador del operando por parametro, que no sea vacio o no sea un numero
        /// </summary>
        /// <param name="sNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string sNumero)
        {
            double result = 0;

            if (!string.IsNullOrWhiteSpace(sNumero))
            {
                double.TryParse(sNumero, out result);
            }

            return result;
        }



        /// <summary>
        /// Metodo verificador de numero binario, recorre el string corroborando que sean 0 y 1
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <returns></returns>
        private bool EsBinario(string numeroBinario)
        {

            foreach (char item in numeroBinario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Metodo conversor binario  a decimal asigna el valor del numero conertido a string, utiliza el metodo es binario para verificar que sea un string de numero binario
        /// utilizar
        /// </summary>
        /// <returns></returns>

        public string BinarioADecimal(string binario)
        {
            double resultado = 0;     
            
            if (EsBinario(binario))
            {
                char[] numeroBinario = binario.ToCharArray();


                for (int i = 0; i < numeroBinario.Length; i++)
                {
                    if (numeroBinario[i] == '1')
                    {
                        resultado +=  (int) Math.Pow(2, i);
                    }
                }

                return resultado.ToString();
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Metodo el cual asigna el valor del numero ,verificar que no sea 0  y asigna al auxiliar el numero casteado a string
        /// realiza la division por 2 y dependiendo el resto asigna 0 o 1 y va componiendo el numero para luego devolverlo como string
        ///
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>


        public string DecimalBinario(double numeroDecimal)
        {
            int auxiliar = 0;
            string result = string.Empty;

            if (!double.IsNaN(numeroDecimal))
            {
                auxiliar = (int)numeroDecimal;

                do
                {
                    if (auxiliar % 2 == 0)
                    {
                        result += '0';
                    }
                    else
                    {
                        result += '1';

                    }
                    auxiliar = auxiliar / 2;

                } while (auxiliar >= 1);

                return result;
            }

            return "Valor invalido";
        }
        /// <summary>
        /// Metodo el cual asigna el valor del numero ,verificar que no sea 0  y asigna al auxiliar el numero casteado a string
        /// realiza la division por 2 y dependiendo el resto asigna 0 o 1 y va componiendo el numero para luego devolverlo como string
        ///
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>

        public string DecimalBinario(string sDecimal)
        {
            double auxiliar = 0;

            if (!string.IsNullOrWhiteSpace(sDecimal) && double.TryParse(sDecimal ,out auxiliar))
            {
                return DecimalBinario(auxiliar);
            }

            return "Valor invalido";
        }



        /// <summary>
        /// Sobrecarga del operador + suma dos objetos de tio operando
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        /// 

        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador - resta dos objetos de tipo operando
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        /// 

        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *, multiplica dos objetos de tipo operando
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        /// 
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / realiza una division entre dos objetos de tipo operador
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        public static double operator /(Operando num1, Operando num2)
        {

            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
        }
    }
}
