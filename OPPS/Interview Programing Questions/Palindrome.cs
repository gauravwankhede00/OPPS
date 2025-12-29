using System;

namespace OPPS.Interview_Programing_Questions
{
    class Palindrome
    {
        static void Main()
        {
            string str = " The      color   of    my     car is     green     ";

           var array =  str.Trim().Split(' ');
           var aa = array[array.Length - 1].Length;

            string input = Console.ReadLine();
            bool result = IsPalindrome(input);
            if (result)
            {
                Console.WriteLine($"{input} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is not Palindrome");
            }
            Console.ReadLine();
        }
        private static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {

                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;

            }
            return true;
        }
    }
}
