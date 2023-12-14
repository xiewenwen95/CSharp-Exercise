using System;
namespace CSharpIntro
{
    public class MyDerivedClass : MyBaseClass
	{
		
		public MyDerivedClass(string value):base(value)
		{

		}
		public MyDerivedClass()
		{
		}
		public override string GetString()
		{
			return base.GetString() + " (output from derived class)";
		}

	}
}

