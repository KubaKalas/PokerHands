namespace pokerHands
{
    public enum Suit
    {
        Clubs,Diamonds,Spades,Hearts
    }
    public enum Value
    {
        None, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
    public class Card
    {
        public Suit Suit{ get; set; }
        public Value Value { get; set; }

    }
}