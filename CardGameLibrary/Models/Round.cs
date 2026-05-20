namespace CardGameLibrary.Models;

public class Round<TPlayer>
{
    public int Number { get; set; }
    public List<TPlayer> Players { get; set; }

    public Round(int number)
    {
        Number = number;
        Players = new List<TPlayer>();
    }

    public void AddPlayer(TPlayer player)
    {
        Players.Add(player);
    }
}
