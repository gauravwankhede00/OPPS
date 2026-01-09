using System.Threading;
using System;
using System.Threading.Tasks;

namespace OPPS.Threading
{
    class MultiThreading_start_join
    {
        static void Main()
        {

            MultiThreading_start_join multiThreading_Start_Join = new MultiThreading_start_join();
            Thread T1 = new Thread(multiThreading_Start_Join.Display);
            Thread T2 = new Thread(multiThreading_Start_Join.Display);
            Thread T3 = new Thread(multiThreading_Start_Join.Display);

            //Thread T1 = new Thread(Test1);
            //Thread T2 = new Thread(Test2);
            //Thread T3 = new Thread(Test3);

            T1.Start(); T2.Start(); T3.Start();
            T1.Join(); T2.Join(); T3.Join();
            Console.WriteLine("Main thread completed job");
            Console.ReadLine();
        }

        public void Display()
        {
            lock (this)
            {
                Console.Write("C# is ");
                Thread.Sleep(1000);
                Console.WriteLine("Programing Language");
            }
        }
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
        }

        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Thread Sleep " + DateTime.Now);
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread woke up " + DateTime.Now);
                }
                Console.WriteLine("Test2 " + i);
            }
        }

        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
        }
    }
}
