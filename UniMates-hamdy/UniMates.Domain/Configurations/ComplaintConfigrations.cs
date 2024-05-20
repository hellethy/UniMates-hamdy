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
    public class ComplaintConfigrations : IEntityTypeConfiguration<Complaint>
    {
     

        public void Configure(EntityTypeBuilder<Complaint> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Reason).IsRequired().HasMaxLength(255);
            builder.Property(c => c.ComplaintDate).IsRequired();
            builder.Property(c => c.Status).IsRequired().HasMaxLength(50);



            builder.HasOne(c => c.Session)
               .WithMany(s => s.Complaints)
               .HasForeignKey(c => c.SessionId)
                 .OnDelete((DeleteBehavior.NoAction));


            builder.HasOne(c => c.Student)
             .WithMany(x=>x.ComplaintsAsStudent) 
             .HasForeignKey(c => c.StudentId)
             .OnDelete((DeleteBehavior.NoAction)); 

        }
    }
}
