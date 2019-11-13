using System;

namespace text_adventure_game_par_four__inventory
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void inventory()
        {
            string[] inventory = new string[10];
            //creates new array
            inventory[0] = "sword";
            inventory[1] = "sheild";
            int choice = 0;
            int count = 2;
            string item = "";

            // menu do tne user can either add to their inventory or list everythiingin their invetory
            Console.WriteLine("press one to display items in your inventory or press two");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("you cureently have a " + inventory[0] + " and " + inventory[1]);
                    break;
                case 2:
                    Console.WriteLine("how many items do you want to add?");
                    choice = int.Parse(Console.ReadLine());
                    inventory = new string[choice];
                    //this loops through the array and adds in items to each section of it 
                    // count starts at 2 as there are already a swrd and shield within the array
                    for (count = 2; count != choice;)
                    {
                        Console.WriteLine("what item do you want to add?");
                        // this searches the array to make sure the user isnt adding a a item that is already in the array
                        for (count = 0; count != inventory.Length;)
                        {
                            if ((count == inventory.Length) && (inventory[count] != item))
                            {
                                Console.WriteLine("you now have a" + item);
                                inventory[count] = Console.ReadLine();
                                count++;

                            }
                            else
                            {
                                Console.WriteLine("you already have this item");
                                Console.ReadLine();
                            }
                        }



                    }
                    break;
                    

            }



        }

    }
}
