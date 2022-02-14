namespace Heroes.Classes
{
    public class DarkWizard : Hero
    {
        public DarkWizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        
        public DarkWizard()
        {
            
        }

        public override string Attack()
        {
            return this.name + " ataca com magia negra.";
        }

        public override string Attack(Hero target)
        {
            return this.name + $" ataca {target.name} com sua besta negra.";
        }
        public override string Avoid()
        {
            return this.name + " se teleporta para evitar o ataque.";
        }
    }
}