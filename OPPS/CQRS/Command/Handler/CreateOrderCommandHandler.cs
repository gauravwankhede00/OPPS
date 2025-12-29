using OPPS.CQRS.Command;
using OPPS.CQRS.Domain;
using OPPS.CQRS.Repository;
using System;

namespace OPPS.CQRS.Handler
{
    public class CreateOrderCommandHandler
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Guid Handle(CreateOrderCommand command)
        {
            var order = new Order
            {
                OrderId = Guid.NewGuid(),
                CustomerName = command.CustomerName,
                OrderDate = DateTime.UtcNow,
                Items = command.Items
            };

            _orderRepository.Save(order);
            return order.OrderId;
        }
    }

}
