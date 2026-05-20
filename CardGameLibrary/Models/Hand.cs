namespace CardGameLibrary.Models;

public class Hand<TCard>
{
    public List<TCard> Cards { get; set; }

    public Hand()
    {
        Cards = new List<TCard>();
    }

    public void AddCard(TCard card)
    {
        Cards.Add(card);
    }

    public void RemoveCard(TCard card)
    {
        Cards.Remove(card);
    }
}
