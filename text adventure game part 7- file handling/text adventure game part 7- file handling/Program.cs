using System;
using System.IO;

namespace text_adventure_game_part_7__file_handling
{
    class Program
    {
        static void Main(string[] args)
        {

            //this function is used to create a file and to store the users username and password in, this means the file van be checked within the login page 
            // creates the file
            //this allows the file to becalled as a string 
            const string users = "C:\\users.txt";
            // this creates the file stream
            FileStream FS = new FileStream(users, FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);
            // this hold the username and password
            string[] ID = new string[2];
            //this is so the file can be read from
            StreamReader SR = new StreamReader(FS);
            //this is the sign up function
            do
            {

                Console.WriteLine("pick your username");
                ID[0] = Console.ReadLine();
                //checks that the username doesn't have any white space before it and the it assigns it to te file
                if (ID[0].StartsWith(" "))
                {
                    ID[0] = ID[0].Trim();
                }
                SW.WriteLine(ID[0]);
                //this part sets the password 


                Console.WriteLine(" pick your password ( passwords must be 8 characters long cntaining upper case, lower case  digits and symbols");
                ID[1] = Console.ReadLine();
                SW.WriteLine(ID[1]);
                // this checks that the  username and password meets all the criteria
            }
            while ((ID[1].Length >= 8) && (ID[0] != " "));
            // this is the login function
            while ((ID[0] == " ") && (ID[1] == ""))
            {
                Console.WriteLine("enter your username");
                ID[0] = Console.ReadLine();
                Console.WriteLine("enter your password");
                ID[1] = Console.ReadLine();
            }
            //this checks that the username and password entered is the same ones in the file 
            if (users.Contains(ID[0]) && (users.Contains(ID[1])))
            {
                Console.WriteLine("welcome back " + ID[1]);
            }
            users.Close();
            //this isnt working and i don't know why
        }



    }
}

