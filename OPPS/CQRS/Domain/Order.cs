using System;
using System.Collections.Generic;

namespace OPPS.CQRS.Domain
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> Items { get; set; } = new List<string>();
    }
}
