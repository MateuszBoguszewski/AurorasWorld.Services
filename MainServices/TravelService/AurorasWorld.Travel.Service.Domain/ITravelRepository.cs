using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AurorasWorld.Travel.Service.Domain
{
    public interface ITravelRepository
    {
        Task AddAsync(Travel travel);
        Task SaveChangesAsync();
    }
}
