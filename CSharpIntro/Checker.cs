using System;
namespace CSharpIntro
{
	public class Checker
	{
		public void Check(object param1)
		{
			if(param1 is ClassA)
			{
				Console.WriteLine("Variable can be converted to Class A");
			}
			else
			{
				Console.WriteLine("Variable can't be converted to Class A");
			}
            if (param1 is IMyInterface)
            {
                Console.WriteLine("Variable can be converted to IMyInterface");
            }
            else
            {
                Console.WriteLine("Variable can't be converted to IMyInterface");
            }
            if (param1 is MyStruct)
            {
                Console.WriteLine("Variable can be converted to MyStruct");
            }
            else
            {
                Console.WriteLine("Variable can't be converted to MyStruct");
            }
        }
	}

    interface IMyInterface { }
    class ClassA : IMyInterface { }
    class ClassB: IMyInterface { }
    class ClassC { }
    class ClassD : ClassA { }
    struct MyStruct : IMyInterface { }
}

