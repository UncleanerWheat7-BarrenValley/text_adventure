namespace OOPAdventure;

public class Player : Character, IInventory
{
    private readonly Inventory m_inventory;
    public int TotalInventoryCount => m_inventory.TotalInventoryCount;
    public string[] InventoryList => m_inventory.InventoryList;    
    
    public Player(string name) : base(name)
    {
        m_inventory = new Inventory();
    }
    
    public void AddItem(Item item)
    {
        m_inventory.AddItem(item);
    }   

    public bool ContainsItem(string itemName)
    {
        return m_inventory.ContainsItem(itemName);
    }

    public bool TryFindItem(string itemName, out Item? item, bool? remove = false)
    {
        return m_inventory.TryFindItem(itemName, out item, remove);
    }

    // public Item? TryFindItem(string itemName, bool remove)
    // {
    //     return m_inventory.TryFindItem(itemName, remove);
    // }   

    public void RemoveItem(Item item)
    {
        m_inventory.RemoveItem(item);
    }

    public Item? TakeItem(string itemName)
    {
        return m_inventory.TakeItem(itemName);
    }    

    public void UseItem(string itemName, string source)
    {
        m_inventory.UseItem(itemName, source);
    }

    public void Attack(string weaponName, string NPCName, House house)
    {
        if (TryFindItem(weaponName, out var item) && house.CurrentRoom.TryFindPresentNPCs(out List<NPC>? NPCReturnList))
        {
            var weapon = item as IWeapon;
            NPC npc = NPCReturnList.FirstOrDefault(n => n.Name.ToLower() == NPCName.ToLower());
            
            weapon.Attack(npc);    
            Console.WriteLine("you attacked " + npc.Name + " and dealt " + weapon.weaponDamageOutput + ". " + npc.Name + " now have " + npc.Health + " health left");
        }
        else
        {
            Console.WriteLine(Text.Language.AttackError);
        }
    }

    public void LoseHealth()
    {
        Health--;        
    }
}