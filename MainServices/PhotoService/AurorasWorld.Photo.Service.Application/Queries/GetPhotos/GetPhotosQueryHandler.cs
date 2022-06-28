using AurorasWorld.Common;
using AurorasWorld.Photo.Service.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace AurorasWorld.Photo.Service.Application.Queries.GetPhotos
{
    public class GetPhotosQueryHandler : IQueryHandler<GetPhotosQuery, GetPhotosQueryResponse>
    {
        private readonly IPhotoRepository _photoRepository;

        public GetPhotosQueryHandler(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public async Task<GetPhotosQueryResponse> Handle(GetPhotosQuery request, CancellationToken cancellationToken)
        {
            var photos = _photoRepository.GetByDate(request.Created).Result;

            return new GetPhotosQueryResponse(photos);
        }
    }
}
