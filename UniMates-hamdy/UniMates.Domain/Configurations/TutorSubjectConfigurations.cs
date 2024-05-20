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
    public class TutorSubjectConfigurations : IEntityTypeConfiguration<TutorSubject>
    {
        public void Configure(EntityTypeBuilder<TutorSubject> builder)
        {
            builder.HasKey(ts => new { ts.TutorId, ts.SubjectId });

            builder.HasOne(ts => ts.Tutor)
                .WithMany(t => t.TutorSubjects)
                .HasForeignKey(ts => ts.TutorId)
                 .OnDelete((DeleteBehavior.NoAction));


            builder.HasOne(ts => ts.Subject)
                .WithMany(s => s.TutorSubjects)
                .HasForeignKey(ts => ts.SubjectId)
                 .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
