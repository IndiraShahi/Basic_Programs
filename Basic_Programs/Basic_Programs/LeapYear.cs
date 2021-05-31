using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class LeapYear
    {
        public void year(int year)
        {
            if ((year % 4 == 0 & year % 100 != 0) | year % 400 == 0)
            {
                Console.WriteLine("Year Is leap year");
            }
            else
            {
                Console.WriteLine("Year is NOT Leap year");
            }
        }

    }
}