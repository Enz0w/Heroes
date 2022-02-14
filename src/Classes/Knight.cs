namespace Heroes.Classes
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        
        public Knight()
        {
            
        }
        public override string Attack()
        {
            return this.name + " atacou com sua espada.";
        }
        public override string Attack(Hero target)
        {
            return this.name + $" avança insaciavelmente para cima de {target.name}.";
        }       

        public override string Block()
        {
            return this.name + " utiliza duas mãos para bloquear com a espada.";
        }
        
    }
}