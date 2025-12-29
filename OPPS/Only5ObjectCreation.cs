using System;

namespace OPPS
{

    class SingleObjectCreation
    {
        static void Main()
        {
            var a = Only5ObjectCreation.GetInstance();
            
            var b = Only5ObjectCreation.GetInstance();
            var c = Only5ObjectCreation.GetInstance();
            var d = Only5ObjectCreation.GetInstance();
            var e = Only5ObjectCreation.GetInstance();
            Console.WriteLine("5 Instance Created");
            var f = Only5ObjectCreation.GetInstance();

        }
    }
    class Only5ObjectCreation
    {
        public static int counter = 1;
        private Only5ObjectCreation()
        {
            // Private constructor to prevent external instantiation
        }

        public static Only5ObjectCreation GetInstance()
        {
            if (counter > 5)
            {
                throw new System.Exception("Only 5 Instance should be created");
            }
            counter++;
            return new Only5ObjectCreation();

        }
    }
}
