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
    public class FacultyConfigrations : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired().HasMaxLength(200);

            builder.HasOne(f => f.University)
                   .WithMany(u => u.Faculties) 
                   .HasForeignKey(f => f.UniversityId)
                   .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
