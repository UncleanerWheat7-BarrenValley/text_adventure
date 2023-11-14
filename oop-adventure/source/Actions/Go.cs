namespace OOPAdventure;

public class Go : Action
{
    private readonly House m_house;
    public override string Name => Text.Language.Go;

    public Go(House house)
    {
        m_house = house;
    }

    public override void Execute(string[] args)
    {
        var currentRoom = m_house.CurrentRoom;

        var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();

        Enum.TryParse(dir, out Directions newDirection);

        var nextRoomIndex = currentRoom.Neighbors[newDirection];

        if (nextRoomIndex == -1 || newDirection == Directions.None)
        {
            Console.WriteLine(Text.Language.GoError);
        }
        else
        {
            m_house.GoToRoom(nextRoomIndex);
        }
    }
}            