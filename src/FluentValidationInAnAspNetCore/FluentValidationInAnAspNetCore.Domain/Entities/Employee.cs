using System;
using System.Collections.Generic;

namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public class Employee : Entity
    {
        protected Employee(){}

        public Employee(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        public Employee(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
