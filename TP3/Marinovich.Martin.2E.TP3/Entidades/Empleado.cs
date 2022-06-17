using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Empleado : Persona
    {
        int sucursal;
        public Empleado(string nombre, string apellido,double dni, int sucursal): base(nombre,apellido,dni)
        {
            this.sucursal = sucursal;
        }
        public int Sucursal { get => sucursal; set => sucursal = value; }
    }
}
