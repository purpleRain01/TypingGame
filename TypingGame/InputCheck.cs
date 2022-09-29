using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TypingGame
{
    class InputCheck : StringBuilding//Class which accepts the user input and comparing the input to already build string
                                     //from parent class
    {
        

        public void Calculate()//calculating points
        {
            int temp = (sb.Length / time) - error;
            points += temp;
            if (points < 0)
            {
                points = 0;
            }
            Console.WriteLine("points=" + points);
           
        }
        public InputCheck()//constructor for user input checking and error displaying.
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            userInput = Console.ReadLine();
            timer.Stop();
            while (userInput.Length != sb.Length)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EXCEEDS/FALL SHORT OF WORDS GIVEN");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sb);
                Console.ForegroundColor = ConsoleColor.Yellow;
                timer.Start();
                userInput = Console.ReadLine();
                timer.Stop();
            }
           
            time = (int)timer.ElapsedMilliseconds;
            time = time / 1000;
            Console.ResetColor();
            //handling exceptions
            try
            {
                Console.Write("\n");
                Console.WriteLine(sb);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (userInput[i] != sb[i])
                    {
                        error++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(userInput[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(userInput[i]);
                        Console.ResetColor();
                    }
                }
                float wpm = (float)((sb.Length - error) / (float)(time));
                if (error == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n********** NO MISTAKES CONGRATS *********");
                    Console.WriteLine($"\n{name},you took {time} seconds to type {sb.Length} characters");
                    Console.WriteLine($"{name},your typing speed is=*{wpm}* charecter/second");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n********* YOU MADE {error} MISTAKES **********");
                    Console.WriteLine($"\n{name},you took {time} seconds to type {sb.Length} characters");
                    Console.WriteLine($"{name},your typing speed is=*{wpm}* charecter/second");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"\n----------{e.Message}--------");
            }
            Console.ResetColor();

        }
    }
}
