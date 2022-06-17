using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public abstract class Persona
    {

        string nombre;
        string apellido;
        double dni;

        protected Persona(string nombre, string apellido, double dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double DNI { get => dni; set => dni = value; }

   
    }
}
