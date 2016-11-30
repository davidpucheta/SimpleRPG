using System;
namespace SimpleRPG
{
	public class Personaje
	{
		public string nombre { get; set; }

		public void atacar(int arma)
		{
			Console.WriteLine( nombre +  " " + usar(arma));
		}


		public string usar(int item)
		{
			string itemUsado = "";
			switch (item)
			{
				case 1:
					itemUsado = "ha partido en dos al enemigo";
					break;
				case 2:
					itemUsado = "ha acertado en el corazón del enemigo";
					break;
				case 3:
					itemUsado = "ha convertido en mono al enemigo";
					break;
				default:
					Console.WriteLine("Game Over");
					break;
			}
			return itemUsado;
		}
	}
}
