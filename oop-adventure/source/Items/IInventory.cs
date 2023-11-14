using OOPAdventure;

public interface IInventory
{
    int TotalInventoryCount { get; }
    public string[] InventoryList { get; }

    void AddItem(Item item);
    bool ContainsItem(string itemName);
    bool TryFindItem(string itemName, out Item? item, bool? remove);
    void RemoveItem(Item item);
    Item? TakeItem(string itemName);
    void UseItem(string itemName, string source);    
}