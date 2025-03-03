using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("\nWelcome To The Library");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        public static void GoodbyeMessage()
        {
            Console.WriteLine("\nThank you for using the library");
        }
    }
}
