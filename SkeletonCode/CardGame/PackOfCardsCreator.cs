using System;
using SkeletonCode.CardGame.Enums;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{

        public IPackOfCards Create()
        {
            var pack = new PackOfCards();

            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))
                {
                    var card = new Card(suit, rank);
                    pack.Add(card);
                }
            }                                            
                        
            return pack; 
        }
	}
}
