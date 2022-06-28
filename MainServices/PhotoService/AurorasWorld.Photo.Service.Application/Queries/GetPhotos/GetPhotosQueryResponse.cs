using System.Collections.Generic;

namespace AurorasWorld.Photo.Service.Application.Queries.GetPhotos
{
    public class GetPhotosQueryResponse
    {
        public IEnumerable<Domain.Photo> Photos { get; }
        public GetPhotosQueryResponse(IEnumerable<Domain.Photo> photos)
        {
            Photos = photos;
        }
    }
}
