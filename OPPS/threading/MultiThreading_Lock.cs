using System;
using System.Threading;

namespace OPPS.Threading
{
    class MultiThreading_Lock
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("C# is ");
                Thread.Sleep(1000);
                Console.WriteLine("Programing Language");
            }
        }
        static void Main()
        {
            MultiThreading_Lock obj = new MultiThreading_Lock();
            Thread T1 = new Thread(obj.Display);
            Thread T2 = new Thread(obj.Display);
            Thread T3 = new Thread(obj.Display);

            T1.Start(); T2.Start(); T3.Start();
            T1.Join(); T2.Join(); T3.Join();
            Console.WriteLine("Main thread completed job");
            Console.ReadLine();
        }
    }
}
