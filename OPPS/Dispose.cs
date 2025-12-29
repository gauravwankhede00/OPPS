using System;

namespace OPPS
{
    class Dispose
    {
        static void Main()
        {
            using (Employee employee = new Employee())
            {
                employee.Add(employee);
            }
            Console.WriteLine("Exited");
        }



    }
    class Employee : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("called Dispose");
        }

        public void Add(Employee employee)
        {
            Console.WriteLine("Created Employee");
        }
    }
}