using System.Collections.Generic;

namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public class Order : Entity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

    }
}
