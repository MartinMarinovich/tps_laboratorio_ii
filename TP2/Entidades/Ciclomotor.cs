using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor de la clase ciclomotor, hereda los atributos de la clase padre vehiculo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {

        }


        /// <summary>
        ///  Propiedad que devuelve el valor del dle atributo tamanio seteado por defecto en Chico
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// Metodo que  obtiene los valores construidos de la clase Ciclomotor y los devuelve como string
        /// </summary>
        /// <returns>Datos del Climotor como string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
