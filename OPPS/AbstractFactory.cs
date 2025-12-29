using System;

namespace OPPS
{
   public class AbstractFactory
    {
        static void Main()
        {
            AbstactVehical vehical = new Tata();
            vehical.GetCar();
            vehical.GetBike();

            vehical = new Tesla();
            vehical.GetBike();
            vehical.GetCar();
            Console.ReadLine();
        }
    }

    interface ICar
    {
        void Manufacture();
    }
    interface IBike
    {
        void Manufacture();
    }

    class TATACar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("TATA CAR");
        }
    }

    class TATABike : IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("TATA Bike");
        }
    }

    class TeslaCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Tesla CAR");
        }
    }

    class TeslaBike : IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("Tesla Bike");
        }
    }

    abstract class AbstactVehical
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }

    class Tata : AbstactVehical
    {
        public override IBike GetBike()
        {
           return new TATABike();
        }

        public override ICar GetCar()
        {
            return new TATACar();
        }
    }

    class Tesla : AbstactVehical
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override ICar GetCar()
        {
            return new TeslaCar();
        }
    }
}
