using System;
using System.Collections;

namespace CSharpIntro
{
	public class Cards:CollectionBase
	{
		public void Add(Card newCard)
		{
			List.Add(newCard);
		}
		public void Remove(Card newCard)
		{
			List.Remove(newCard);
		}
		public Cards()
		{
		}
		public Card this[int cardIndex]
		{
			get { return (Card)List[cardIndex]; }
			set { List[cardIndex] = value; }
		}

		public void CopyTo(Cards targetCrads)
		{
			for(int index=0;index<this.Count;index++)
			{
				targetCrads[index] = this[index];
			}
		}
		public bool Contains(Card card)
		{
			return InnerList.Contains(card);
		}
	}
}

