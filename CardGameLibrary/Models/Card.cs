namespace CardGameLibrary.Models;

public class Card<TSuit, TValue>
{
    public TSuit Suit { get; set; }
    public TValue Value { get; set; }

    public Card(TSuit suit, TValue value)
    {
        Suit = suit;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} de {Suit}";
    }
}
