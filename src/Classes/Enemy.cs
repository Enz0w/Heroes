using System;

namespace Heroes.Classes
{
    public class Enemy
    {
        public string name;
        public int level;     
        Random randNum = new Random();   
        int random; 
        public Enemy(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public string ShowCard()
        {
            return(
                "====================\n" +
                $"Monstro: {name} \n" +
                $"Nível: {level}\n" 
            );
        }

        public string Attack(){
            return this.name + " desfere um ataque.";
        }

        public string Attack(Hero target){
            return this.name + $" desfere um ataque em {target.name}.";
        }

        public string Avoid()
        {
            random = randNum.Next(1, 6);
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