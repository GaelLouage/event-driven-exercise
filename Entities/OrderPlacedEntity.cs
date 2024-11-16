using System.Runtime.CompilerServices;

public class OrderPlacedEntity
{
    public int OrderId { get; set; }
    public CustomerEntity CustomerEntity { get; set; }
    public decimal OrderTotal { get; set; }
    public DateTime TimeStamp { get; set; } = DateTime.Now;
}
