using System;

namespace OPPS.CQRS.Query
{
    public class GetOrderDetailsQuery
    {
        public Guid OrderId { get; set; }
    }

}
