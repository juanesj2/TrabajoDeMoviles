namespace TrabajoDeMoviles
{
	class Producto
	{
		private static int numCodigo = 0;
		private string codigo { get ;};
		private string nombre { get; set; }
		private double precio { get; set; }
		private int cantidad { get; set; }

		public Producto(string nombre, double precio, int cantidad)
		{
			numCodigo++;
			this.codigo = $"PRD-{numCodigo:0000}";
			this.nombre = nombre;
			this.precio = precio;
			this.cantidad = cantidad;
		}

		public void mostrarInfo()
		{
			Console.WriteLine("Información del producto: " + this.codigo +
							  "\nNombre: " + this.nombre +
							  "\nPrecio: " + this.precio + "€" +
							  "\nCantidad en stock: " + this.cantidad);
		}

		public void actualizarStock(){
			Console.WriteLine("¿Quieres retirar o añadir productos? (R/A)");
			string rpta = Console.ReadLine();

			if (rpta.Equals("R", StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine("¿Dime la cantidad de productos que deseas eliminar");
				int rest;
				if (int.TryParse(Console.ReadLine(), out rest)){
					if (this.cantidad - rest < 0){
						Console.WriteLine("No podemos borrar mas productos de los que hay");
					}else{
						this.cantidad -= rest;
						Console.WriteLine("Stock actualizado");
					}
				}else{
					Console.WriteLine("Cantidad inválida");
				}
			}else if (rpta.Equals("A", StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine("¿Dime la cantidad de productos que deseas añadir");
				int aument;
				if (int.TryParse(Console.ReadLine(), out aument)){
					this.cantidad += aument;
					Console.WriteLine("Stock actualizado");
				}else{
					Console.WriteLine("Cantidad inválida");
				}
			}else{
				Console.WriteLine("Has introducido una respuesta incorrecta");
			}
		}

		/*
		Método para verificar stock disponible
		Un método que devuelva true/false si hay suficiente stock para una determinada cantidad, 
		para usarlo en la gestión de ventas.*/
		public Boolean disponibilidad(){
			if (this.cantidad > 0){
				return true;
			}else{
				return false;
			}
		}

		//Método para incrementar o decrementar stock. Puede recibir numeros negativos para decrementar.
		public void modStock(int n){
			if (this.cantidad += n < 0){
				Console.WriteLine("No se puuede guardar un stock negativo");
			}else{
				this.cantidad += n;
			}
				
		}


	}
}
