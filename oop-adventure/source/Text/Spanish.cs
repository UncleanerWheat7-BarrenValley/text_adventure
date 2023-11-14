namespace OOPAdventure;

public class Spanish : Language
{
    public Spanish()
    {
        ChooseYourName = "Hello, What is your name but in spanish";
        DefaultName = "No name but in spanish";
        ChooseYourAge = "how old are you? but in spanish";
        DefaultAge = "No Age but in spanish";
        Welcome = "welcome {0} aged {1} to your OOP adventure! but in spanish";

        DefaultRoomName = "Room {0} ({1},{2}) but in spanish";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1} but in spanish";
        ActionError = "You can't do that. but in spanish";
        Go = "go";
        GoError = "you cant go that way";
        WhatToDo = "What would you like to do? but in spanish";
        Quit = "quit";
        RoomNew = "You entered {0} but in spanish";
        RoomOld = "You returned to {0} but in spanish";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescription = new List<string>
        {
            "normal", "cold", "warm", "dark", "bright", "scary", "strange"
        };
        NoItem = "No item by the name {0}. but in spanish";
        Backpack = "Backpack";
        BackpackError = "Backpack Empty";
        BackpackDescription = " your backpack contains {0}";
        Chest = "chest";
        UnlockChest = "you unlocked the chest but in spanish";
        Key = "key";
        ChestEmpty = "the chest is empty but in spanish";
        ChestFound = "You found: {0} but in spanish";
        Gold = "{0} Gold {1}";
        Coin = "Coin";
        Coins = Coin + "s";
        Plural = "s";
        Is = "Is";
        Are = "Are";
        Also = " Also ";
        IsHere = "Is here but in spanish";
        TotalItems = " There {0} {1} item{2} in the room: but in spanish";
        Period = ".";
        Take = "Take";
        TakeError = "There is nothing to take but in spanish";
        NotTaken = "You cant take that! but in spanish";
        TookDescription = "You took a {0} but in spanish";
        CantTakeDescription = "You cant take the {0} but in spanish";
        Use = "Use";
        UseSuccess = "you used {0} but in spanish";
        UseError = "cant use that but in spanish";

        NPCName = "Barry";
        Talk = "Talk";
        TalkBarryResponse = "Hi {0}, I'm {1}. please leave me alone but in spanish";
        TalkNoResponse = "{0} doesn't have much to say but in spanish";
        TalkError = "You shout out for help...but nobody came. Did you mean to talk to a specific person? try adding their name after typing \"talk\" but in spanish";

        DontCrossNPCName = "Daniel";
        YouDied = "You Died but in spanish";
        YouAreDead = "You are dead and can no longer do anything. you should probably quit the game but in spanish";
    }
}