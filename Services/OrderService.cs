using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace EventDrivenExercise.Services
{
    public class OrderService
    {
        public event Action<OrderPlacedEntity> OrderPlaced;


        public void PlaceOrder(int orderId, decimal orderTotal)
        {
            var orderEvent = new OrderPlacedEntity
            {
                OrderId = orderId,
                OrderTotal = orderTotal,
                CustomerEntity = new CustomerEntity() 
                { 
                    Email = "lg@hotmail.com",
                    Name = "John Doe"
                }
            };
            // Raise the event
            OrderPlaced?.Invoke(orderEvent);
        }
    }
}
