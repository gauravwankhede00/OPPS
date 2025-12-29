using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS
{

    class Human
    {
     private  int UserId { get; set; }
    }
    class Student : Human
    {
        public Student()
        {
         //   UserId = 100;
        }
        // Encampsulation
        private int age;
        private int marks;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be less than or equal to zero.");
                }
            }
        }

        
        public int Mark
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Enter proper value as per bussiness rule");
                }
                else
                {
                    marks = value;
                }

            }
        }


    }


}
