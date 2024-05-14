using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public int Existencias { get; set; }
        public int StockMinimo { get; set; }
        public double PrecioUnitario { get; set; }
        public string Estado { get; set; }

        // Método para validar los datos del producto
        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(Referencia) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Estado))
            {
                Console.WriteLine("Los campos no pueden estar vacíos.");
                return false;
            }

            if (Existencias < 0 || PrecioUnitario < 0)
            {
                Console.WriteLine("Las existencias y el precio unitario deben ser números positivos.");
                return false;
            }

            if (Estado != "activo" && Estado != "inactivo")
            {
                Console.WriteLine("El estado solo puede ser 'activo' o 'inactivo'.");
                return false;
            }

            return true;
        }
    }
}
