using System;
using System.Collections;

namespace CSharpIntro
{
	public class Animals:CollectionBase
	{
		public Animals()
		{
		}
		public Animal this[int animalIndex]
		{
			get {
				return (Animal)List[animalIndex];
			}
			set {
				List[animalIndex] = value;
			}
		}
		public void Add(Animal newAnimal)
		{
			List.Add(newAnimal);
		}
		public void Remove(Animal newAnimal)
		{
			List.Remove(newAnimal);
		}
	}
}

