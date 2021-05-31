using System;

namespace Basic_Programs
{
    class PrimeFactor
    {
        public void Factor()
        {
            Console.WriteLine("Enter a number to find prime factors : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.Write(2 + ",");
                number = number/2;
            }

            for (int i = 3; i*i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + ",");

                    number = number/i;
                }
            }

            if (number > 2)
            {
                Console.Write(number);
            }



        }
    }
}