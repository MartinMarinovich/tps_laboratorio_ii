using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;

        /// <summary>
        /// Constructor que instancia el atributo tipo por defecto en cuatro puertas, utiliza la sobrecarga del constructor con para los demas atributos
        // por defecto el valor es cuatro puertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color,ETipo.CuatroPuertas)
        {
            tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor de la clase Sedan, hereda los atributos de la clase padre Vehiculo, el atributo tipo es propio de la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Atributo del tipo enumerador protegido de solo lectura, retorna el tamanio Mediano por defecto
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Metodo que  obtiene los valores construidos de la clase Sedan y los devuelve como string
        /// </summary>
        /// <returns>Datos del Sedan como string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
