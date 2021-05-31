using System;

namespace Basic_Programs
{
    class CheckAlphabet
    {
        public void CheckVowel(char alphabet)
        {
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'e':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'i':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'o':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'u':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{alphabet} is a Consonent");
                    break;

            }
        }
    }
}