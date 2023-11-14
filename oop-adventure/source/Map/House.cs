namespace OOPAdventure;

public partial class House
{
    public Player Player { get; }
    private readonly Random m_rnd = new(1234);
    
    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; private set; }

    public House(Player player)
    {
        Player = player;
    }
}