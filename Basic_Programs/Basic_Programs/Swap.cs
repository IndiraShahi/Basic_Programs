using System;

namespace Basic_Programs
{
     class Swap
    {
        public void SwapTwoNumbers(int v1, int v2)
        {
            Console.WriteLine($"Before Swap v1 = {v1}, v2 = {v2}");
            v1 = v1 + v2;
            v2 = v1 - v2;
            v1 = v1 - v2;
            Console.WriteLine($"After Swap v1 = {v1}, v2 ={v2}");

        }
    }
}