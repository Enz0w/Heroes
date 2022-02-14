using System;

namespace Heroes.Classes
{
    public abstract class Hero
    {           
        
        public string name;
        public int level;
        public string heroType;
        Random randNum = new Random(); 
        int random;          
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Hero()
        {

        }        

        public string ShowCard()
        {
            return(
                "====================\n" +
                $"Nome: {name} \n" +
                $"Nível: {level}\n" +
                $"Classe: {heroType}\n"
            );
        }

        public virtual string Attack()
        {
            return this.name + " atacou com seus punhos.";
        }

        public virtual string Attack(Hero target)
        {
            return this.name + $" encaixa uma sequência de golpes em {target.name}.";
        }

        public virtual string Attack(Enemy target)
        {
            return this.name + $" ataca {target.name} com todas as suas forças.";
        }

        public string LevelUp()
        {
            this.level += 1;
            return this.name + $" alcançou o nível {level}.";
        }

        public virtual string Block()
        {
            random = randNum.Next(1,6);
            if(random <= 3)
            {
                return this.name + " não foi forte o suficiente para bloquear.";
            }
            else
            {
                return this.name + " bloqueia um ataque.";
            }
            
        }

        public virtual string Avoid()
        {
            random = randNum.Next(1,6);
            if(random <= 3)
            {
                return this.name + " não consegue se esquivar.";                   
            }
            else
            {
                return this.name + " se esquiva ligeiramente."; 
            }
            
        }       

        
    }
}