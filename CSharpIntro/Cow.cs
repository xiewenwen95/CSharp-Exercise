﻿using System;
namespace CSharpIntro
{
	public class Cow:Animal
	{
		public void Milk()
		{
			Console.WriteLine("{0} has been milked.", name);
		}
		public Cow(string newName): base(newName)
		{
		}
	}
}

