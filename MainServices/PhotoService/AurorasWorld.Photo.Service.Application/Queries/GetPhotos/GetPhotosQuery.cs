using AurorasWorld.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Photo.Service.Application.Queries.GetPhotos
{
    public class GetPhotosQuery : IQuery<GetPhotosQueryResponse>
    {
        public DateTime Created { get; set; }

        public GetPhotosQuery(DateTime created)
        {
            Created = created;
        }
    }
}
