namespace OOPAdventure
{
    public class BasicNPC : NPC
    {        
        public BasicNPC(string name, string? customResponse) : base(name)
        {
            Name = name;
            Response = customResponse != null ? customResponse : Text.Language.TalkBarryResponse;
        }

        public override void Talk(Player player)
        {
            Console.WriteLine(Response, player.Name, Name);
        }

        // public override bool Attacked(int weaponDamageOutput)
        // {
        //     Console.WriteLine(Text.Language.Attacked, weaponDamageOutput);
        //     Health -= weaponDamageOutput;
        //
        //     if (Health <= 0)
        //     {
        //         return true;
        //     }
        //
        //     return false;
        // }

      
    }
}

