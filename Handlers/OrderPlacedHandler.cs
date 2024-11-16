
public class OrderPlacedHandler
{
    public  void Handle(OrderPlacedEntity orderEvent)
    {
        Console.WriteLine($"Order with ID {orderEvent.OrderId} was placed on {orderEvent.TimeStamp}");
    }
}

