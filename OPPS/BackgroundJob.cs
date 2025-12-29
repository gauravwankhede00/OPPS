using System.Threading;
using System;
using System.Threading.Tasks;

namespace OPPS
{
    class BackgroundJob
    {
        static async Task  Main()
        {


            //Thread backgroundThread = new Thread(PerformBackgroundTask);
            //backgroundThread.Start();
            Console.WriteLine("Started Main Execution " + Thread.CurrentThread.ManagedThreadId);
            await BackgroundTask();
            Console.WriteLine("Main Execution " + Thread.CurrentThread.ManagedThreadId);
           
            Console.ReadLine();
        }

        static void PerformBackgroundTask()
        {
            Console.WriteLine("Background task is running...");
            Console.WriteLine("Background Task Execution " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Background task completed.");
        }

        public static async Task BackgroundTask()
        {
            
            await Task.Delay(5000);
            Console.WriteLine("Background Task Execution  " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
