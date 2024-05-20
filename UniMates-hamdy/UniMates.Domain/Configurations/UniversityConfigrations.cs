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
    public class UniversityConfigrations : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(200);

            builder.HasOne(u => u.City) 
             .WithMany(city => city.Universities) 
             .HasForeignKey(u => u.CityId)
            .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
