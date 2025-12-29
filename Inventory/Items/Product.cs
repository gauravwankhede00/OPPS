using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
   public  class Product
    {
        public Product(string productName)
        {
            this.ProductName = productName;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public void ShowProduct() {
            Console.WriteLine("Show Product");
        }      
    }
}
      
