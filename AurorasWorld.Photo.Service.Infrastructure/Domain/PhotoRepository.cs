using AurorasWorld.Photo.Service.Domain;
using AurorasWorld.Photo.Service.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AurorasWorld.Photo.Service.Infrastructure.Domain
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly PhotoDbContext _dbContext;
        public PhotoRepository(PhotoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Service.Domain.Photo>> GetByDate(DateTime date)
        {
            return _dbContext.Photos.Where(p => p.Created == date).ToList();
        }
    }
}
