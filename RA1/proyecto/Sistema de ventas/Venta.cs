using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas
{
    public class Venta
    {
        // ID de la venta realizada
        public int Id { get; set; }

        // Precio total de la venta
        public decimal Total { get; private set; }

        // Relacion con Producto
        public Producto ProductoVendido { get; set; }

        // Cantidad vendida
        public int Cantidad { get; set; }

        // Precio total de la venta
        public void CalcularTotal()
        {
            Total = Cantidad * ProductoVendido.Precio;
        }

        // Metodo para mostrar la venta
        public void MostrarVenta()
        {
            Console.WriteLine($"ID: {Id} | Producto: {ProductoVendido.Nombre} | Cantidad: {Cantidad} | Total: {Total}");
        }
    }
}
