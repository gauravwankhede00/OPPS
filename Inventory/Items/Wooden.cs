using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items
{
    public class Wooden : Product
    {
        public Wooden(string name) : base(name)
        {

        }
        public string WoodenType { get; set; }
    }
}
