namespace OOPAdventure;

public class Talk : Action
{
    private readonly House m_house;
    private readonly Player m_player;
    
    public override string Name => Text.Language.Talk;

    public Talk(House house, Player player)
    {
        m_house = house;
        m_player = player;
    }


    public override void Execute(string[] args)
    {
        if (args.Length == 2)
        {
            if (m_house.CurrentRoom.TryFindPresentNPCs(out List<NPC> NPCReturnList))
            {
                args[1].ToLower();
                foreach (var NPC in NPCReturnList)
                {
                    if (NPC.Name.ToLower() == args[1])
                    {
                        NPC.Talk(m_player);
                        return;
                    }
                }                
            }
        }

        Console.WriteLine(Text.Language.TalkError);
    }
}