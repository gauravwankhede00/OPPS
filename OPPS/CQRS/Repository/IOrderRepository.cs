using OPPS.CQRS.Domain;
using System;

namespace OPPS.CQRS.Repository
{
    public interface IOrderRepository
    {
        void Save(Order order);
        Order GetById(Guid orderId);
    }

}
