using System;
using Heroes.Classes;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 25, "Guerreiro");
            Wizard Jennica = new Wizard("Jennica", 27, "Feiticeira");
            Ninja Oden = new Ninja("Oden", 24, "Ninja");
            DarkWizard Doyle = new DarkWizard("Doyle", 28, "Feiticeiro Negro");
            Enemy Vampire = new Enemy("Vampiro", 16);
            
            Console.WriteLine(Doyle.Attack(Jennica));
            Console.WriteLine(Jennica.Avoid());
            Console.WriteLine(Doyle.LevelUp());
            System.Console.WriteLine();

            Console.WriteLine(Arus.Attack(Oden));
            Console.WriteLine(Oden.Block());
            System.Console.WriteLine();

            Console.WriteLine(Oden.Attack(Doyle));
            Console.WriteLine(Doyle.Avoid());
            Console.WriteLine(Oden.LevelUp());
            System.Console.WriteLine();

            Console.WriteLine(Jennica.Attack(Arus));
            Console.WriteLine(Arus.Block());
            System.Console.WriteLine();

            Console.WriteLine(Vampire.Attack(Oden));
            Console.WriteLine(Oden.Attack(Vampire));
            System.Console.WriteLine();                   
            

        }
    }
}
