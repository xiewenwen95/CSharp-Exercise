using System;
using System.Collections;

namespace CSharpIntro
{
	public class PersonComparerName:IComparer
	{
		public static IComparer Default = new PersonComparerName();
		public int Compare(object x,object y)
		{
			if(x is Person && y is Person)
			{
				return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
			}
			else
			{
				throw new ArgumentException("one or both objects to compare are not Person objects.");
			}
		}

		public PersonComparerName()
		{
		}
	}
}

