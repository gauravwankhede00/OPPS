using System;
using System.Threading.Tasks;

namespace OPPS
{
    class PracticalQuestions
    {
        static void Main()
        {
            
        }



        //private static void Palindrome()
        //{
        //    var input = Console.ReadLine();
        //    bool isEven = input.Length % 2 == 0;
        //    double mid;
        //    if (isEven)
        //    {
        //        mid = input.Length / 2;
        //    }
        //    else
        //    {
        //        double d = Double.Parse((input.Length / 2).ToString());
        //        mid = Math.Round(d);
        //    }

        //    for (double i = mid; i <= 0; i--)
        //    {
        //        input[i]
        //    }
        //}
    }

    public class TestAsync
    {
        private static string result;
        static void Main()
        {
            PrintAsync();
            Console.WriteLine(result);
        }
        static async Task<string> PrintAsync()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "This is example";
        }
    }

}
