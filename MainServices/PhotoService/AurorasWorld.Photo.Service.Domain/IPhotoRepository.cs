using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AurorasWorld.Photo.Service.Domain
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetByDate(DateTime date);
    }
}
