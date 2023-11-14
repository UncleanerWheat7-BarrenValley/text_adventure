namespace OOPAdventure;

public class Knife : Item, IWeapon
{
    private House m_house;
    public override string Name { get; set; } = Text.Language.Knife;
    public int weaponDamageOutput { get; set; } = 1;
    public int WeaponAmmo { get; set; } = 1;
    

    public Knife(House house)
    {
        m_house = house;

        CanTake = true;
    }

    public override void Use(string source)
    {
        m_house.CurrentRoom.UseItem(Text.Language.Chest, Name);
    }
    
    public void Attack(NPC npc)
    {
        npc.Health -= weaponDamageOutput;
    }
}