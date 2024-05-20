using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Domain.Configurations
{
    public class CityConfigrations : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(k=>k.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.HasOne(p => p.Country)
                .WithMany(p => p.Cities)
                .HasForeignKey(p => p.CountryId)
                 .OnDelete((DeleteBehavior.NoAction));
        }

    }
}
