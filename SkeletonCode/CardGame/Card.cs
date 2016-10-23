using SkeletonCode.CardGame.Enums;

namespace SkeletonCode.CardGame
{
    public class Card : ICard
    {
        public Rank Rank { get; private set; }
        public SuitType Suit { get; private set; }

        public Card(SuitType suit, Rank rank)
        {
            Rank = rank;
            Suit = suit;
        }

    }
}
