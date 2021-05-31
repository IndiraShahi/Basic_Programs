using System;

namespace Basic_Programs
{
    class LargestNumber
    {
        public void Largest(int v1, int v2, int v3)
        {
            {
                if (v1 == v2 && v2 == v3)
                    Console.WriteLine("Numbers are equal");
                if (v1 > v2 && v1 > v3)
                    Console.WriteLine($"{v1} is greatest");
                if (v2 > v1 && v2 > v3)
                    Console.WriteLine($"{v2} is greatest");
                if (v3 > v1 && v3 > v2)
                    Console.WriteLine($"{v3} is greatest");

            }
        }
    }
}