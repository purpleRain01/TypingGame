using System;
using System.Diagnostics;
using System.Text;

namespace TypingGame
{
   
    class Program
    {
        static void Main()
        {
            string choice;
            int index=2,flag=0;
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
                flag = 1;
                Player person = new Player();//player class constructor called for personal details
                Menucall menucall = new Menucall();
                index=menucall.displayMenu();
                while (index != 2)
                {
                    if (index == 0)
                    {
                        menucall.UserAsk(choice);
                        index = menucall.displayMenu();
                    }
                    else if (index == 1)
                    {
                        About about = new About();
                        index = menucall.displayMenu();
                    }
                }
            }
            if (choice.ToUpper()=="NO" ||index==2)
            {
                Console.WriteLine("THANK YOU...");
                if (flag == 1) { Console.WriteLine($"\nwell played {Player.name} you got {Player.points} points "); }
                
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }
            else
            Console.ReadLine();
        }
       
    }
    class Menucall
    {
        public int displayMenu()
        {
            string[] options = { "Play", "about", "Exit" };
            Menu menu = new Menu(options);
            int index = menu.Run();
            return index;
            //Console.WriteLine("press any key to exit");
            //Console.ReadKey(true);
        }
        public void UserAsk(string ch)
        {
           string choice = ch;
            while (choice.ToUpper() == "YES")//looping the play
            {

                InputCheck input = new InputCheck();
                input.Calculate();
                Console.WriteLine("\n^^^^^^^^^^PLAY AGAIN (yes/no)^^^^^^^^^^^^");
                choice = Console.ReadLine();
                while (choice.ToUpper() != "YES" && choice.ToUpper() != "NO")
                {
                    Console.WriteLine("ENTERED " + choice.ToUpper());
                    Console.WriteLine("Not a valid input please enter (YES/NO)");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
