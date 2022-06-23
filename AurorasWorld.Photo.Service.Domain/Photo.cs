using System;
using static System.Net.Mime.MediaTypeNames;

namespace AurorasWorld.Photo.Service.Domain
{
    public class Photo
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public byte[] Picture { get; set; }
    }
}
