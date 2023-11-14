namespace OOPAdventure;

public partial class House
{
    private int CalculateRoomIndex(int col, int row)
    {
        return Math.Clamp(col, -1, Width) + Math.Clamp(row, -1, Height) * Width;
    }

    public void CreateRooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];

        for (int i = 0; i < total; i++)
        {
            var tmpRoom = new Room();

            var col = i % Width;
            var row = i / Width;

            tmpRoom.Name = String.Format(Text.Language.DefaultRoomName, i, col, row);

            if (col < Width - 1)
            {
                tmpRoom.Neighbors[Directions.East] = CalculateRoomIndex(col + 1, row);
            }

            if (col > 0)
            {
                tmpRoom.Neighbors[Directions.West] = CalculateRoomIndex(col - 1, row);

            }
            if (row < Height - 1)
            {
                tmpRoom.Neighbors[Directions.South] = CalculateRoomIndex(col, row + 1);
            }
            if (row > 0)
            {
                tmpRoom.Neighbors[Directions.North] = CalculateRoomIndex(col, row - 1);
            }

            Rooms[i] = tmpRoom;
        }
    }
}