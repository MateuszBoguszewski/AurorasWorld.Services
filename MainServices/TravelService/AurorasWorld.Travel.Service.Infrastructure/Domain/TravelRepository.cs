using AurorasWorld.Travel.Service.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AurorasWorld.Travel.Service.Infrastructure.Domain
{
    public class TravelRepository : ITravelRepository
    {
        public Task AddAsync(Service.Domain.Travel travel)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
