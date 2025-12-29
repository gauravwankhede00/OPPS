using System;

namespace OPPS
{
    class GenericDelegate
    {

        public delegate double Delegate1(int x, float y, double z);
        public delegate void Delegate2(int x, float y, double z);
        public delegate bool Delegate3(string str);

        public static double Method1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void Method2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool Method3(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        static void Main()
        {
            //Func<int, float, double, double> delegate1 = (x, y, z) => x + y + z;
            //Action<int, float, double> delegate2 = (x, y, z) => Console.WriteLine(x + y + z);
            //Predicate<string> delegate3 = Method3;

            Delegate1 delegate1 = Method1;
            Delegate2 delegate2 = Method2;
            Delegate3 delegate3 = Method3;

            Console.WriteLine(delegate1(1, 2f, 3));
            delegate2(1, 2f, 3);
            Console.WriteLine(delegate3("Gaurav"));
            Console.ReadLine();
        }

    }
}
