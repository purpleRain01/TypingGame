using System;
using System.Collections.Generic;
using System.Text;

namespace TypingGame
{
    class About: Player
    {
        public About()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************About Us**************");
            Console.ResetColor();
            Console.WriteLine("\nHi"+name);
            Console.WriteLine("\n**************What We Do**************");
            Console.WriteLine("\n     Helping the society to experience and contribute in this growing Tech world.");
            Console.WriteLine("allowing you to progressively develop your typing skills through a simplified gamimg experience");
            Console.WriteLine("This is a part of our business.we deliver quality products");
            Console.WriteLine("this is a typing learner by playing you can improve your keeyboard skills");
            Console.WriteLine("\n\nenter any key for Main Menu");
            Console.WriteLine("\n\nCREATOR");
            Console.WriteLine("PurpleRain");
            Console.WriteLine("Version : 2.0.1");
            Console.WriteLine("early access");
            Console.ReadKey();
        }
    }
}
