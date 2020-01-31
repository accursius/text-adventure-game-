using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure_game_part_two
{
    class Program
    {
        struct stats {
           public string race;
           public int strength;
           public int intelligence;
           public int speed;
           public string charclass;
           public string name;
        }

        static void Main(string[] args)
        {
            selection();

        }
        public static void selection()
        {

            {
                int answer = 0;
                stats maincharacter;
                Console.WriteLine(" please select a race, press: ");
                Console.WriteLine("1 for human");
                Console.WriteLine(" 2 for elf ");
                answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        maincharacter.race = "1";
                        maincharacter.race = "human";
                        maincharacter.strength = maincharacter.strength + 20;
                        maincharacter.intelligence = maincharacter.intelligence + 10;
                        maincharacter.speed = maincharacter.speed + 30;
                        Console.WriteLine("please go and select a class");
                        break;

                    case 2:
                        maincharacter.race = "elf ";
                        maincharacter.strength = maincharacter.strength + 10;
                        maincharacter.intelligence = maincharacter.intelligence + 35;
                        maincharacter.speed = maincharacter.speed + 30;
                        Console.WriteLine("please go and select a class");
                        break;
                }

                Console.WriteLine("please select a class. press");
                Console.WriteLine("1. swordsman");
                Console.WriteLine("2. wizard");
                Console.WriteLine("3. archer");
                answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        maincharacter.charclass = "swordsman";
                        maincharacter.strength = maincharacter.strength + 20;
                        maincharacter.intelligence = maincharacter.intelligence + 5;
                        maincharacter.speed = maincharacter.speed + 10;
                        break;

                    case 2:
                        maincharacter.charclass = "wizard";
                        maincharacter.strength = maincharacter.strength + 10;
                        maincharacter.intelligence = maincharacter.intelligence + 35;
                        maincharacter.speed = maincharacter.speed + 30;
                        break;

                    case 3:
                        maincharacter.charclass = "archer";
                        maincharacter.strength = maincharacter.strength + 10;
                        maincharacter.intelligence = maincharacter.intelligence + 10;
                        maincharacter.speed = maincharacter.speed + 30;
                        break;
                }
                Console.WriteLine("what is your name?");
                maincharacter.name = Console.ReadLine();

                Console.WriteLine("your stats are:");
                Console.WriteLine("you " + maincharacter.name + " are a " + maincharacter.race + " " + maincharacter.charclass + "!");
                Console.WriteLine("strength=" + maincharacter.strength + " intelligence =" + maincharacter.intelligence + " intelligence =" + maincharacter.intelligence + " speed=" + maincharacter.speed);
                Console.ReadLine();
            }
        }
    }
}
