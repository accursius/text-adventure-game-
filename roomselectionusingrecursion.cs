using System;

namespace reccursion
{
    class Program
    {
        static void Main(string[] args)
        {
            rooms();
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
}
