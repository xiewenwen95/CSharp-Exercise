using System;
namespace CSharpIntro
{
	
	public class Card
	{
		public readonly Suit suit;
		public readonly Rank rank;

		private Card()
		{
			
		}
		public Card(Suit suit,Rank rank)
		{
			this.rank = rank;
			this.suit = suit;
		}
        public override string ToString()
        {

			return "The " + rank + " of" + suit + "s";
        }
    }
}

