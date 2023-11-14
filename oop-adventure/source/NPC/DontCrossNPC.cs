namespace OOPAdventure
{
    public class DontCrossNPC : NPC
    {
        public DontCrossNPC(string name, string? customResponse) : base(name)
        {
            Name = name;
            Response = Response = customResponse != null ? customResponse : Text.Language.TalkNoResponse;
        }

        public override void Talk(Player player)
        {
            Console.WriteLine(Response, Name);
            AttackPlayer(player);
        }

        private void AttackPlayer(Player player)
        {
            player.LoseHealth();
        }
        
        public override bool Attacked(int weaponDamageOutput)
        {
            Console.WriteLine("OW That hurt me by " + weaponDamageOutput + " Damage point");
            Health -= weaponDamageOutput;

            if (Health <= 0)
            {
                return true;
            }

            return false;
        }
    }
}