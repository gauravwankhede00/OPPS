using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
    class Food : Product
    {
        public Food(string name) : base(name)
        {

        }
        public DateTime ExpiryDate { get; set; }
    }
}
