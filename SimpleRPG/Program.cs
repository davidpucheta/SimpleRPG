using System;

namespace SimpleRPG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int seleccion = 0;
			int arma = 0;

			do
			{
				seleccion = PintarMenuPersonaje();
				if (seleccion == 0) 
				{
					Console.WriteLine("Game Over");
					return;
				}

				arma = PintarMenuItems(); 

				switch (seleccion)
				{
					case 1:
						Personaje conan = new Personaje();
						conan.nombre = "Conan";
						conan.atacar(arma);
						break;
					case 2:
						Personaje legolas = new Personaje();
						legolas.nombre = "Légolas";
						legolas.atacar(arma);
						break;
					case 3:
						Personaje merlin = new Personaje();
						merlin.nombre = "Merlín";
						merlin.atacar(arma);
						break;
					default:
						Console.WriteLine("Game Over");
						break;
				}

			} while (seleccion > 0 && seleccion < 4);
		}

		public static int PintarMenuPersonaje()
		{
			Console.WriteLine("Selecciona un Personaje:");
			Console.WriteLine();
			Console.WriteLine("1. Paladín");
			Console.WriteLine("2. Elfo");
			Console.WriteLine("3. Mago");

			Console.WriteLine("Selecciona cualquier otra número para salir");
			Console.WriteLine();


			var personaje = Console.ReadLine();
			return Convert.ToInt32(personaje);
		}

		public static int PintarMenuItems()
		{
			Console.WriteLine("Selecciona un Arma:");
			Console.WriteLine();
			Console.WriteLine("1. Espada");
			Console.WriteLine("2. Arco");
			Console.WriteLine("3. Hechizo");

			Console.WriteLine("Cualquier otra número para salir");
			Console.WriteLine();


			var arma = Console.ReadLine();
			return Convert.ToInt32(arma);
			
		}

	}
}
