namespace OOPAdventure;

public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; } = 5;    

    public Character(string name)
    {
        Name = name;        
    }    
} 