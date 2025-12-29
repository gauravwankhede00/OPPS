using System;

namespace OPPS
{
    class TestExample
    {

        static void Main()
        {
            Fibonacci fibonacci = new Fibonacci();

            fibonacci.GetFibonacci(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

        }
    }

    class Fibonacci
    {
        public void GetFibonacci(int number)
        {
            int num1 = 0, nextNumber = 0; int num2 = 1;
            if (number > 2)
            {
                Console.Write(num1 + " " + num2 + " ");
                for (int i = 2; i < number; i++)
                {
                    nextNumber = num1 + num2;
                    num1 = num2;
                    num2 = nextNumber;
                    Console.Write( " "+nextNumber);
                }
                
            }
            else
            {
                Console.WriteLine("Enter Greater than 2");
            }

        }
    }
    class MyClassException : Exception
    {
    }
}
