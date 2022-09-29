using System;
using System.Collections.Generic;
using System.Text;

namespace TypingGame
{
    class StringBuilding:Player//Builds a string using stringbuilder functionality of CSharp,
                               //by taking inputs from 3 already declared string array.
    {
        public StringBuilder sb = new StringBuilder();
        public string userInput;
        public int error = 0, time;
        private readonly string[] nameArray = new string[] { "ARUN", "BOB", "CATHERINE", "DAVID", "ELIZABETH", "FIDA", "GIREESH", "HAMSA", "INDU", "JACK", "KIRAN", "LORENZO", "MAHESH", "NEETHU", "OSHUA", "PHILIP", "QUEEN", "RIJO", "STELLA", "TYSON", "UNUZ", "VINOD", "WOMEN", "XERCAD", "YAMUNA", "ZACK" };
        private readonly string[] verbArray = new string[] { "IS", "WAS", "WERE", "MIGHT", "MAY", "WAS", "IS", "HAS", "HAD", "HAVE", "HAS", "WHERE", "HAS", "MAY", "GOTO", "STARTED", "GOES ON", "IS", "WAS", "TENDS TO", "GIVE UP", "GOTO", "STARTED", "TENDS TO", "STILL", "GIVE UP" };
        private readonly string[] activityArray = new string[] { "PLAYING", "EATING", "ATE", "BE THERE", "WENT HOSPITAL", "A TEACHER", "STILL AN NRI", "A LAMBORGINI", "FOOD FROM OUTSIDE", "BEEN WAITING FOR YOU", "LIVED IN UNITED STATES", "YOUNG AND BEAUTIFUL", "A VERY GOOD BEHAVIOUR", "GO TO THE LIBRARY", "RESTAURENT", "A NEW CAREER IN BUSINESS", "SLEEPING IN THE CARAVAN", "PLAYING IN THE FOREST", "A TEACHER AND NOW GAVE UP", "MARRY A WILD MAN", "AT THE EARLIEST", "MARKET AND WILL BRING IT", "COUGHING IN THE HOSPITAL", "BE A BAD PERSON", "LIVING ABROAD WITH HER", "SOME CASH TO THEM" };
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
}
