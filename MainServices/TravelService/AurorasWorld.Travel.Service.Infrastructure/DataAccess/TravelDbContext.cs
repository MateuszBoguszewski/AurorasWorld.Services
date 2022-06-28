using AurorasWorld.Travel.Service.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Travel.Service.Infrastructure.DataAccess
{
    public class TravelDbContext:DbContext
    {
        public DbSet<Service.Domain.Travel> Travels { get; set; }

        public TravelDbContext(DbContextOptions<TravelDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TravelEntityTypeConfiguration).Assembly);
        }
    }
}
