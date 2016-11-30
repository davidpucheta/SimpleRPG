using System;
namespace SimpleRPG
{
	public class Paladin : IPersonaje
	{
		public string arma = Items.Hechizo.ToString();

		public void atacar()
		{
			Console.Out.WriteLine("Paladín ataca con: ");
		}

		public void item()
		{
			throw new NotImplementedException();
		}

		public void usar()
		{
			throw new NotImplementedException();
		}
	}
}
