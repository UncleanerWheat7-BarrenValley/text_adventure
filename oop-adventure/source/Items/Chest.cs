namespace OOPAdventure;

public class Chest : Item, IInventory
{
    private readonly House m_house;
    private readonly Inventory m_inventory = new();
    private readonly bool m_locked = true;

    public override string Name => Text.Language.Chest;
    public int TotalInventoryCount => ((IInventory)m_inventory).TotalInventoryCount;
    public string[] InventoryList => ((IInventory)m_inventory).InventoryList;

    public Chest(Item?[] items, House house)
    {
        CanTake = false;
        m_house = house;

        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    public override void Use(string source)
    {
        if (source == Text.Language.Key)
        {
            var items = InventoryList;

            if (m_locked)
            {
                Console.WriteLine(Text.Language.UnlockChest);
            }

            if (items.Length == 0)
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound, Text.Language.JoinedWordList(items, Text.Language.And)));

                foreach (var itemName in items)
                {
                    var item = TakeItem(itemName);
                    m_house.Player.AddItem(item);
                }
            }
        }
        else if (source == Text.Language.Knife)
        {
            var items = InventoryList;

            if (items.Length == 0)
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound, Text.Language.JoinedWordList(items, Text.Language.And)));
                
                foreach (var itemName in items)
                {
                    var item = TakeItem(itemName);
                    m_house.CurrentRoom.AddItem(item);
                }
                
                m_house.CurrentRoom.RemoveItem(this);
            }
            
        }
    }

    public void AddItem(Item item)
    {
        ((IInventory)m_inventory).AddItem(item);
    }

    public bool ContainsItem(string itemName)
    {
        return ((IInventory)m_inventory).ContainsItem(itemName);
    }

    public bool TryFindItem(string itemName, out Item? item, bool? remove = false)
    {
        return m_inventory.TryFindItem(itemName, out item, remove);
    }

    public void RemoveItem(Item item)
    {
        ((IInventory)m_inventory).RemoveItem(item);
    }

    public Item? TakeItem(string itemName)
    {
        return ((IInventory)m_inventory).TakeItem(itemName);
    }

    public void UseItem(string itemName, string source)
    {
        ((IInventory)m_inventory).UseItem(itemName, source);
    }
}