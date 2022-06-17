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
        List<Producto> carrito;
        Membresia membresia;
        int idCliente;
        bool realizoReclamo;


        public Cliente(int idCliente,string nombre, string apellido, double dni,List<Producto> carrito, Membresia membresia, bool realizoReclamo) : base(nombre,apellido,dni)
        {
            this.idCliente = idCliente;
            this.carrito = carrito;
            this.membresia = membresia;
            this.carrito = carrito;
            this.realizoReclamo = realizoReclamo;

        }


        public List<Producto> Carrito { get => carrito; set => carrito = value; }
        public Membresia Membresia { get => membresia; set => membresia = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
