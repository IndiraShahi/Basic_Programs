using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class flipcoin
    {
        public double heads = 0;
        public double tails = 0;


        public void HeadsTailsPercentage()
        {
            Console.WriteLine("Enter how many times you want to flip a coin : ");
            int flipNumber = Convert.ToInt32(Console.ReadLine());

            for (int coinFlip = 1; coinFlip <= flipNumber; coinFlip++)
            {
                Random random = new Random();
                double flipCoin = random.NextDouble();
                if (flipCoin < 0.5)
                    tails++;
                else
                    heads++;
            }
            double percentageTails = (tails * 100) / flipNumber;
            double percentageHeads = (heads * 100) / flipNumber;
            Console.WriteLine("percentage of heads and tails is : " + percentageHeads + " " + percentageTails);

        }
    }
}