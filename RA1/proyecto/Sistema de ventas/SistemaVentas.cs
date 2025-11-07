using System;
using System.Collections.Generic;

namespace TrabajoMoviles
{
	public class SistemaVentas
	{
        // Listas para almacenar productos y ventas 
		// Mas adelante sera una base de datos
        private List<Producto> productos = new List<Producto>();
		private List<Venta> ventas = new List<Venta>();

        // Metodo para agregar un producto al inventario
        public void AgregarProducto() {
			Console.Write("Nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Precio: ");
			double precio = double.Parse(Console.ReadLine());
			Console.Write("Cantidad: ");
			int cantidad = int.Parse(Console.ReadLine());

            // Crear y agregar el producto a la lista
            Producto p = new Producto(nombre, precio, cantidad);
			productos.Add(p);
			Console.WriteLine("Producto agregado correctamente.");
		}

        // Metodo para ver el inventario de productos
        public void VerInventario() {
			Console.WriteLine("\n--- INVENTARIO ---");
            // Comprobar si hay productos
            if (productos.Count == 0) {
				Console.WriteLine("No hay productos registrados.");
				return;
			}
            // Si hay productos, los mostramos
            foreach (var p in productos)
				p.mostrarInfo();
		}

        // Metodo para registrar una venta
        public void RegistrarVenta()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
                return;
            }

            // Mostrar productos disponibles
            Console.WriteLine("\n--- Productos disponibles ---");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{i}. {productos[i].getNombre()} (Stock: {productos[i].getCantidad()})");
            }

            // Seleccionar producto
            Console.Write("\nSelecciona el número del producto: ");
            // guardamos en index la opcion del usuario
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad a comprar: ");
            int cantidadVenta = Convert.ToInt32(Console.ReadLine());

            // Preparamos el producto seleccionado
            Producto seleccionado = productos[index];

            // Verificamos stock
            if (seleccionado.getCantidad() < cantidadVenta)
            {
                Console.WriteLine("No hay suficiente stock.");
                return;
            }

            // Usamos la calse venta para registrar la venta
            Venta venta = new Venta
            {
                Id = ventas.Count + 1,
                Cantidad = cantidadVenta,
                ProductoVendido = seleccionado
            };

            // Calculamos el total de la venta y la añadimos a la lista de ventas
            venta.CalcularTotal();
            ventas.Add(venta);

            // Actualizamos el stock del producto vendido
            seleccionado.modStock(-cantidadVenta);

            Console.WriteLine("Venta registrada:");
            venta.MostrarVenta();
        }

        // Metodo para ver el historial de ventas
        public void VerHistorialVentas() {
			Console.WriteLine("\n--- HISTORIAL DE VENTAS ---");
            // Comprobamos si hay ventas registradas
            if (ventas.Count == 0) {
				Console.WriteLine("No hay ventas registradas.");
				return;
			}

            // Si hay ventas, las mostramos
            foreach (var v in ventas)
				v.MostrarVenta();
		}

        // Metodo para modificar el stock de un producto

        public void UsaactualizarStock()
        {
            // Verificamos si hay productos registrados
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
                return;
            }

            // Mostrar productos disponibles
            Console.WriteLine("\n--- Productos disponibles ---");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{i}. {productos[i].getNombre()} (Stock: {productos[i].getCantidad()})");
            }

            // Seleccionar producto
            Console.Write("\nSelecciona el número del producto a actualizar: ");
            string input = Console.ReadLine();

            // Comprobar que la entrada es válida
            // Primero intentamos convertir la entrada a entero y luego comprobamos que está dentro del rango válido
            if (!int.TryParse(input, out int index) || index < 0 || index >= productos.Count)
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            Producto seleccionado = productos[index];

            // Llamada al método de la clase Producto para que gestione la actualización de stock.
            seleccionado.actualizarStock();

            Console.WriteLine("Stock actualizado:");
            seleccionado.mostrarInfo();
        }

        // Método para mostrar las ventas registradas
        public void MostrarVentas()
        {
            if (ventas.Count == 0)
            {
                Console.WriteLine("No hay ventas.");
                return;
            }

            ventas.ForEach(v => v.MostrarVenta());
        }
    }
}