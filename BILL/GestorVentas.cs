using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    public class GestorVentas
    {
        public List<Producto> Productos { get; set; }
        public List<Factura> Facturas { get; set; }

        public GestorVentas()
        {
            Productos = new List<Producto>();
            Facturas = new List<Factura>();
        }

        //   agregar un producto
        public void AgregarProducto(Producto producto)
        {
            if (Productos.Any(p => p.Referencia == producto.Referencia))
            {
                Console.WriteLine("Ya existe un producto con la misma referencia.");
            }
            else if (producto.ValidarDatos())
            {
                Productos.Add(producto);
            }
        }

        //   agregar una factura
        public void AgregarFactura(Factura factura)
        {
            if (Facturas.Any(f => f.NumeroFactura == factura.NumeroFactura))
            {
                Console.WriteLine("Ya existe una factura con el mismo número.");
            }
            else
            {
                Facturas.Add(factura);
            }
        }

        //  obtener todas las facturas
        public List<Factura> ObtenerFacturas()
        {
            return Facturas;
        }
    }
}
