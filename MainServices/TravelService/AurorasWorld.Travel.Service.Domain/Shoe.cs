using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Travel.Service.Domain
{
    public class Shoe
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public Travel Travel { get; set; }

        public Shoe(Guid id, int size, decimal price, Travel travel)
        {
            Id = id;
            Size = size;
            Price = price;
            Travel = travel;
        }
    }
}
