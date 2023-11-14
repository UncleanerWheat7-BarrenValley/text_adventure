namespace OOPAdventure
{
    public abstract class NPC : Character
	{
        public string Response { get; set; }
        public abstract void Talk(Player player);
        public NPC(string name) : base(name)
        {
            Name = name;
        }

        public virtual bool Attacked(int weaponDamageOutput)
        {
            return false;
        }

        public void Remove(NPC npc)
        {
            throw new NotImplementedException();
        }
    }
}