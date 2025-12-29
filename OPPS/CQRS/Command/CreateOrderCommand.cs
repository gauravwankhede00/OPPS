using System.Collections.Generic;

namespace OPPS.CQRS.Command
{
    public class CreateOrderCommand
    {
        public string CustomerName { get; set; }
        public List<string> Items { get; set; }
    }

}
