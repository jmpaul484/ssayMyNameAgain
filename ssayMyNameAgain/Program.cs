//Jonathan Paul
//Fall 2026
//RCET 2265
//
using static System.Net.WebRequestMethods;

namespace ssayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            string UserName = "";
            Console.WriteLine("What is your name?");
            UserName = Console.ReadLine();
            string url = "https://www.youtube.com/watch?v=RBVSMaH_0AM";
            string displayText = "Click Here";
            if (UserName == "Emily")
            {
                Console.WriteLine($"Hello {UserName}!");
            }

            else if (UserName == "Joe")
            {
                Console.WriteLine($"Hello {UserName}!");
            }

            else if (UserName == "Jonathan")
            {
                Console.WriteLine($"Hello {UserName}! Lets get the course started!");
            }

            else if (UserName == "Tim")
            {
                string hyperlink = $"\x1B]8;;{url}\x1B\\{displayText}\x1B]8;;\x1B\\";
                Console.WriteLine($"It's {UserName}my time! {hyperlink}");
            }

            else
            {
                Console.WriteLine("Hello Human, I am trained to only respond to specific names. You are not one of them. Goodbye and never return!");
            }

            //pause
            Console.ReadLine();
        }
    }
}
