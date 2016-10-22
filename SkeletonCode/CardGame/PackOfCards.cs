using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCards : IPackOfCards
	{
        public List<ICard> _list = new List<ICard>();

        public void Add(Card card)
        {
            _list.Add(card);
        }

	    public IEnumerator<ICard> GetEnumerator()
	    {
            return _list.GetEnumerator(); 	       
	    }

	    IEnumerator IEnumerable.GetEnumerator()
	    {
            return _list.GetEnumerator();
	        //return GetEnumerator();
	    }

        public int Count { get { return _list.Count; } }

	    public void Shuffle()
	    {
	        throw new System.NotImplementedException();
	    }

	    public ICard TakeCardFromTopOfPack()
	    {
	        var lastIndex = _list.Count - 1;
	        var cardToBeRemoved = _list.ElementAt(lastIndex);
            _list.RemoveAt(lastIndex);
            return cardToBeRemoved;	        
	    }
	}

}
