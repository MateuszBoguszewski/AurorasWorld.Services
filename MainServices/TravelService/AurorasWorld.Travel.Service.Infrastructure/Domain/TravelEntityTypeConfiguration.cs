using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AurorasWorld.Travel.Service.Infrastructure.Domain
{
    internal class TravelEntityTypeConfiguration : IEntityTypeConfiguration<Service.Domain.Travel>
    {
        public void Configure(EntityTypeBuilder<Service.Domain.Travel> builder)
        {
            builder.ToTable("Travel");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.FisrtName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property<DateTime>("TravelDate").IsRequired();
            builder.Property(x => x.PeopleAmount).IsRequired();
            builder.Property(x => x.TotalCost).IsRequired();

            builder.HasMany(s => s.Suits)
                .WithOne(t=>t.Travel)
                .HasForeignKey(s => s.Id);

            builder.HasMany(s => s.Shoes)
               .WithOne(t => t.Travel)
               .HasForeignKey(s => s.Id);

            builder.HasMany(c => c.Caterings)
                .WithOne(t => t.Travel)
                .HasForeignKey(c => c.Id);                
        }
    }
}
