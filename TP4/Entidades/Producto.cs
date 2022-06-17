using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int codigoProducto;
        string descripcion;

        public Producto(int codigoProducto, string descripcion)
        {
            this.CodigoProducto = codigoProducto;
            this.Descripcion = descripcion;
        }

        public int CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
