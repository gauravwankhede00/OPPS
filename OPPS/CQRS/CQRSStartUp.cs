using OPPS.CQRS.Command;
using OPPS.CQRS.Handler;
using OPPS.CQRS.Query.Handler;
using OPPS.CQRS.Query;
using OPPS.CQRS.Repository;
using System;
using System.Collections.Generic;

namespace OPPS.CQRS
{
    public class CQRSStartUp
    {
        static void Main()
        {
            //Command

            IOrderRepository repository = new InMemoryOrderRepository();
            var commandHandler = new CreateOrderCommandHandler(repository);

            var createOrderCommand = new CreateOrderCommand
            {
                CustomerName = "John Doe",
                Items = new List<string> { "Item1", "Item2" }
            };

            var orderId = commandHandler.Handle(createOrderCommand);



            //Query
            var queryHandler = new GetOrderDetailsQueryHandler(repository);

            var query = new GetOrderDetailsQuery
            {
                OrderId = orderId
            };

            var order = queryHandler.Handle(query);
            Console.WriteLine($"Order for {order.CustomerName} with {order.Items.Count} items.");

        }
    }
}