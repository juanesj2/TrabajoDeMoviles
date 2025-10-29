// Este es nuestro proyecto para la asignatura de moviles tema 1 una app de consola
// Es un mini sistema de gestion de ventas

// ******************* Juan ************************* //
public class Venta
{
    // ID de la venta realizada
    public int Id { get; set; }

    // Relacion con Producto
    // public Producto ProductoVendido { get; set; }

    // Cantidad vendida
    public int Cantidad { get; set; }

    // Precio total de la venta
    //public decimal Total => Cantidad * ProductoVendido.Precio;
}

public class Program
{
    static void Main()
    {
        var ventaEjemplo = new Venta { Id = 1, Cantidad = 5 };
        mostrarVenta(ventaEjemplo);
    }

    // Método para mostrar una venta mediante su nombre

    static void mostrarVenta(Venta venta)
    {
        Console.WriteLine($"ID Venta: {venta.Id}, Cantidad: {venta.Cantidad}");
    }
}

// ***************** FIN Juan *********************** //
