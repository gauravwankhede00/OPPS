using System;

namespace OPPS
{
    class UsingStatement
    {
        static void Main()
        {
            using (var obj = new MySecondClass())
            {

            }
           
            Console.ReadLine();
        }

        class MyClass : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose Method in MyClass Base Class");
            }
        }
        class MySecondClass : MyClass
        {
            public new void Dispose()
            {
                Console.WriteLine("Dispose Method in MySecondClass Child Class");
            }
        }
    }
}
