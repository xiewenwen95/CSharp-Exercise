using System;
using System.Collections;

namespace CSharpIntro
{
	public class Primes
	{
		private long min;
		private long max;

		public Primes() : this(2, 100)
		{
		}

		public Primes(long minimum, long maximum)
		{
			if(min<2)
			{
				min = 2;
			}
			else
			{
				min = minimum;
			}
			max = maximum;
		}
		public IEnumerator GetEnumerator()
		{
			for(long possiblePrime=min; possiblePrime<=max;possiblePrime++)
			{
				bool isPrime = true;
				for(long possibleFactor=2;possibleFactor<=(long)Math.Floor(Math.Sqrt(possiblePrime));possibleFactor++)
				{
					long remainderAfterdivision = possiblePrime % possibleFactor;
					if(remainderAfterdivision==0)
					{
						isPrime = false;
						break;
					}
				}
				if(isPrime)
				{
					yield return possiblePrime;
				}
			}
		}
	}
}

