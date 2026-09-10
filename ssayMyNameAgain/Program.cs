//Jonathan Paul
//Fall 2026
//RCET 2265
//
namespace ssayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            string UserName = "";
            Console.WriteLine("What is your name?");
            UserName = Console.ReadLine();
            if (UserName == "Emily")
            {
                Console.WriteLine($"Hello {UserName}!");
            }

            else if (UserName == "Joe")
            {
                Console.WriteLine($"Hello {UserName}!");
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
