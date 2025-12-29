using OPPS.CQRS.Domain;
using OPPS.CQRS.Repository;

namespace OPPS.CQRS.Query.Handler
{
    public class GetOrderDetailsQueryHandler
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderDetailsQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order Handle(GetOrderDetailsQuery query)
        {
            return _orderRepository.GetById(query.OrderId);
        }
    }

}
