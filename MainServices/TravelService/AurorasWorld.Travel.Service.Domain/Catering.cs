using AurorasWorld.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Travel.Service.Domain
{
    public class Catering
    {
        public Guid Id { get; set; }
        public Meals Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Travel Travel { get; set; }
        public Catering(Guid id, Meals name, decimal price, string description, Travel travel)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Travel = travel;
        }
    }
}
