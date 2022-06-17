using System;
using System.Collections.Generic;

namespace Entidades
{
    public  class Comercio : IValidadora
    {
         string nombre;
         string direccion;
         List<Empleado> empleados;
         Stack<Compra> reclamos;
         Queue<Cliente> clientes;

        public Comercio(string nombre, string direccion, List<Empleado> empleados, Stack<Compra> reclamos, Queue<Cliente> clientes)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.empleados = empleados;
            this.reclamos = reclamos;
            this.clientes = clientes;

        }

        public  string Nombre { get => nombre; set => nombre = value; }
        public  string Direccion { get => direccion; set => direccion = value; }
        List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public Stack<Compra> Reclamos { get => reclamos; set => reclamos = value; }
        public Queue<Cliente> Clientes { get => clientes; set => clientes = value; }


        public bool ValidarDni()
        {
            return true;
        }
        public static bool IngresarEmpleado(string nombre, string apellido, double dni, int sucursal)
        {
           
            
            return true;
        }
    }
}
