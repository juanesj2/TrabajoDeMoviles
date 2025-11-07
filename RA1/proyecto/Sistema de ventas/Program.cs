// Este es nuestro proyecto para la asignatura de moviles tema 1 una app de consola
// Es un mini sistema de gestion de ventas

// nuestro namespace
using TrabajoMoviles;
namespace TrabajoMoviles
{
	class Program
	{
		static void Main() {
			SistemaVentas sistema = new SistemaVentas();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ SISTEMA DE VENTAS ====");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Ver inventario");
                Console.WriteLine("3. Registrar venta");
                Console.WriteLine("4. Actualizar Stock");
                Console.WriteLine("5. Ver historial");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                // Leer la opción del usuario
                // convierte la entrada a entero que es lo que usamos en el switch
                // Si la conversión falla, se asigna -1 para indicar una opción inválida
                if (int.TryParse(Console.ReadLine(), out opcion) == false)
                {
                    opcion = -1; // Opción inválida
                }


                switch (opcion)
                {
                    case 1: sistema.AgregarProducto(); break;
                    case 2: sistema.VerInventario(); break;
                    case 3: sistema.RegistrarVenta(); break;
                    case 4: sistema.UsaactualizarStock(); break;
                    case 5: sistema.MostrarVentas(); break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

                Console.WriteLine("\nPresiona ENTER para continuar...");
                Console.ReadLine();
            }
        }
	}
}
