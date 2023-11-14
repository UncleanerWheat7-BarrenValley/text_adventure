namespace OOPAdventure;

public class Use : Action
{
    private readonly House m_house;

    public override string Name => Text.Language.Use;
    public Use(House house)
    {
        m_house = house;
    }
    
    public override void Execute(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine(Text.Language.UseError);
            return;
        }

        var itemName = args[1];

        m_house.Player.TryFindItem(itemName, out var item);
        
        if (item != null)
        {
            if (item.SingleUse)
            {
                item = m_house.Player.TakeItem(itemName);
            }
            
            Console.WriteLine(Text.Language.UseSuccess, item.Name);
            
            item.Use(itemName);
        }
        else
        {
            Console.WriteLine(Text.Language.UseError);
        }
        
    }
}