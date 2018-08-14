using System.Collections.Generic;

namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public class Product:Entity
    {
        protected Product(){}

        public Product(int id, string name, string details, int unitsInStock, decimal unitPrice)
        {
            Id = id;
            Name = name;
            Details = details;
            UnitsInStock = unitsInStock;
            UnitPrice = unitPrice;
        }

        public Product(string name, string details, int unitsInStock, decimal unitPrice)
        {
            Name = name;
            Details = details;
            UnitsInStock = unitsInStock;
            UnitPrice = unitPrice;
        }

        public string Name { get; private set; }
        public string Details { get; private set; }
        public int UnitsInStock { get; private set; }
        public decimal UnitPrice { get; private set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
