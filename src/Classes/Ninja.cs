namespace Heroes.Classes
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Ninja()
        {
            
        }

        public override string Attack()
        {
            return this.name + " atira uma chuva de kunais.";
        }
        public override string Attack(Hero target)
        {
            return this.name + $" corta {target.name} com sua katana.";
        }

        public override string Avoid(){
            return this.name + " é rápido e esquiva do ataque.";
        }
    }
}