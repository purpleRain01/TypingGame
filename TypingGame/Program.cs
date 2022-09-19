using System;
using System.Diagnostics;
using System.Text;

namespace TypingGame
{
   
    class Person
    {
        public static int points = 0;
        public static string name;
        static Person()//Asking personal details showing just like a start menu
        {
            Console.WriteLine("Enter your name:");
            name =Console.ReadLine();
            Console.WriteLine($"Hiiii {name.ToUpper()} Welcome \nEnjoy typing.....");
            Console.WriteLine("Mistakes lead to negaitve points(^  ^");
            Console.WriteLine($"------Your Points:------{points}");
            Console.WriteLine("Enter any key to start");
            Console.ReadKey();
        }
  
    }

    class StringBuilding:Person//Builds a string using stringbuilder functionality of CSharp,
                               //by taking inputs from 3 already declared string array.
    {
        public StringBuilder sb = new StringBuilder();
        public string userInput;
        public int error = 0, time;
        private readonly string[] nameArray = new string[] { "ARUN", "BOB", "CATHERINE", "DAVID", "ELIZABETH", "FIDA", "GIREESH", "HAMSA", "INDU", "JACK", "KIRAN", "LORENZO", "MANAKKOTAAN", "NEETHU", "OSHUA", "PHILIP", "QUEEN", "RIJO", "STELLA", "TYSON", "UNUZ", "VINOD", "WOMEN", "XERCAD", "YAMUNA", "ZACK" };
        private readonly string[] verbArray = new string[] { "IS", "WAS", "WERE", "MIGHT", "MAY", "WAS", "IS", "HAS", "HAD", "HAVE", "HAS", "WERE", "HAS", "MAY", "GOTO", "STARTED", "GOES ON", "IS", "WAS", "TENDS TO", "GIVE UP", "GOTO", "STARTED", "TENDS TO", "STILL", "GIVE UP" };
        private readonly string[] activityArray = new string[] { "PLAYING", "EATING", "ATE", "BE THERE", "WENT HOSPITAL", "A TEACHER", "STILL A NRI", "A LAMBORGINI", "FOOD FROM OUTSIDE", "BEEN WAITING FOR YOU", "LIVED IN UNITED STATES", "YOUNG AND BEAUTIFUL", "A VERY GOOD BEHAVIOUR", "GO TO THE LIBRARY", "RESTAURENT", "A NEW CAREER IN BUISINESS", "SLEEPING WITH HIM", "PLAYING IN THE FOREST", "A TEACHER AND NOW GAVE UP", "MARRY A WILD MAN", "AT THE EARLIEST", "MARKET AND WILL BRING IT", "COUGHING IN THE HOSPITAL", "BE A BAD PERSON ", "LIVING ABROAD WITH HER", "SOME CASH TO THEM" };
        public StringBuilding()
        {
            Random random = new Random();
            int index,limit= random.Next(0,26);
            index = random.Next(0, 26);
            sb.Append(nameArray[index]);
            sb.Append(" ");
            sb.Append(verbArray[index]);
            sb.Append(" ");
            sb.Append(activityArray[index]);
        }

    }
    class InputCheck:StringBuilding//Class which accepts the user input and comparing the input to already build string
                                   //from parent class
    {
        
        public void Calculate()//calculating points
        {
            int temp = (sb.Length / time)-error;
            points += temp;
            Console.WriteLine("points="+points);
        }
        public InputCheck()//constructor for user input checking and error displaying.
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb);
            Console.ForegroundColor = ConsoleColor.Yellow;
           
            Stopwatch timer = new Stopwatch();
            timer.Start();
            userInput =Console.ReadLine();
            timer.Stop();
            time = (int)timer.ElapsedMilliseconds;
            time = time / 1000;
            //handling exceptions
            try
            {
                Console.Write("\n");
                for (int i = 0; i < sb.Length; i++)
                {
                    if (userInput[i] != sb[i])
                    {
                        error++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(userInput[i]);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(userInput[i]);
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
                Console.ForegroundColor = ConsoleColor.Green;

            }
            catch (Exception e) 
            {
                Console.WriteLine($"\n----------{e.Message}--------"); 
            }

        }
    }
    class Program
    {
        static void Main()
        {
            string choice;
            Console.WriteLine("This is a typing game you can test your keyboard skill(^_^)\nWould tou like to play(yes/no)");
            choice = Console.ReadLine();
            //accepting a choice from user to play 
            while (choice.ToUpper() != "YES" && choice.ToUpper() != "NO")
            {
                Console.WriteLine("ENTERED "+choice.ToUpper());
                Console.WriteLine("Not a valid input please enter (YES/NO)");
                choice = Console.ReadLine(); 
            }

                if (choice.ToUpper() == "YES")
            {
                Person person = new Person();
                while (choice.ToUpper() == "YES")//looping the play
                {
                    InputCheck input = new InputCheck();
                    input.Calculate();
                    Console.WriteLine("\n^^^^^^^^^^PLAY AGAIN (yes/no)^^^^^^^^^^^^");
                        choice =Console.ReadLine();
                    while (choice.ToUpper() != "YES" && choice.ToUpper() != "NO")
                    {
                        Console.WriteLine("ENTERED " + choice.ToUpper());
                        Console.WriteLine("Not a valid input please enter (YES/NO)");
                        choice = Console.ReadLine();
                    }
                }
            }
            if (choice.ToUpper()=="NO")
            {
                Console.WriteLine("THANK YOU...");
                Console.WriteLine($"\nwell played {Person.name} you got {Person.points} points ");
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }
            else
            Console.ReadLine();
        }
    }
}
