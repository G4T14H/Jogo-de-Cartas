namespace CardGameLibrary.Models;

public class Game<TPlayer>
{
    public string Name { get; set; }
    public List<TPlayer> Players { get; set; }

    public Game(string name)
    {
        Name = name;
        Players = new List<TPlayer>();
    }

    public void AddPlayer(TPlayer player)
    {
        Players.Add(player);
    }
}
