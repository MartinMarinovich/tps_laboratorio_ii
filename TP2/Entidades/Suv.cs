using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor de la clase Suv utiliza el constructor de la clase padre vehiculo e instancia sus atributos 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {

        }
        /// <summary>
        /// Atributo del tipo enumerador protegido de solo lectura, retorna el tamanio Grande por defecto
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Metodo que  obtiene los valores construidos de la clase Suv y los devuelve como string
        /// </summary>
        /// <returns>Datos del Suv como string</returns>

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

           
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
