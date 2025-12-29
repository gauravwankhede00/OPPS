using System;

namespace OPPS
{
    internal static class ExtensionMethod2
    {
        private static int a = 0;
        static ExtensionMethod2()
        {
            a = 1;
        }
        public static string extensionMethod(this string stringName)
        {
            return "Hello " + stringName + a;
        }
    }

    class Test
    {
        static readonly int b = 0;
        public Test()
        {
           // b = 1;
        }
        public string GetValue()
        {
            return ExtensionMethod2.extensionMethod("Gaurav");
        }
    }

    public class Extension
    {
        static void Main()
        {
            Test test = new Test();
            Console.WriteLine(test.GetValue());
            Console.ReadLine();
        }
    }
}
