using System;

namespace OPPS.Abstact
{
    /*
     For loosely coupling Architecture need the abstract Class.
      abstract class cannot create object.
         abstract class can hold refrence of child class. (OPPs Principle)
         abstract class contains abstact method and Non abstact method. The abstact method it has no implementation. (Rule)
         abstract class having abstact method that has to be compulsory override in a child class.
         Abstract class also containing not abstarct method (Rule) which name as similar with child class method and we have to called child class method 
                then we have to define the virtual keyword in abstact class non Abstract (Normal) Method and Child class method need to be override.


     */
    abstract class Transformer
    {
        private Transformer()
        {
            Console.WriteLine("private CTOR initialization logic");
        }
        public Transformer(string name) : this()
        {
            Console.WriteLine("Abstract Class Constructor Called " + name);
        }

        public virtual void Show()
        {
            Console.WriteLine("Abstract Class Show Method Called");
        }

        public abstract void Run();


        static void Main()
        {
            Transformer trasformer = new Car();
            trasformer.Run();
            //trasformer.Show();


            trasformer = new Boat();
            trasformer.Run();
            //trasformer.Show();

            Console.ReadLine();
        }
    }
    class Car : Transformer
    {
        public Car() : base("Car")
        {
            Console.WriteLine("Car Class Constructor Called");
        }
        public override void Show()
        {
            Console.WriteLine("Car Show Method Called");
        }
        public override void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Boat : Transformer
    {
        public Boat() : base("Boat")
        {
            Console.WriteLine("Boat Class Constructor Called");
        }
        public override void Run()
        {
            Console.WriteLine("Boat Run");
        }

        public override void Show()
        {
            Console.WriteLine("Boat Show Method Called");
        }
    }
}
