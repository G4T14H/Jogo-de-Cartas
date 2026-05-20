namespace CardGameLibrary.Models;

public class Player<TCard>
{
    public string Name { get; set; }
    public Hand<TCard> Hand { get; set; }

    public Player(string name)
    {
        Name = name;
        Hand = new Hand<TCard>();
    }
}
