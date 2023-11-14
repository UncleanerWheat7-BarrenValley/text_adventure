namespace OOPAdventure;

public partial class House
{
    public void DecorateRooms()
    {
        foreach (var room in Rooms)
        {
            var roomDescription = Text.Language.RoomDescription[0];

            if (Text.Language.RoomDescription.Count > 1 && m_rnd.Next(0, 2) == 1)
            {
                roomDescription = Text.Language.RoomDescription[m_rnd.Next(1, Text.Language.RoomDescription.Count)];

                Text.Language.RoomDescription.Remove(roomDescription);
            }

            room.Description = string.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}");
        }
    }

    public void PopulateRooms(List<Item> items, List<NPC> NPCs)
    {
        var i = 0;
        while (i != items.Count)
        {
            var room = Rooms[m_rnd.Next(0, Rooms.Length)];

            if (room.TotalInventoryCount == 0)
            {
                room.AddItem(items[i]);
                i++;
            }
        }

        i = 0;
        while (i != NPCs.Count)
        {
            var room = Rooms[m_rnd.Next(0, Rooms.Length)];

            if (room.TotalInventoryCount == 0)
            {
                room.AddNPC(NPCs[i]);
                i++;
            }
        }
    }
}
