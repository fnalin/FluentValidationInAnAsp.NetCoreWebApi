using System;

namespace FluentValidationInAnAspNetCore.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
