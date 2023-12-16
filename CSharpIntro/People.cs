using System;
using System.Collections;

namespace CSharpIntro
{
	public class People:DictionaryBase,ICloneable
	{
		public  void Add (Person newPerson)
		{
			Dictionary.Add(newPerson.Name, newPerson);
		}
		public void Remove(string name)
		{
			Dictionary.Remove(name);
		}
		public People()
		{
		}
		public Person this[string name]
		{
			get { return (Person)Dictionary[name]; }
			set { Dictionary[name] = value; }
		}
		public Person[] GetOldest()
		{
			Person oldestPerson = null;
			Person curPerson;
			People oldestPeople = new People();
			foreach(DictionaryEntry p in Dictionary)
			{
				curPerson = p.Value as Person;
				if(oldestPerson==null)
				{
					oldestPeople.Clear();
					oldestPerson = curPerson;
					oldestPeople.Add(oldestPerson);
				}
				else
				{
					if(oldestPerson<=curPerson)
					{
						oldestPeople.Add(curPerson);
					}
				}
			}
			Person[] oldestArr = new Person[oldestPeople.Count];
			int index = 0;
			foreach(DictionaryEntry p in oldestPeople.Dictionary)
			{
				Person person = p.Value as Person;
				oldestArr[index] = person;
				index++;
			}
			return oldestArr;
		}

		public object Clone()
		{
			People clonedPeople = new People();
			Person curPerson, newPerson;
			foreach(DictionaryEntry p in Dictionary)
			{
				curPerson = p.Value as Person;
				newPerson = new Person();
				newPerson.Name = curPerson.Name;
				newPerson.Age = curPerson.Age;
				clonedPeople.Add(newPerson);
			}
			return clonedPeople;
		}

		public IEnumerator<int> GetEnumerator()
		{
			Person cur;
			foreach(object person in Dictionary.Values)
			{
				cur= person as Person;
				yield return cur.Age; 
			}
		}

       
    }
}

