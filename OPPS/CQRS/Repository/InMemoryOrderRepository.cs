using OPPS.CQRS.Domain;
using System;
using System.Collections.Generic;

namespace OPPS.CQRS.Repository
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _orders = new Dictionary<Guid, Order>();

        public void Save(Order order)
        {
            _orders[order.OrderId] = order;
        }

        public Order GetById(Guid orderId)
        {
            return _orders.TryGetValue(orderId, out var order) ? order : null;
        }
    }

}
