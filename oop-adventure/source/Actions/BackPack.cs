namespace OOPAdventure;

public class Backpack : Action
{
    
    private readonly IInventory m_inventory;
    public override string Name => Text.Language.Backpack;
    
    public Backpack(IInventory inventory)
    {
        m_inventory = inventory;
    }

    public override void Execute(string[] args)
    {
        var items = m_inventory.InventoryList;

        if (items.Length == 0)
        {
            Console.WriteLine(Text.Language.BackpackError);
            return;
        }

        var list = Text.Language.JoinedWordList(items, Text.Language.And);

        Console.WriteLine(Text.Language.BackpackDescription, list);
    }
}