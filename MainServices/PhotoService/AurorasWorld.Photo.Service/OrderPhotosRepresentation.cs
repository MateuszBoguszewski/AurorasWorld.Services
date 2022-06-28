using System;
using System.Collections.Generic;

namespace AurorasWorld.Photo.Service
{
    public class OrderPhotosRepresentation
    {
        public Guid Id { get; set; }
        public decimal TotalCost { get; set; }
        public IEnumerable<Domain.Photo> Photos { get; set; }

        public OrderPhotosRepresentation(Guid id, decimal totalCost, IEnumerable<Domain.Photo> photos)
        {
            Id = id;
            TotalCost = totalCost;
            Photos = photos;
        }
    }
}
