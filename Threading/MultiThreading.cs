namespace Threading
{
    class MultiThreading
    {

        static void Main()
        {

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
                    Console.WriteLine("Thread Sleep" + DateTime.Now);
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread woke up" + DateTime.Now);
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
