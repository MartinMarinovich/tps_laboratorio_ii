using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Empleado : Persona
    {
        string sucursal;
        public Empleado(string nombre, string apellido,double dni, string sucursal): base(nombre,apellido,dni)
        {
            this.sucursal = sucursal;
        }
        public string Sucursal { get => sucursal; set => sucursal = value; }
    }
}
