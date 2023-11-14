namespace OOPAdventure;

public class Take : Action
{
    private readonly House m_house;
    public override string Name => Text.Language.Take;

    public Take(House house)
    {
        m_house = house;
    }
    
    public override void Execute(string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine(Text.Language.NotTaken);

            return;
        }

        var inventory = m_house.CurrentRoom;
        var itemName = args[1].ToLower();

        if (inventory.ContainsItem(itemName))
        {
            var item = inventory.TakeItem(itemName);

            if (item.CanTake)
            {
                m_house.Player.AddItem(item);

                Console.WriteLine(Text.Language.TookDescription, itemName);
            }
            else
            {
                Console.WriteLine(Text.Language.CantTakeDescription, itemName);
            }

            return;
        }

        Console.WriteLine(Text.Language.TakeError);
    }

}