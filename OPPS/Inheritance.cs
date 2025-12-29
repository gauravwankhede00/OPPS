using Inventory.Items;
using System;

namespace OPPS
{
    public class Inheritance
    {

        static void Main()
        {
            Cloth cloth = new Cloth("TShirt");
            cloth.ShowProduct(); 
            // It will search for which is near, 
            //In cloth class it was near and 
            //Product class it was also contain same method but it was present in parent class
            Wooden w = new Wooden("Ply");
            w.Price = 123;
            Console.ReadLine();
        }
    }
}
