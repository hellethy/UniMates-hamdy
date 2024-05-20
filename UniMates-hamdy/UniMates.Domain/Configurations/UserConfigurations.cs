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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Address).HasMaxLength(255);
            builder.Property(u => u.State).HasMaxLength(100);
            builder.Property(u => u.Gender).HasMaxLength(10);
            builder.Property(u => u.ProfilePictureUrl).HasMaxLength(255);
            builder.Property(u => u.Bio).HasMaxLength(500);

            builder.HasOne(u => u.Country)
              .WithMany(x=>x.Users)
              .HasForeignKey(u => u.CountryId)
              .OnDelete((DeleteBehavior.NoAction));

            builder.HasOne(u => u.City)
            .WithMany(x => x.Users)
            .HasForeignKey(u => u.CityId)
             .OnDelete((DeleteBehavior.NoAction));

            builder.HasOne(u => u.University)
               .WithMany(x => x.Users)
               .HasForeignKey(u => u.UniversityId)
              .OnDelete((DeleteBehavior.NoAction));

            builder.HasOne(u => u.Faculty)
                   .WithMany(x => x.Users)
                   .HasForeignKey(u => u.FacultyId)
                    .OnDelete((DeleteBehavior.NoAction));


        }
    }
}
