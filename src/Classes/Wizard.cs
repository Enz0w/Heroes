namespace Heroes.Classes
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Wizard()
        {
            
        }
        
        public override string Attack()
        {
            return this.name + " lança uma magia.";
        }
        public override string Attack(Hero target)
        {
            return this.name + $" lança uma magia de luz em {target.name}.";
        }

        public override string Block()
        {
            return this.name + " bloqueou com escudo mágico.";
        }
    }
}