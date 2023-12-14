using System;
namespace CSharpIntro
{
	public class MyCopyableClass
	{
		private int myInt;
		public int MyInt { get { return myInt; } set { myInt = value; } }
		public MyCopyableClass()
		{
			
		}

		public MyCopyableClass GetCopy()
		{
			return (MyCopyableClass)base.MemberwiseClone();
		}
	}
}

