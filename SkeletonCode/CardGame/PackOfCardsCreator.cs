using System.Collections.Generic;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
	    const int AmountOfCards = 52;

        public IPackOfCards Create()
        {
            var pack = new PackOfCards();
            var cardList = new List<Card>();

            for (int i = 0; i < AmountOfCards; i++)
            {
                // get random card
                var card = new Card(SuitType.Clubs, "2");
                pack.Add(card);        
            }                                                  
                        
            return pack; 
        }
	}
}
