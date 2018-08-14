using System.Collections.Generic;

namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public class Customer: Entity
    {
        protected Customer(){}

        public Customer(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }

        public Customer(string name, string city)
        {
            Name = name;
            City = city;
        }

        public string Name { get; private set; }
        public string City { get; private set; }

        public List<Order> Orders { get; set; } = new List<Order>();

    }
}
