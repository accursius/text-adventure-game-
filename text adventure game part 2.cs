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
        static void Main(string[] args)
        {
            selection();

        }
        public static void selection()
        {
            int answer = 0;
            string race = "";
            int strength = 0;
            int intelligence = 0;
            int speed = 0;
            string charclass = "";
            string name = "";

            {
                Console.WriteLine(" please select a race, press: ");
                Console.WriteLine("1 for human");
                Console.WriteLine(" 2 for elf ");
                answer = int.Parse(Console.ReadLine());

                switch (answer)
                { case 1:
                        race = "1";
                        race = "human";
                        strength = strength + 20;
                        intelligence = intelligence + 10;
                        speed = speed + 30;
                        Console.WriteLine("please go and select a class");
                        break;

                    case 2:
                        race = "elf ";
                        strength = strength + 10;
                        intelligence = intelligence + 35;
                        speed = speed + 30;
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
                        charclass = "swordsman";
                        strength = strength + 20;
                        intelligence = intelligence + 5;
                        speed = speed + 10;
                        break;

                    case 2:
                        charclass = "wizard";
                        strength = strength + 10;
                        intelligence = intelligence + 35;
                        speed = speed + 30;
                        break;

                    case 3:
                        charclass = "archer";
                        strength = strength + 10;
                        intelligence = intelligence + 10;
                        speed = speed + 30;
                        break;
                }
                Console.WriteLine("what is your name?");
                name = Console.ReadLine();

                Console.WriteLine("your stats are:");
                Console.WriteLine("you " + name + " are a " + race + " " + charclass + "!");
                Console.WriteLine("strength=" + strength + " intelligence =" + intelligence + " intelligence =" + intelligence + " speed=" + speed);
                Console.ReadLine();
            }
        }
    }
}