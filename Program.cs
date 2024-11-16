using EventDrivenExercise.Services;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var orderHandler = new OrderPlacedHandler();
        var orderS = new OrderService();

        orderS.OrderPlaced += orderHandler.Handle;

        orderS.PlaceOrder(1, 55M);
        
        Console.Read();
    }
}