using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace OPPS.Threading
{
    class TaskWaitAllExample
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Main Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            //Method1(); Method2(); Method3();
            await Task.WhenAll(Method1Aync(), Method2Aync(), Method3Aync(), Method4Aync());
            sw.Stop();
            Console.WriteLine("Time Taken to execute this logic  " + sw.ElapsedMilliseconds);
            Console.WriteLine("Logic Ended Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        static void Method1()
        {
            Console.WriteLine("Method1 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Method1 Executed : " + Thread.CurrentThread.ManagedThreadId);
        }

        static void Method2()
        {
            Console.WriteLine("Method2 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("Method2 Executed " + Thread.CurrentThread.ManagedThreadId);
        }
        static void Method3()
        {
            Console.WriteLine("Method3 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1500);
            Console.WriteLine("Method3 Executed " + Thread.CurrentThread.ManagedThreadId);
        }

        static async Task Method1Aync()
        {
            Console.WriteLine("Method1 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(10500);
            Console.WriteLine("Method1 Executed" + +Thread.CurrentThread.ManagedThreadId);
        }

        static async Task Method2Aync()
        {
            Console.WriteLine("Method2 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(2000);
            Console.WriteLine("Method2 Executed " + Thread.CurrentThread.ManagedThreadId);
        }
        static async Task Method3Aync()
        {
            Console.WriteLine("Method3 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(7000);
            Console.WriteLine("Method3 Executed " + Thread.CurrentThread.ManagedThreadId);
        }
        static async Task Method4Aync()
        {
            Console.WriteLine("Method4 Starting on Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1700);
            Console.WriteLine("Method4 Executed " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}

