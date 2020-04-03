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

    /*
    cast to int
    */

    public class Card
    {
        public Suit Suit{ get => Suit; set { Suit = value;} }
        public Value Value { get => Value; set { Value = value; } }

    }
}