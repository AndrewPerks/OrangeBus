using System.Collections.Generic;

namespace SkeletonCode.CardGame
{
	public interface IPackOfCards : IReadOnlyCollection<ICard>
	{
	    void Add(ICard card);
		void Shuffle ();
		ICard TakeCardFromTopOfPack ();
	}

}
