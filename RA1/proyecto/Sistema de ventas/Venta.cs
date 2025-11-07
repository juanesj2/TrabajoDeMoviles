using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoMoviles;

namespace TrabajoMoviles
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
            // Comprobar que hay producto asignado
            if (ProductoVendido == null)
            {
                Console.WriteLine("Error: No hay producto asignado a la venta.");
                Total = 0;
                return;
            }

            // Comprobar que la cantidad es positiva
            if (Cantidad <= 0)
            {
                Console.WriteLine("Error: La cantidad vendida debe ser mayor que cero.");
                Total = 0;
                return;
            }

            // Comprobar que hay suficiente stock
            if (ProductoVendido.getCantidad() < Cantidad)
            {
                Console.WriteLine("Error: No hay suficiente stock para completar la venta.");
                Total = 0;
                return;
            }

            // Calcular el total
            Total = Cantidad * (decimal)ProductoVendido.getPrecio();
        }

        // Metodo para mostrar la venta
        public void MostrarVenta()
        {
            Console.WriteLine($"ID: {Id} | Producto: {ProductoVendido?.getNombre() ?? "N/A"} | Cantidad: {Cantidad} | Total: {Total}");
        }
    }
}