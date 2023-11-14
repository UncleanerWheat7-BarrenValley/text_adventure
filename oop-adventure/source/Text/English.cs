using System.Threading.Tasks;

namespace OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is your name";
        DefaultName = "No name";
        ChooseYourAge = "how old are you?";
        DefaultAge = "No Age";
        Welcome = "welcome {0} aged {1} to your OOP adventure!";

        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}";
        ActionError = "You can't do that.";
        Go = "go";
        GoError = "you cant go that way";
        WhatToDo = "What would you like to do?";
        Quit = "quit";
        RoomNew = "You entered {0}";
        RoomOld = "You returned to {0}";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescription = new List<string>
        {
            "normal", "cold", "warm", "dark", "bright", "scary", "strange"
        };
        NoItem = "No item by the name {0}.";
        Backpack = "Backpack";
        BackpackError = "Backpack Empty";
        BackpackDescription = " your backpack contains {0}";
        Chest = "chest";
        UnlockChest = "you unlocked the chest";
        Key = "key";
        ChestEmpty = "the chest is empty";
        ChestFound = "You found: {0}";
        Gold = "{0} Gold {1}";
        Coin = "Coin";
        Coins = Coin + "s";
        Plural = "s";
        Is = "Is";
        Are = "Are";
        Also = "Also ";
        IsHere = "Is here";
        TotalItems = " There {0} {1} item{2} in the room:";
        Period = ".";
        Take = "Take";
        TakeError = "There is nothing to take";
        NotTaken = "You cant take that!";
        TookDescription = "You took a {0}";
        CantTakeDescription = "You cant take the {0}";
        Use = "Use";
        UseSuccess = "you used {0}";
        UseError = "cant use that";

        NPCName = "Barry";
        Talk = "Talk";
        TalkBarryResponse = "Hi {0}, I'm {1}. please leave me alone";
        TalkNoResponse = "{0} doesn't have much to say";
        TalkError = "You shout out for help...but nobody came. Did you mean to talk to a specific person? try adding their name after typing \"talk\"";

        DontCrossNPCName = "Daniel";
        YouDied = "You Died";
        YouAreDead = "You are dead and can no longer do anything. you should probably quit the game";

        Knife = "knife";
        Attack = "attack";
        Attacked = "OW That hurt me by {0} Damage points";
        AttackError = "attackError";
    }
}