namespace SkeletonCode.CardGame
{
    public class Card : ICard
    {
        public string Value { get; private set; }
        public SuitType Suit { get; private set; }

        public Card(SuitType suit, string value)
        {
            Value = value;
            Suit = suit;
        }

    }
}
