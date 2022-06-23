using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AurorasWorld.Photo.Service.Infrastructure.Domain;


namespace AurorasWorld.Photo.Service.Infrastructure.DataAccess
{
    public class PhotoDbContext : DbContext
    {
        public DbSet<Service.Domain.Photo> Photos { get; set; }

        public PhotoDbContext(DbContextOptions<PhotoDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PhotoEntityTypeConfiguration).Assembly);
        }
    }
}
