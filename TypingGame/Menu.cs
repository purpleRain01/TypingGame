using System;
using System.Collections.Generic;
using System.Text;

namespace TypingGame
{
    class Menu
    {
        public string[] Options;
        public int selectedIndex;
        public Menu(string[] options)
        {
            selectedIndex = 0;
            Options = options;
        }
        private void DisplayOptions()
        {
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                string prefix;
                if (i == selectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine($" {prefix} << {currentOption} >>");
            }
            Console.ResetColor();
        }
        public int Run()
        {
            ConsoleKey keypress;
            do
            {
                if (selectedIndex > Options.Length - 1) { selectedIndex = 0; }
                if (selectedIndex < 0) { selectedIndex = Options.Length - 1; }

                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                keypress = keyinfo.Key;
                if (keypress == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                }
                else if (keypress == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                }

            } while (keypress != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}
