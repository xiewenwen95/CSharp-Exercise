//using System.Diagnostics;


//use enum

//enum Name { xww,zzk,ylc}
using System.Collections;

enum orientation : byte
{
    north = 1,
    south = 2,
    east = 3,
    west = 4
}


//use struct

struct route
{
    public orientation direction;
    public double distance;
}

struct customerName
{
    public string firstName, lastName;
    public void print()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}


//use delegate
/*delegate string inputDelegate();
class Program
{
    public static void Main(string[] args)
    {
        //       Name name = Name.xww;
        //       Console.WriteLine(name);

        //       orientation myOrientation = orientation.east;
        //       Console.WriteLine(myOrientation);

        //       byte directionByte;
        //       string directionString;
        //       orientation o = orientation.north;
        //       directionByte = (byte)o;
        //       directionString = Convert.ToString(o);
        //       Console.WriteLine(directionByte);
        //       Console.WriteLine(directionString);



        //       route myRoute;
        //       int myDirection = -1;
        //       double myDistance;
        //       Console.WriteLine("1) North\n2) South\n3) East\n4) West");
        //       do
        //       {
        //           Console.WriteLine("select a direction:");
        //           myDirection = Convert.ToInt32(Console.ReadLine());

        //       }
        //       while (myDirection < 1 || myDirection > 4);
        //       Console.WriteLine("Input a distance:");
        //       myDistance = Convert.ToDouble(Console.ReadLine());
        //       myRoute.direction = (orientation)myOrientation;
        //       myRoute.distance = myDistance;
        //       Console.WriteLine("myRoute specifies a direction of {0} and a " +
        //"distance of {1}", myRoute.direction, myRoute.distance);
        //       Console.ReadKey();


        //       Console.WriteLine("{0} command line arguments were specified:",
        //args.Length);
        //       foreach(string arg in args)
        //       {
        //           Console.WriteLine(arg);
        //       }

        //       customerName myName;
        //       myName.lastName = "xie";
        //       myName.firstName = "wenwen";
        //       myName.print();

        //inputDelegate mydelegate = new inputDelegate(InputName);
        //Console.WriteLine(mydelegate());

        // //       int[] testArr = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
        // //       int[] maxValIndices;
        // //       int maxVal = Maxima(testArr, out maxValIndices);
        // //       Console.WriteLine("Maximum value {0} found at element indices:",
        // //maxVal);
        // //       foreach (int index in maxValIndices)
        // //       {
        // //           Console.WriteLine(index);
        // //       }
        // //       Console.ReadKey();

        // //   }
        // //   public static string InputName()
        // //   {
        // //       string input=Console.ReadLine();
        // //       return input;
        // //   }
        // //   public static int Maxima(int[] integers, out int[] indices)
        // //   {
        // //       Debug.WriteLine("Maximum value search statrted");
        // //       indices = new int[1];
        // //       int maxVal = integers[0];
        // //       indices[0] = 0;
        // //       int count = 1;
        // //       Debug.WriteLine(string.Format("Maximum value initialized to {0}, at element index 0.", maxVal));

        // //       for(int i=1;i<integers.Length;i++)
        // //       {
        // //           Debug.WriteLine(string.Format("now looking at at index {0}.", i));
        // //           if (integers[i]>maxVal)
        // //           {
        // //               maxVal = integers[i];
        // //               count = 1;
        // //               indices = new int[1];
        // //               indices[0] = i;
        // //               Debug.WriteLine(string.Format(
        // //               "New maximum found. New value is {0}, at element index {1}.",
        // //               maxVal, i));
        // //           }
        // //           else
        // //           {
        // //               if (integers[i]==maxVal)
        // //               {
        // //                   count++;
        // //                   int[] oldIndices = indices;
        // //                   indices = new int[count];
        // //                   oldIndices.CopyTo(indices, 0);
        // //                   indices[count - 1] = i;
        // //                   Debug.WriteLine(string.Format(
        // //"Duplicate maximum found at element index {0}.", i));
        // //               }
        // //           }
        // //       }

        // //       Trace.WriteLine(string.Format("maximum value {0} found, with {1} occurrences.", maxVal, count));
        // //       Debug.WriteLine("Maximum value search completed.");
        // //       return maxVal;



        //    }
        }
*/


namespace CSharpIntro {
    public enum Suit { club,diamond,spade,heart}
    public enum Rank {
        Ace = 1,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Deck myDeck = new Deck();
            //myDeck.Shuffle();
            //for (int i = 0; i < 52; i++)
            //{
            //    Card tempCard = myDeck.GetCard(i);
            //    Console.Write(tempCard.ToString());
            //    if (i != 51)
            //        Console.Write(", ");
            //    else
            //        Console.WriteLine();
            //}
            //Console.ReadKey();

