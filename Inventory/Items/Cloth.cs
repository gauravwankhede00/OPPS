using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
  public  class Cloth : Product
    {
      public Cloth(string name) : base(name)
      {

      }
        public string Size { get; set; }

        public void ShowProduct()
        {
            Console.WriteLine("Show Cloth");
        }
    }
}
