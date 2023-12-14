using System;
namespace CSharpIntro
{
	public class Deck
	{
		//private Card[] cards;

		private Cards cards = new Cards();

		public Deck()
		{
			//cards = new Card[52];

			for(int i=0;i<4;i++)
			{
				for(int j=1;j<14;j++)
				{
					//cards[i * 13 + j - 1] = new Card((Suit)i, (Rank)j);
					cards.Add(new Card((Suit)i, (Rank)j));
				}
			}
		}
		public Card GetCard(int cardNum)
		{
			if (cardNum >= 0 && cardNum <= 51)
			{
				return cards[cardNum];
			}
			else
				throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,"Value must be between 0 and 51."));
		}
		public void Shuffle()
		{
			//Card[] newDeck = new Card[52];
			Cards newDeck = new Cards();
			bool[] assigned = new bool[52];
			Random sourceGen = new Random();
			for(int i=0;i<52;i++)
			{
				//int destCard = 0;
				int sourceCard = 0;
				bool foundCard = false;
				while(foundCard==false)
				{
					//destCard = sourceGen.Next(52);
					sourceCard = sourceGen.Next(52);

                    /*if (assigned[destCard] == false)
					{
						foundCard = true;
					}*/
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }

                /*assigned[destCard] = true;
				newDeck[destCard] = cards[i];*/

                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            //newDeck.CopyTo(cards, 0);
            newDeck.CopyTo(cards);
        }
		public void Extract()
		{
			Shuffle();
			Dictionary<Suit, Rank> selectedCards = new Dictionary<Suit, Rank>();
           
            Random num = new Random();
                   
            for (int i=0;i<5;i++)
			{
				
				Card selectedItem = cards[num.Next(52)];
				if(selectedCards.ContainsKey(selectedItem.suit) && !selectedCards.ContainsValue(selectedItem.rank))
				{
					selectedCards.Add(selectedItem.suit,selectedItem.rank);
				}
			}
			if(selectedCards.Count!=5)
			{
				Console.WriteLine("No flush!");
                foreach (KeyValuePair<Suit, Rank> pair in selectedCards)
                {
                    Console.WriteLine($"Key:{pair.Key}, Value:{pair.Value}");
                }
            }
			else
			{
				Console.WriteLine("Flush!");
			}
		}
	}
}

