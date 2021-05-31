using Basic_Core;
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
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. PowerOfTWO");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Prime Factors");
            Console.WriteLine("6. Quotient Remainder");



            int programNumber = Convert.ToInt32(Console.ReadLine());

            switch (programNumber)
            {
                case 1:
                    flipcoin fc = new flipcoin();
                    fc.HeadsTailsPercentage();
                    break;
                case 2:
                    LeapYear l = new LeapYear();
                    l.year(2014);
                    break;
                case 3:
                    PowerOfTWO pow = new PowerOfTWO();
                    pow.CheckPower(30);
                    break;
                case 4:
                    HarmonicNumber hm = new HarmonicNumber();
                    hm.CheckHarmonicNum(7);
                    break;
                case 5:
                    PrimeFactor factor = new PrimeFactor();
                    factor.Factor();
                    break;
                case 6:
                    QuotientRemainder quotientRemainder1 = new QuotientRemainder();
                    quotientRemainder1.QuotientAndRemainder();
                    break;


                default:
                    Console.WriteLine("Invalid input, Please select again from given options : ");
                    Program.Main();
                    break;
            }
        }
    }
}

