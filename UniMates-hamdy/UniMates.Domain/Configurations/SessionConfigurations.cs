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
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.StartDate).IsRequired();
            builder.Property(s => s.EndDate).IsRequired();
            builder.Property(s => s.TotalHours).IsRequired();
            builder.Property(s => s.TotalAmount).IsRequired();
            builder.Property(s => s.Status).IsRequired().HasMaxLength(50);


        

            builder.HasOne(s => s.Subject)
              .WithMany(x=>x.SubjectSessions)
              .HasForeignKey(s => s.SubjectId)
           .OnDelete((DeleteBehavior.NoAction));

       

            builder.HasOne(s => s.Tutor)
              .WithMany(u => u.SessionsAsTutor)
              .HasForeignKey(s => s.TutorId)
              .OnDelete((DeleteBehavior.NoAction));

          
        }
    }
}
