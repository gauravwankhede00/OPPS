using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OPPS
{
    public class ConcurrencyExample
    {
        private static int counter = 0;
        private static object lockObject = new object();

        public static void Main()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            Task task1 = Task.Run(() => PrintNumbers("Task 1"));
            Task task2 = Task.Run(() => PrintNumbers("Task 2"));
            Task task3 = Task.Run(() => PrintNumbers("Task 3"));

            // Wait for both tasks to complete
            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("Concurrent execution completed.");
            Console.ReadLine();
        }
        private static void PrintNumbers(string taskName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($" {Thread.CurrentThread.ManagedThreadId} {taskName}: {i}");
                Thread.Sleep(2000); // Simulate some work
            }
        }

    }

    public class ParallelismExample
    {
        private static object counter = new object();
        public static void Main()
        {
            // Create an array of numbers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Perform some operation on each number in parallel
            Parallel.ForEach(numbers, (number) =>
            {
                Console.WriteLine($"Processing number: {number}, Result : { ProcessNumber(number)}, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                // Perform some work on each number
               
            });

            Console.WriteLine("Parallel execution completed.");
            Console.ReadLine();
        }
        private static int ProcessNumber(int num)
        {
            lock (counter)
            {
                // Simulate some work by squaring the number
                Thread.Sleep(2000);
                return num * num;
            }
            
        }
        class MyClass
        {
            public int MyProperty { get; set; }
        }
        interface IInterface
        {
            void Run();
        }
        struct MyStruct
        {
            
            public int MyProperty { get; set; }
        }

   

    }
}
