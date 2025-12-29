using System;

namespace OPPS
{
    class VirtualMethod
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            b.Print(); //B
            c.Print(); // C

            a = new B();
            a.Print(); //B

            b = new C();
            b.Print(); //C

            Console.ReadLine();
        }
    }
    class A
    {
        public virtual void Print() { Console.WriteLine("A"); }
        public virtual int MyProperty { get; set; }
    }

    class B : A
    {
        public new virtual void Print() { Console.WriteLine("B"); }
        public override int MyProperty { get => base.MyProperty; set => base.MyProperty = value; }
    }

    class C : B
    {
        public override void Print() { Console.WriteLine("C"); }
    }
    

    
}
