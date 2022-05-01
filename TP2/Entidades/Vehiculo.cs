using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Constructor de la clase Vehiculo de las que heredan las demas clases, setea los atributos  chasis, enumerador marca y el color
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        /// <summary>
        /// Enumerador de marcas que poseen los vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerador de los tamanios que pueden tener los vehiculos
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        EMarca marca;
        string chasis;
        ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        ///  Realiza la conversion explicita del objeto de tipo vehiculo y retorna sus datos en forma de string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            if (!(p is null))
            {
                sb.AppendLine($"{p.GetType().Name.ToUpper()}");
                sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
                sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
                sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
                sb.AppendLine("---------------------");
                sb.AppendFormat("TAMAÑO: {0}", p.Tamanio);

            }
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.chasis.ToString() == v2.chasis.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis != v2.chasis);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
