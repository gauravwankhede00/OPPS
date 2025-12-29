using System;

namespace OPPS.Interface
{
    interface ITransformer
    {
        void Run();


    }

    interface ISpiderMan
    {
        void Run();
    }

    /*
     Multi Level inheritance was not allow.
       But multiple Interface implement can implement By class. 
        Two way can Implement the Interface 
            Implesitly and Explicitly
            A class Car implement that Two Interface having  same method name and Signature (Run Method), the method Business Logic was same then you can use Implesity Implement the Interface.
                the single method was implement on the behalf of both two interface this called as Implesitly Implementation
     
           A class Car implement that Two Interface having  same method name and Signature (Run Method),but both method business logic was different then we has to implement interface explisitly.
                Both method has must be explicity Implement  was contains Interface name . Method Name > ex.  void ITransformer.Run()  and  void ISpiderMan.Run()
          
         But Method was call to be specific to that Interface reference variable was called.
            means  ITransformer transformer = new Car(); > it will called void ITransformer.Run() Method  and 
                   ISpiderMan man = new Car(); >  it will called void ISpiderMan.Run() Method
                
     */
    class Car : ITransformer, ISpiderMan
    {
        static void Main()
        {



            ITransformer transformer = new Car();
            transformer.Run();

            ISpiderMan man = new Car();
            man.Run();


            transformer = new Boat();
            transformer.Run();
            Console.ReadLine();
        }
        public Car()
        {
            Console.WriteLine("Car Constructor Called");
        }
        //public void Run()
        //{
        //    Console.WriteLine("Car Run");
        //}

        void ITransformer.Run()
        {
            Console.WriteLine("ITransformer Run car");
        }

        void ISpiderMan.Run()
        {
            Console.WriteLine("ISpiderMan Run car");
        }
    }
    class Boat : ITransformer
    {

        public void Run()
        {
            Console.WriteLine("Boat Run");
        }
    }


    interface IInterface1
    {
        int Test();
    }
    interface IInterface2
    {
        int Test();
    }

    public class TestInterface : IInterface1, IInterface2
    {
        int IInterface1.Test()
        {
            return 1;
        }

        int IInterface2.Test()
        {
            return 1;
        }
    }

}
