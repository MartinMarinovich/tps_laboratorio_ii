using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Membresia
    {
        Premium = 70,
        Regular = 30,
        SinMembresia

    }
    public class Cliente : Persona
    {
        List<Compra> compras;
        Membresia membresia;
        double dinero;


        public Cliente(string nombre, string apellido, double dni,List<Compra> compras, Membresia membresia, double dinero): base(nombre,apellido,dni)
        {
            this.compras = compras;
            this.membresia = membresia;
            this.dinero = dinero;
        }


        public List<Compra> Compras { get => compras; set => compras = value; }
        public Membresia Membresia { get => membresia; set => membresia = value; }
        public double Dinero { get => dinero; set => dinero = value; }
    }
}
