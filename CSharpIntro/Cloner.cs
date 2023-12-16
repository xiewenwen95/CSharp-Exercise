using System;
namespace CSharpIntro
{
	/*public class Cloner
	{
		public int val;

		public Cloner(int newVal)
		{
			val = newVal;
		}
		public object GetCopy()
		{
			return MemberwiseClone();
		}
	}*/

	public class Cloner:ICloneable
	{
		public Content MyContent = new Content();
		public Cloner(int val)
		{
			MyContent.Val = val;
		}
		public object Clone()
		{
			Cloner clonedCloner = new Cloner(MyContent.Val);
			return clonedCloner;
		}
	}
}

