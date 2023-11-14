namespace OOPAdventure;

public class Key : Item
{
    private readonly House m_house;
    public override string Name { get; set; } = Text.Language.Key;

    public Key(House house)
    {
        m_house = house;

        CanTake = true;
        SingleUse = true;
    }

    public override void Use(string source)
    {
        m_house.CurrentRoom.UseItem(Text.Language.Chest, Name);
    }

}