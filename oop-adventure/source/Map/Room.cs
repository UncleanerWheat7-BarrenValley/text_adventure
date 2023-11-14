using System.Linq;
using System.Text;

namespace OOPAdventure;

public class Room : IInventory
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    private readonly Inventory m_inventory = new();
    public bool Visited { get; set; }
    public int TotalInventoryCount => m_inventory.TotalInventoryCount;

    public string[] InventoryList => m_inventory.InventoryList;

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.East, -1 },
        {Directions.South, -1 },
        {Directions.West, -1 },
        {Directions.None, -1 }
    };

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        var names = Enum.GetNames(typeof(Directions));
        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();
        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));
        

        if (Visited)
        {
            stringBuilder.Append(string.Format(Text.Language.RoomOld, Name));
        }
        else
        {
            stringBuilder.Append(string.Format(Text.Language.RoomNew, Name));
        }
        
        if(TryFindPresentNPCs(out List<NPC>? NPCReturnList))
        {
            foreach (var NPC in NPCReturnList)
            {
                description += Text.Language.Also + NPC.Name + Text.Language.IsHere;
            }            
        }

        stringBuilder.Append(description);

        if (m_inventory.TotalInventoryCount > 0)
        {
            var items = m_inventory.InventoryList;

            var pluralPre = items.Length > 1 ? Text.Language.Are : Text.Language.Is;

            var pluralPost = items.Length > 1 ? Text.Language.Plural : " ";

            stringBuilder.Append(string.Format(Text.Language.TotalItems, pluralPre, items.Length, pluralPost));

            stringBuilder.Append(Text.Language.JoinedWordList(items, Text.Language.And) + Text.Language.Period);
        }

        return stringBuilder.ToString();
    }

    public void AddItem(Item item)
    {
        m_inventory.AddItem(item);
    }

    public void AddNPC(NPC NPC)
    {
        m_inventory.AddNPC(NPC);
    }

    public bool ContainsItem(string itemName)
    {
        return m_inventory.ContainsItem(itemName);
    }
    
    public bool TryFindItem(string itemName, out Item? item, bool? remove = false)
    {
        return m_inventory.TryFindItem(itemName, out item, remove);
    }

    public void RemoveItem(Item item)
    {
        m_inventory.RemoveItem(item);
    }
    
    public void RemoveNPC(NPC NPC)
    {
        m_inventory.RemoveNPC(NPC);
    }

    public Item? TakeItem(string itemName)
    {
        return m_inventory.TakeItem(itemName);
    }

    public void UseItem(string itemName, string source)
    {
        m_inventory.UseItem(itemName, source);
    }
    
    public bool TryFindPresentNPCs(out List<NPC>? NPCReturnList)
    {        
        return m_inventory.TryFindPresentNPCs(out NPCReturnList);
    }
}