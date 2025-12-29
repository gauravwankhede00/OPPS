using System;

namespace OPPS
{
    internal class DRY
    {
        //DRY principle in this example promotes code reusability and maintainability,
        //as any changes or enhancements to the multiplication logic can be made in a single place,
        //ensuring consistency throughout the codebase.

        public double GetCircleArea(double radius)
        {
            //return Math.PI * radius * radius; // In which we are repating same code again 

            return  Math.PI * Mutiplication(radius, radius);
        }

        public double GetRectangleRadius(double length, double height)
        {
            //return length * height;
            return Mutiplication(length,height);
        }

      

        private double Mutiplication(double value1, double value2)
        {

            return value1 * value2;
        }
    }
}
