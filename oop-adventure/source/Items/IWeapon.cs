namespace OOPAdventure;

public interface IWeapon
{
    public int weaponDamageOutput { get; set; }
    public int WeaponAmmo { get; set; }

    public void Attack(NPC npc);

}