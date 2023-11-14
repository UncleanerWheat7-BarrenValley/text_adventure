namespace OOPAdventure;

public class French : Language
{
    public French()
    {
        ChooseYourName = "Hello, What is your name but in french";
        DefaultName = "No name but in french";
        ChooseYourAge = "how old are you? but in french";
        DefaultAge = "No Age but in french";
        Welcome = "welcome {0} aged {1} to your OOP adventure! but in french";

        DefaultRoomName = "Room {0} ({1},{2}) but in french";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1} but in french";
        ActionError = "You can't do that. but in french";
        Go = "go";
        GoError = "you cant go that way";
        WhatToDo = "What would you like to do? but in french";
        Quit = "quit";
        RoomNew = "You entered {0} but in french";
        RoomOld = "You returned to {0} but in french";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescription = new List<string>
        {
            "normal", "cold", "warm", "dark", "bright", "scary", "strange"
        };
        NoItem = "No item by the name {0}. but in french";
        Backpack = "Backpack";
        BackpackError = "Backpack Empty";
        BackpackDescription = " your backpack contains {0}";
        Chest = "chest";
        UnlockChest = "you unlocked the chest but in french";
        Key = "key";
        ChestEmpty = "the chest is empty but in french";
        ChestFound = "You found: {0} but in french";
        Gold = "{0} Gold {1}";
        Coin = "Coin";
        Coins = Coin + "s";
        Plural = "s";
        Is = "Is";
        Are = "Are";
        Also = " Also ";
        IsHere = "Is here but in french";
        TotalItems = " There {0} {1} item{2} in the room: but in french";
        Period = ".";
        Take = "Take";
        TakeError = "There is nothing to take but in french";
        NotTaken = "You cant take that! but in french";
        TookDescription = "You took a {0} but in french";
        CantTakeDescription = "You cant take the {0} but in french";
        Use = "Use";
        UseSuccess = "you used {0} but in french";
        UseError = "cant use that but in french";

        NPCName = "Barry";
        Talk = "Talk";
        TalkBarryResponse = "Hi {0}, I'm {1}. please leave me alone but in french";
        TalkNoResponse = "{0} doesn't have much to say but in french";
        TalkError = "You shout out for help...but nobody came. Did you mean to talk to a specific person? try adding their name after typing \"talk\" but in french";

        DontCrossNPCName = "Daniel";
        YouDied = "You Died but in french";
        YouAreDead = "You are dead and can no longer do anything. you should probably quit the game but in french";
    }
}