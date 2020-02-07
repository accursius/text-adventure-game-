using System;

namespace text_adventure_game__all_sections
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        struct stats
        {
            public string race;
            public int strength;
            public int intelligence;
            public int speed;
            public string charclass;
            public string name;
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
        static void inventory()
        {
            string[,] inventory = new string[10, 3];
            // make this into a 2d array that has a strength or quanitity and tells you what it is A= attack D= defense i= item must start with 3 potions 
            //creates new array
            // make a shop array
            //the array shoudl have money in
            inventory[0, 1] = "sword";
            inventory[0, 1] = "1";
            inventory[0, 3] = "Attack";
            inventory[1, 1] = "sheild";
            inventory[1, 2] = "1";
            inventory[1, 3] = "Defense";
            inventory[3, 1] = "potions";
            inventory[3, 2] = "3";
            inventory[3, 3] = "health";
            inventory[4, 1] = "money";
            inventory[4, 2] = "1000";
            inventory[4, 3] = "currency";
            int choice = 0;
            int count = 2;
            string item = "";
            // menu do tne user can either add to their inventory or list everythiingin their invetory
            // menu sorts things in catogries attack defese and items 
            // allows the user to buy things and takes the ammount specified off the users balance

            Console.WriteLine("press one to display items in your inventory, press two to add items or 3 to buy potions");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //goes through the array and siaplays all the items to the screen 
                    foreach (string element in inventory)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    Console.WriteLine("how many items do you want to add?");
                    choice = int.Parse(Console.ReadLine());
                    inventory = new string[choice, 1];
                    //this loops through the array and adds in items to each section of it 
                    // count starts at 2 as there are already a sword and shield within the array
                    Console.WriteLine("what items do you want to add to the array?");
                    item = Console.ReadLine();
                    // loops through the array to find a space to put an item
                    while ((count != inventory.Length) && (inventory[count, 1] != null))
                    {
                        count++;
                        if ((count == inventory.Length) && (inventory[count, 1] != null))
                        {
                            Console.WriteLine("you cant carry anymore");
                        }
                        else if (inventory[count, 1] == item)
                        {
                            Console.WriteLine("you have picked up another " + item);
                            inventory[count, 2] = item;
                        }
                        else if (inventory[count, 1] == null)
                        {
                            inventory[count, 1] = item;
                            Console.WriteLine("you now have a" + item);
                            // make the user decide if it is an attack defense or item 
                            // randomise to generate its rating and add this to another part of the array
                        }

                    }
                    break;
                case 3:
                    Console.WriteLine(" how many potions do you want? (20 coins each)");
                    choice = int.Parse(Console.ReadLine());
                    while (int.Parse(inventory[3, 2]) >= 20 * choice)
                    {
                        choice = int.Parse(inventory[4, 2]) + choice;
                        (inventory[4, 2]) = choice.ToString();
                    }
                    break;
            }
            Console.ReadLine();
        }
        public static void rooms()
        {
            string status = "alive";

            //loop until you're dead :)


            if (status != "dead")

            {
                Console.WriteLine("pick a room");
                string roomchoice = "";
                roomchoice = Console.ReadLine();

                //room choices 
                if (roomchoice == "cellar")
                {
                    Console.WriteLine("you are in a dark cellar, what do you want to do? climb the stairs on explore?");
                    roomchoice = Console.ReadLine();
                    if (roomchoice == "clim the stairs")
                    {
                        Console.WriteLine("you climed the stairs, you are noe out of the dungeom");

                    }
                    else if (roomchoice == "explore")
                    {
                        Console.WriteLine(" whilst you are exploring the cellar, a loose floorboard falls and hits you, killing you instanly ");
                        Console.WriteLine("game over");
                        status = "dead";

                    }
                }
            }
            Console.ReadLine();
        }
    }
}


