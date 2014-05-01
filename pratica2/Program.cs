
using System;

namespace pratica2
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Precio del primer producto");
			double product1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del segundo producto");
			double product2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Precio del tercer producto");
			double product3 = double.Parse(Console.ReadLine());
		
		
			double producto1 = product1 * .16 + product1;
			
			double producto2 = product2 * .16 + product2;
			
			double producto3 = product3 * .16 + product3;
			
			
			
			Console.WriteLine("Precio del primero producto con IVA = " + producto1);
			Console.WriteLine("Precio del segundo producto con IVA = " + producto2);
			Console.WriteLine("Precio del tercer producto con IVA = " + producto3);		
			
			double total = producto1 + producto2 + producto3; 
			
			Console.WriteLine("El total de sus producto con IVA importado es: " + total );
			
			
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}