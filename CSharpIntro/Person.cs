using System;
namespace CSharpIntro
{
	public class Person:IComparable
	{
		private string name;
		private int age;

		public string Name { get { return name; }set { name = value; } }
		public int Age { get { return age; }set { age = value; } }

		public Person() { }
		public Person(string name,int age)
		{
			this.name = name;
			this.age = age;
		}
		public int CompareTo(Object obj)
		{
			if(obj is Person)
			{
				Person otherPerson = obj as Person;
				return this.Age - otherPerson.Age;

			}
			else
			{
				throw new ArgumentException("Object to compare to is not a Person object.");
			}
		}
		public static bool operator >(Person p1,Person p2)
		{
			return p1.Age > p2.Age;
		}
		public static bool operator <(Person p1, Person p2)
		{
			return p1.Age < p2.Age;
		}
		public static bool operator >=(Person P1, Person p2)
		{
			return !(P1.Age < p2.Age);
		}
		public static bool operator <=(Person p1,Person p2)
		{
			return !(p1.Age > p2.Age);
		}
	}
}

