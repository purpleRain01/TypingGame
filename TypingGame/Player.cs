using System;
using System.Collections.Generic;
using System.Text;

namespace TypingGame
{
    class Player
    {
        public static int points = 0;
        public static string name;
        static Player()//Asking personal details showing just like a start menu
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Hiiii {name.ToUpper()} Welcome \nEnjoy typing.....");
            Console.WriteLine("Mistakes lead to negaitve points(^ _ ^)");
            Console.WriteLine($"------Your Points:------{points}");
            Console.WriteLine("Enter any key for MENU");
            Console.ReadKey();
        }

    }

}
