namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public class OrderDetails:Entity
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
