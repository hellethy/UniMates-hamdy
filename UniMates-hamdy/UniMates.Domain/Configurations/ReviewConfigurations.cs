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
    public class ReviewConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Comment).HasMaxLength(500).IsRequired();
            builder.Property(r => r.Rating).IsRequired();

            builder.HasOne(r => r.session)
            .WithMany(s => s.Reviews)
            .HasForeignKey(r => r.SessionId)
                 .OnDelete((DeleteBehavior.NoAction));
            builder.HasOne(s => s.Student)
             .WithMany(x => x.ReviewsAsStudent)
             .HasForeignKey(s => s.StudentId)
          .OnDelete((DeleteBehavior.NoAction));


        }
    }
}
