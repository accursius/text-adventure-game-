using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure_game_part_6__login
{
    class Program
    {
       
        const int increase = 27;
        static int count = 0;
        static int[] hash = new int[count];


        static void Menu(string[] args)
        {
            int answer = 0;
            while ((answer != 1) && (answer != 2))
            {
                Console.WriteLine("press 1 to login or two to sign up");
                answer = int.Parse(Console.ReadLine());
                switch (answer) {
                    case 1:
                        login();
                        break;
                    case 2:
                        signup();
                        break; 
                }//answer = login 
            }
        }
        static string[] signup()
            // use return 
        {
            string[] ID = new string[2];
           string username = "";
           string password = "";
            // change this to an array 

            int count = 0;
            // this part sets the username 
            do
            {
                Console.WriteLine("pick your username");
                ID[0] = Console.ReadLine();
                ID[0] = ID[1].ToLower();
                if (ID[1].StartsWith(" "))
                {
                    ID[0] = ID[0].Trim();
                }
                //this part sets the password 
                do
                {
                    Console.WriteLine(" pick your password ( passwords must be 8 characters long cntaining upper case, lower case  digits and symbols");
                    ID[1] = Console.ReadLine();
                    char[] characters = ID[1].ToCharArray();
                }
                // this checks that the password contains all the criteria
                while (password.Any(Char.IsUpper) && (password.Any(char.IsDigit)) && (password.Any(char.IsLower)) && (password.Any(char.IsSymbol)));
            }
            while ((ID[0].Length > 8) && (ID[1].Length > 8));
            return ID;
        }
        static string login(string[] ID)
        {
            string userinputusername = "";
            string userinputpassword = "";
            do
            {
                Console.WriteLine("enter your username");
                userinputusername = Console.ReadLine();
                Console.WriteLine("enter your password");
                userinputpassword = Console.ReadLine();
            }
            while ((ID[0] == userinputusername) && (ID[1] == userinputpassword));
        }
        static int encryption(string[] ID)
        {

            int value;
            char[] characters = ID[1].ToCharArray();
            while (count != ID[1].Length)
            {
                value = characters[count].GetHashCode();
                value = value + increase;
                hash[count] = Convert.ToChar(value);
                count++;
            }
            return hash;
        }
        static void decrypt()
        {
           int count = 0;
            while (count != hash.Length)
            {
                StringBuilder decrytped_text = new StringBuilder();
                decrytped_text.Append(hash[count].GetHashCode());
                count++;  
            }

        }
    }
}
