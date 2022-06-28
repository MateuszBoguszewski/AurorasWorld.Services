using AurorasWorld.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Travel.Service.Domain
{
    public class Suit
    {
        public Guid Id { get; set; }
        public SuitSizes Size { get; set; }
        public decimal Price { get; set; }
        public bool Rent { get; set; }
        public Travel Travel { get; set; }

        public Suit (Guid id, SuitSizes size, decimal price, bool rent, Travel travel)
        {
            Id = id;
            Size = size;
            Price = price;
            Rent = rent;
            Travel = travel;
        }
    }
}
