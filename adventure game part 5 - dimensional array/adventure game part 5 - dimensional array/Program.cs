using System;
namespace text_adventure_game_par_four__inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            inventory();
        }
        static void inventory()
        {
            string[,] inventory = new string[10,3];
            // make this into a 2d array that has a strength or quanitity and tells you what it is A= attack D= defense i= item must start with 3 potions 
            //creates new array
            // make a shop array
            //the array shoudl have money in
            inventory[0,1] = "sword";
            inventory[0, 1] = "1";
            inventory[0, 3] = "Attack";
            inventory[1,1] = "sheild";
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
                    inventory = new string[choice,1];
                    //this loops through the array and adds in items to each section of it 
                    // count starts at 2 as there are already a sword and shield within the array
                    Console.WriteLine("what items do you want to add to the array?");
                    item = Console.ReadLine();
                    // loops through the array to find a space to put an item
                    while ((count != inventory.Length) && (inventory[count, 1] != null))
                    {
                        count++;
                        if ((count == inventory.Length) && (inventory[count,1] != null))
                        {
                            Console.WriteLine("you cant carry anymore");
                        }
                        else if (inventory[count,1] == item)
                        {
                            Console.WriteLine("you have picked up another " + item);
                            inventory[count, 2] = item;
                        }
                        else if (inventory[count,1] == null)
                        {
                            inventory[count,1] = item;
                            Console.WriteLine("you now have a" + item);
                            // make the user decide if it is an attack defense or item 
                            // randomise to generate its rating and add this to another part of the array
                        }

                    }
                    break;
                case 3:
                    Console.WriteLine(" how many potions do you want? (20 coins each)");
                    choice = int.Parse(Console.ReadLine());
                    while (int.Parse(inventory[3,2]) >= 20 * choice)
                    {
                        choice = int.Parse(inventory[4, 2]) + choice;
                        (inventory[4, 2]) = choice.ToString();
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
