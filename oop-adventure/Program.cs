using OOPAdventure;

Text.LanguageSelect();

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == string.Empty)
{
    name = Text.Language.DefaultName;
}

Console.WriteLine(Text.Language.ChooseYourAge);

var age = Console.ReadLine();

if (age == string.Empty)
{
    age = Text.Language.DefaultAge;
}

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name, age);

var house = new House(player);
house.CreateRooms(3, 3);
house.DecorateRooms();

var items = new List<Item>()
{
    new Key(house),
    new Chest(new[] {new Gold(100)}, house),
    new Knife(house)
    
};

var NPCs = new List<NPC>()
{
    new BasicNPC(Text.Language.NPCName, null),
    new BasicNPC(Text.Language.NPCName, "Hello there"),
    new BasicNPC(Text.Language.NPCName, "Boo"),
    new BasicNPC(Text.Language.NPCName, null),
    new BasicNPC(Text.Language.NPCName, "Hello there"),
    new BasicNPC(Text.Language.NPCName, "Boo"),
};

house.PopulateRooms(items, NPCs);

Actions.Instance.Register(new Go(house));
Actions.Instance.Register(new Backpack(player));
Actions.Instance.Register(new Take(house));
Actions.Instance.Register(new Use(house));
Actions.Instance.Register(new Talk(house, player));
Actions.Instance.Register(new Attack(house, player));

house.GoToStartingRoom();

var run = true;

Room lastRoom = null;

while (run)
{
    if (lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }

    Console.WriteLine(Text.Language.WhatToDo);

    var input = Console.ReadLine().ToLower();

    if (input == Text.Language.Quit)
    {
        run = false;
    }
    else
    {
        if (player.Health <= 0)
        {
            Console.WriteLine(Text.Language.YouAreDead);
        }
        else
        {
            Actions.Instance.Execute(input.Split(" "));
        }
    }
}