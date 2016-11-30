using System;

namespace SimpleRPG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int seleccion = 0;

			do
			{
				seleccion = PintarMenuPersonaje();

			} while (seleccion != 0);
		}

		public static int PintarMenuPersonaje()
		{
			Console.WriteLine("Selecciona un Personaje:");
			Console.WriteLine();
			Console.WriteLine("1. Paladín");
			Console.WriteLine("2. Elfo");
			Console.WriteLine("3. Mago");
			Console.WriteLine("0. Salir del Programa");

			var result = Console.ReadLine();
			return Convert.ToInt32(result);
		}

	}
}
