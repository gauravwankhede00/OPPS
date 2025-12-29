using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS
{
    class Polymorphism
    {
        /*
         I Have travel from one place to another for that I will use car, bike  and Helicoptor
           * Define the feature means car, boat, bike  and Helicoptor
           *  You have to make comunication betwween this feature i.e  car, boat, bike and Helicoptor for that you have to use base class for comunication and behaviour between this feature.
           *  Inherite the car, boat, bike and Helicoptor from base class 
          
         Main OPPs Concept
           *  OPPs Rule parent (base) class can hold refrence of of this and also its child class. 
           *  Base class as Pointer (tp)  Transformer tp = new Boat(); and base class as Veriable (Boat) 
           *  Base class as Veriable (tp)  Transformer tp = new car(); and  base class as object (Car)
           * 1) When we are creating TransFormer tp = new Car(); 
                 It will showing not all properties of class Car, It will only showing the Properties, method and Other that was as like as Base (Parent) class. 
                 Class Transformer{
                            public void Run()
                                            {
                                                Console.WriteLine("Run");
                                            }
                                 } 
                                     class Car : Transformer
                                {

                                    public string Name { get; set; }
                                }
                 TransFormer tp = new Car();   Car contains Parent Class (Transformer) run method and Class Car its own Name property.
                             as OPPS rule parent class hold reference of child class
                             tp does not contains the Name property becouse parent class it will only showing the Properties or methods that are belonging to parent (base class)
                            -- tp does not known properties method of Child class, Own Parent class doesn't  contain defination of it.
                             But Name property memory was allocated.
         
         2)  Class Transformer{
                            public void Run()
                                            {
                                                Console.WriteLine("Run Transformer");
                                            }
                                 } 
         
           class Car : Transformer
                                {

                                     public void Run()
                                            {
                                                Console.WriteLine("Run Car");
                                            }
                                }
            
           TransFormer tp = new Car();  => The tp is refrence variable of Transformer class is holding the object of Child Car class.
           and Both parent and child class contains the same method 
            What will happend it will call the Car > Run method or Transformer > Run Method ? 
           > tp is holding the referece of  TransFormer it first check any Run method in our(Transformer) class and if found it call the Run Method
           
          Virtual Method is back Up method, If in child class does not overide the method the parent class method will be called i.e.  backup method.
           if we want to call child class method, Then we have to add t cvirtual keyword in parent class method and in child class method add override keyword.
            if an parent class method add virtual keyword and child class does not add override keyword in that method. > It will execute the parent class Virtual method.
           
           *  
        */

        static void Main() {

            Transformer transformer = new Car();
            transformer.Run();
            Console.ReadLine();
        }
    }

    class Transformer // Base Class
    {

        public virtual void Run()
        {
            Console.WriteLine("Run Transformer");
        }
    }

    class Car : Transformer
    {
        public string Name { get; set; }
      new  public  void Run()
        {
            Console.WriteLine("Run Car");
        }
       
    }

    class Boat : Transformer
    {
        
    }
    class Helicoptor : Transformer
    {
        
    }
}
