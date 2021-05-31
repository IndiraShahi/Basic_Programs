using System;

namespace Basic_Programs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Some basic programs"); 
            Console.WriteLine("Enter a Program number : ");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");


            int programNumber = Convert.ToInt32(Console.ReadLine());

            switch (programNumber)
            {
                case 1:
                    flipcoin fc = new flipcoin();
                    fc.HeadsTailsPercentage();
                    break;


                default:
                    Console.WriteLine("Invalid input, Please select again from given options : ");
                    Program.Main();
                    break;
            }
        }
    }
}
