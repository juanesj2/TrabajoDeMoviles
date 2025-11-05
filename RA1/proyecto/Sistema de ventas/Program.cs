// Este es nuestro proyecto para la asignatura de moviles tema 1 una app de consola
// Es un mini sistema de gestion de ventas

// nuestro namespace
using Sistema_de_ventas;

public class Program
{
    static void Main()
    {
        // Producto de prueba
        Producto productoDemo = new("Coca Cola", 1.50, 100);

        // Crear la venta con el producto asignado
        var ventaEjemplo = new Venta
        {
            Id = 1,
            Cantidad = 5,
            ProductoVendido = productoDemo
        };

        ventaEjemplo.CalcularTotal();
        ventaEjemplo.MostrarVenta();

        Console.WriteLine("\n=== PRUEBA 5: Comprobar disponibilidad ===");
        Console.WriteLine(productoDemo.disponibilidad()
            ? "El producto tiene stock disponible ✅"
            : "El producto NO tiene stock ❌"
        );

        Console.WriteLine("\n=== PRUEBA 6: actualizarStock ===");
        productoDemo.actualizarStock();
        productoDemo.mostrarInfo();

    }
}
