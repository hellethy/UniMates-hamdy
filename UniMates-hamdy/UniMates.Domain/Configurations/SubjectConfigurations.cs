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
    public class SubjectConfigurations : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(200);
           

            builder.HasOne(s => s.Faculty)
                   .WithMany(f => f.Subjects)
                   .HasForeignKey(s => s.FacultyId)
                   .OnDelete((DeleteBehavior.NoAction));

        }
    }
}
