using OOPAdventure;

public class Inventory : IInventory
{
    private readonly List<NPC> m_currentNPCList = new();
    private List<Item> Items { get; } = new();
    private List<NPC> NPCs { get; } = new();
    
    public int TotalInventoryCount => Items.Count + NPCs.Count;
    public string[] InventoryList => Items.Select(i => i.Name).ToArray();

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void AddNPC(NPC NPC)
    {
        NPCs.Add(NPC);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }
    
    public void RemoveNPC(NPC NPCToRemove)
    {
        NPCs.Remove(NPCToRemove);
    }

    public Item? TryFindItem(string itemName)
    {
        foreach (var item in Items)
        {
            if (item?.Name == itemName)
            {
                return item;
            }
        }

        return null;
    }

    public bool TryFindPresentNPCs(out List<NPC>? NPCReturnList)
    {
        NPCReturnList = NPCs;
        if (NPCReturnList.Count >0)
        {
            return true;
        }
        return false;
    }
    
    public bool TryFindItem(string itemName, out Item? item, bool? remove = false)
    {
        item = TryFindItem(itemName);

        if (item != null && remove == true)
        {
            RemoveItem(item);
        }
        
        return item != null;
    }

    public bool ContainsItem(string itemName)
    {
        return TryFindItem(itemName) != null;
    }

    public Item? TakeItem(string itemName)
    {
        TryFindItem(itemName, out var item, true);
        return item;
    }

    public void UseItem(string itemName, string source)
    {
        var item = TryFindItem(itemName);

        if (item != null)
        {
            item.Use(source);
            if (item.SingleUse)
            {
                RemoveItem(item);
            }
            return;
        }
        Console.WriteLine(Text.Language.NoItem, itemName);
    }
}