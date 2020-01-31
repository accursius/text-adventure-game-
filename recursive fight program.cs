using System;

namespace reccurive_fight_program
{
    class Program
    {
        static void Main(string[] args)
        {
         fight();   
        }
        private static void fight()
        {
            // declare varibles here 
            string hero = "";
            string villain = "";
            int herohealth = 100;
            int villainhealth = 100;
            int herostrength = 20;
            int herodefense = 15;
            int villainstrength = 25;
            int villaindefense = 10;
            bool dead = false;
            int attack = 0;

            //attack randomisation 
            Random rnd = new Random();
            int dice = rnd.Next(1, 2);
            // this outputs 1 or 2 at random 

            if (herohealth > 0 || villainhealth > 0)
            {
                switch (dice)
                {
                    case 1:
                        dice = 1;
                        herohealth = herohealth - villainstrength + herodefense;
                        attack = herohealth - villainstrength + herodefense;
                        Console.WriteLine("the villain attacks, this attack dealt" + attack + "points of damage ");
                        break;
                    case 2:
                        dice = 2;
                        villainhealth = villainhealth - herostrength - villaindefense;
                        attack = villainhealth - herostrength - villaindefense;
                        Console.WriteLine("you attack, this attack dealt" + attack + " points of damage ");
                        break;
                }

            }
            while (herohealth == 0 || villainhealth == 0) ;
            if (villainhealth > herohealth)
            {
                dead = true;
            }
            switch (dead)
            {
                case true:
                    Console.WriteLine("the villain has defeted you...");
                    Console.Write("game over :(");
                    break;

                case false:
                    Console.Write("you have won :D");
                    break;
            }
            Console.ReadLine();


        }
    }
}
    }
}
