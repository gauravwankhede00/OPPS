// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Thread thread = Thread.CurrentThread;
thread.Name = "main thread Gaurav";
Test1(); Test2 (); Test3 ();
Console.WriteLine("Current Thread is " + Thread.CurrentThread.Name);


static void Test1()
{
	for (int i = 0; i < 100; i++)
	{
        Console.WriteLine("Test1 "+ i);
    }
}

static void Test2()
{
    for (int i = 0; i < 100; i++)
    {
        if(i== 50)
        {
            Console.WriteLine("Thread Sleep"+DateTime.Now);
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