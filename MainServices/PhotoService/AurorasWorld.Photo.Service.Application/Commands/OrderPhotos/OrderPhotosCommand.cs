using AurorasWorld.Common;
using System;
using System.Collections.Generic;

namespace AurorasWorld.Photo.Service.Application.Commands.OrderPhotos
{
    public class OrderPhotosCommand : ICommand
    {
        public Guid Id { get; set; }
        public decimal TotalCost { get; set; }
        public IEnumerable<Domain.Photo> Photos { get; set; }

        public OrderPhotosCommand(Guid id, decimal totalCost, IEnumerable<Domain.Photo> photos)
        {
            Id = id;
            TotalCost = totalCost;
            Photos = photos;
        }
    }
}
