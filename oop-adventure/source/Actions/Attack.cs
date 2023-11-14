namespace OOPAdventure;

public class Attack : Action
{
    public readonly House m_house;
    public readonly Player m_player;

    public override string Name => Text.Language.Attack;

    public Attack(House house, Player player)
    {
        m_house = house;
        m_player = player;
    }

    public override void Execute(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine(Text.Language.AttackError);
            return;
        }

        var weaponName = args[1];
        var NPCName = args[2];
        
        m_player.Attack(weaponName,NPCName, m_house);
    }
}