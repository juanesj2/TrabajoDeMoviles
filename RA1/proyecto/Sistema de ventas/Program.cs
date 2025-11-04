// Este es nuestro proyecto para la asignatura de moviles tema 1 una app de consola
// Es un mini sistema de gestion de ventas

// nuestro namespace
using Sistema_de_ventas;

// ******************* Juan ************************* //
public class Program
{
    static void Main()
    {
        // Producto de prueba
        Producto productoDemo = new Producto
        {
            Codigo = 101,
            Nombre = "Coca Cola",
            Precio = 1.50m
        };

        // Crear la venta con el producto asignado
        var ventaEjemplo = new Venta
        {
            Id = 1,
            Cantidad = 5,
            ProductoVendido = productoDemo
        };

        ventaEjemplo.CalcularTotal();
        ventaEjemplo.MostrarVenta();
    }
}

// ***************** FIN Juan *********************** //
