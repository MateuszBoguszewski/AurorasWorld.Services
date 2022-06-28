using System;
using static System.Net.Mime.MediaTypeNames;

namespace AurorasWorld.Photo.Service.Domain
{
    public class Photo
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public byte[] Picture { get; set; }
        public decimal Price { get; set; }
        public Photo(Guid id, DateTime created, byte[] picture, decimal price)
        {
            Id = id;
            Created = created;
            Picture = picture;
            Price = price;
        }
    }
}
