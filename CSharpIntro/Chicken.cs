using System;
namespace CSharpIntro
{
	public class Chicken: Animal
	{
		public void LayEgg()
		{
			Console.WriteLine("{0} has laid an egg.", name);
		}
		public Chicken(string newName):base(newName)
		{
		}
	}
}

