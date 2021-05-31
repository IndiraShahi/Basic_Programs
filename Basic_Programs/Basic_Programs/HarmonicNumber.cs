using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class HarmonicNumber
    {
        public float CheckHarmonicNum(int value)
        {
            
            float result = 1;
            for (int i = 1; i <= value; i++)
            {
                
                result += (float) 1 / i;
                //Console.WriteLine("Result is " + result); 
            }

            Console.WriteLine($"Nth Harmonic Number = {result}");
            return 0;
        }
    }
}