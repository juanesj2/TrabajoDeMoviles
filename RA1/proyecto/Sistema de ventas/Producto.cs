// Producto.cs
// Define la clase Producto que modela un producto con código, nombre, precio y cantidad
// y que permite actualizar el stock y mostrar su información
//

// Define un espacio de nombres llamado TrabajoDeMoviles.
namespace TrabajoMoviles
{
	// Clase que representa un producto con atributos y métodos para gestión de inventario.
	public class Producto
	{
		// Variable incremental para la id de los productos
		private static int numCodigo = 0;
		// Código único del producto, solo lectura e inmutable tras la creación
		private string codigo { get; }
		// Nombre del producto.
		private string nombre { get; set; }
		// Precio del producto.
		private double precio { get; set; }
		// Cantidad disponible en inventario.
		private int cantidad { get; set; }

		//Método getter para nombre
		public string getNombre() {
			return this.nombre;
		}
		//Método setter para nombre
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
		//Método getter para código
		public string getCodigo() {
			return this.codigo;
		}
		//Método getter para precio
		public double getPrecio() {
			return this.precio;
		}
		//Método setter para precio
		public void setPrecio(double precio) {
			this.precio = precio;
		}
		//Método getter para cantidad
		public int getCantidad() {
			return this.cantidad;
		}
		//Método setter para cantidad
		public void setCantidad(int cantidad) {
			this.cantidad = cantidad;
		}

		//Método constructor para asignar valores al crear un producto
		public Producto(string nombre, double precio, int cantidad) {
			//Incrementamos la variable de id
			numCodigo++;
			//Asignamos por defecto un código único al producto
			this.codigo = $"PRD-{numCodigo:0000}";
			//Asignamos nombre al producto
			this.nombre = nombre;
			//Asignamos precio al producto
			this.precio = precio;
			//Asignamos la cantidad de productos que tenemos
			this.cantidad = cantidad;
		}

		//Método para mostrar la información de un producto
		public void mostrarInfo() {
			//Muestra por consola todos los campos del producto
			Console.WriteLine("Información del producto: " + this.codigo +
							  "\nNombre: " + this.nombre +
							  "\nPrecio: " + this.precio + "€" +
							  "\nCantidad en stock: " + this.cantidad);
		}

		//Método para actualizar el stock de productos
		public void actualizarStock() {
			//Hacemos una pregunta por consola
			Console.WriteLine("¿Quieres retirar o añadir productos? (R/A)");
			//Recogemos la respuesta
			string rpta = Console.ReadLine();

			//Dependiendo la respuesta:
			//Si el usuario quiere eliminar stock
			if (rpta.Equals("R", StringComparison.OrdinalIgnoreCase)) {
				//Preguntamos al usuario cuanto stock desea retirar
				Console.WriteLine("¿Dime la cantidad de productos que deseas eliminar");
				//Recogemos el valor en una variable
				int rest;
				if (int.TryParse(Console.ReadLine(), out rest)) {
					//Comprobamos que no quede una cantidad negativa de stock
					if (this.cantidad - rest < 0) {
						//Mensaje de error
						Console.WriteLine("No podemos borrar más productos de los que hay");
					}
					else {
						//Actualizamos el stock
						this.cantidad -= rest;
						Console.WriteLine("Stock actualizado");
					}
				}
				else {
					Console.WriteLine("Cantidad inválida");
				}
				//Si el usuario quiere aumentar el stock
			}
			else if (rpta.Equals("A", StringComparison.OrdinalIgnoreCase)) {
				//Preguntamos al usuario cuanto stock desea añadir
				Console.WriteLine("¿Dime la cantidad de productos que deseas añadir");
				//Recogemos el valor en una variable
				int aument;
				if (int.TryParse(Console.ReadLine(), out aument)) {
					this.cantidad += aument;
					Console.WriteLine("Stock actualizado");
				}
				else {
					Console.WriteLine("Cantidad inválida");
				}
				//El usuario ha introducido una respuesta incorrecta
			}
			else {
				Console.WriteLine("Has introducido una respuesta incorrecta");
			}
		}

		/*
        Método para verificar stock disponible
        Un método que devuelva true/false si hay suficiente stock para una determinada cantidad, 
        para usarlo en la gestión de ventas.
        */
		public Boolean disponibilidad() {
			//Devuelve true si hay al menos un producto en stock, false si no
			return this.cantidad > 0;
		}

		//Método para incrementar o decrementar stock. Puede recibir números negativos para decrementar.
		public void modStock(int n) {
			//Verifica que no se guarda un stock negativo tras la actualización
			if (this.cantidad + n < 0) {
				Console.WriteLine("No se puede guardar un stock negativo");
			}
			else {
				this.cantidad += n;
			}
		}
	}
}