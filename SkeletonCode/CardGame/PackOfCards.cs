using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCards : IPackOfCards
	{
        public List<ICard> Cards = new List<ICard>();

        public void Add(ICard card)
        {
            Cards.Add(card);
        }

	    public IEnumerator<ICard> GetEnumerator()
	    {
            return Cards.GetEnumerator(); 	       
	    }

	    IEnumerator IEnumerable.GetEnumerator()
	    {
            return Cards.GetEnumerator();
	    }

        public int Count { get { return Cards.Count; } }

	    public void Shuffle()
	    {
            int cardCount = Cards.Count;
            Random rnd = new Random();
            // Fisher-Yates algorithm
            while (cardCount > 1)
            {
                int k = rnd.Next(0, cardCount) % cardCount;
                cardCount--;
                ICard value = Cards[k];
                Cards[k] = Cards[cardCount];
                Cards[cardCount] = value;
            }
	    }

	    public ICard TakeCardFromTopOfPack()
	    {
	        var lastIndex = Cards.Count - 1;
	        var cardToBeRemoved = Cards.ElementAt(lastIndex);
            Cards.RemoveAt(lastIndex);
            return cardToBeRemoved;	        
	    }
	}

}
