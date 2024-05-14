using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public string NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<ItemVenta> ItemsVenta { get; set; }

        public Factura()
        {
            ItemsVenta = new List<ItemVenta>();
        }

        //   agregar un producto a la factura
        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.Existencias >= cantidad)
            {
                ItemsVenta.Add(new ItemVenta { Producto = producto, Cantidad = cantidad });
                producto.Existencias -= cantidad;
            }
            else
            {
                Console.WriteLine($"No hay suficientes existencias del producto {producto.Nombre}. Solo quedan {producto.Existencias}.");
            }
        }

        //   calcular el total de la factura
        public double CalcularTotal()
        {
            return ItemsVenta.Sum(item => item.ValorItemVendido());
        }
    }

    public class ItemVenta
    {
        public Producto Producto { get; internal set; }
        public int Cantidad { get; internal set; }

        internal int ValorItemVendido()
        {
            throw new NotImplementedException();
        }
    }
}