            //MyBaseClass b = new MyBaseClass("xww");
            //Console.WriteLine(b.GetString());
            //Console.WriteLine("--------------");
            //MyDerivedClass d = new MyDerivedClass("xww");
            //Console.WriteLine(d.GetString());

            //MyCopyableClass c = new MyCopyableClass();
            //c.MyInt = 1;
            //MyCopyableClass c2 = c.GetCopy();
            //c.MyInt=2;
            //Console.WriteLine(c2.MyInt.ToString());
            //Console.WriteLine(c.MyInt.ToString());


            /* use collection

            Console.WriteLine("create an array type collection of animal " + "objects and use it: ");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Deride");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Ken");
            foreach(Animal myAnimal in animalArray)
            {
                Console.WriteLine("New {0} object added to array collection, " + "Name={1}", myAnimal.ToString(), myAnimal.Name);
            }
            Console.WriteLine("Array collection contains {0} objects.", animalArray.Length);
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Create an arrayList type collection of animal " + "object and use it: ");

            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Hayley");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Roy"));

            foreach(Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("New {0} object added to arraylist collection, " + "Name={1}", myAnimal.ToString(), myAnimal.Name);
            }

            Console.WriteLine("Arraylist collection contians {0} objects.", animalArrayList.Count);

            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Additional manipulate of arraylist: ");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);

            ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine("the aninal called {0} is at index {1}.", myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Janice";
            Console.WriteLine("the animal is now called {0}.", ((Animal)animalArrayList[1]).Name);
            Console.ReadKey();


            //define collection
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Jack"));
            animalCollection.Add(new Chicken("Vera"));

            foreach(Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();

            //enumerator and enumerable
            /*Primes primesFrom2To1000 = new Primes(2, 1000);
            foreach (long i in primesFrom2To1000)
                Console.Write("{0} ", i);
            Console.ReadKey();*/

            /* shallow copy
            Cloner mySource = new Cloner(5);
            Cloner myTarget = (Cloner)mySource.Clone();
            Console.WriteLine("myTarget.MyContent.Val = {0}", myTarget.MyContent.Val);
            mySource.MyContent.Val = 2;
            Console.WriteLine("myTarget.MyContent.Val = {0}", myTarget.MyContent.Val);

            //is modifier
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            MyStruct try5 = new MyStruct();
            object try6 = try5;
            Console.WriteLine("Analyzing ClassA type variable:");
            check.Check(try1);
            Console.WriteLine("Analyzing ClassB type variable:");
            check.Check(try2);
            Console.WriteLine("Analyzing ClassC type variable:");
            check.Check(try3);
            Console.WriteLine("Analyzing ClassD type variable:");
            check.Check(try4);
            Console.WriteLine("Analyzing mystruct type variable:");
            check.Check(try5);
            Console.WriteLine("Analyzing boxed mystruct type variable:");
            check.Check(try6);


            //IComparable, IComparer
            ArrayList list = new ArrayList();
            list.Add(new Person("Jim", 30));
            list.Add(new Person("Bob", 25));
            list.Add(new Person("Bert", 27));
            list.Add(new Person("Ernie", 22));

            Console.WriteLine("Unsorted people: ");
            foreach(Person p in list)
            {
                Console.WriteLine("{0} {1}", p.Name, p.Age);
            }
            Console.WriteLine();

            Console.WriteLine("People sorted with default comparer (by age): ");
            list.Sort();
            foreach (Person p in list)
            {
                Console.WriteLine("{0} {1}", p.Name, p.Age);
            }
            Console.WriteLine();

            Console.WriteLine("People sorted with nondefault comparer (by name): ");
            list.Sort(PersonComparerName.Default);
            foreach (Person p in list)
            {
                Console.WriteLine("{0} {1}", p.Name, p.Age);
            }
            Console.ReadKey();

            */


            //testcases in Exercise after chapter
            People myPeople = new People();
            myPeople["Alice"] = new Person { Name = "Alice", Age = 30 };
            myPeople["Bob"] = new Person { Name = "Bob", Age = 25 };
            myPeople["Charlie"] = new Person { Name = "Charlie", Age = 35 };
            myPeople["Daisy"] = new Person { Name = "Daisy", Age = 35 }; // 同年龄的另一个人

            // 测试迭代器
            Console.WriteLine("Ages:");
            foreach (int age in myPeople)
            {
                Console.WriteLine(age);
            }

            // 测试 GetOldest 方法
            var oldest = myPeople.GetOldest();
            Console.WriteLine("\nOldest:");
            foreach (var person in oldest)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            // 测试克隆功能
            People clonedPeople = (People)myPeople.Clone();
            Console.WriteLine("\nCloned People:");
            foreach (var age in clonedPeople)
            {
                Console.WriteLine(age);
            }

        }
    }
}