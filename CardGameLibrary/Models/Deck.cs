namespace CardGameLibrary.Models;

public class Deck<TCard>
{
    private readonly Random _random = new();

    public List<TCard> Cards { get; set; }

    public Deck()
    {
        Cards = new List<TCard>();
    }

    public void AddCard(TCard card)
    {
        Cards.Add(card);
    }

    public TCard DrawCard()
    {
        if (Cards.Count == 0)
            throw new InvalidOperationException("O baralho está vazio.");

        var card = Cards[0];
        Cards.RemoveAt(0);

        return card;
    }

    public void Shuffle()
    {
        Cards = Cards.OrderBy(x => _random.Next()).ToList();
    }
}
