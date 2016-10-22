using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCards : IPackOfCards
	{
        public List<ICard> Cards = new List<ICard>();

        public void Add(Card card)
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
            int n = Cards.Count;
            Random rnd = new Random();
            // Fisher-Yates algorithm
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                ICard value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
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
