using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AurorasWorld.Photo.Service.Infrastructure.Domain
{
    public class PhotoEntityTypeConfiguration : IEntityTypeConfiguration<Service.Domain.Photo>
    {
        public void Configure(EntityTypeBuilder<Service.Domain.Photo> builder)
        {
            builder.ToTable("Photo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().HasMaxLength(64);
            builder.Property<DateTime>("Created").IsRequired();
            builder.Property(x => x.Picture).IsRequired();

        }
    }
}
