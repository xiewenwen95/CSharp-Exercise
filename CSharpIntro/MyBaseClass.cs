using System;
namespace CSharpIntro
{
	public class MyBaseClass
	{
		protected string mystring;

		public string ContianedString { get; set; }
		protected MyBaseClass()
		{
		}
		public MyBaseClass(string value)
		{
			mystring = value;
		}
	
		public virtual string GetString()
		{
			return mystring;
		}

	}
}

