using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Domain.Configurations
{
    public class UserAvailabilityConfigurations : IEntityTypeConfiguration<UserAvailability>
    {
        public void Configure(EntityTypeBuilder<UserAvailability> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(ua => ua.User)
       .WithMany(u => u.Availabilities)
       .HasForeignKey(ua => ua.UserId)
       .IsRequired()
     .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
