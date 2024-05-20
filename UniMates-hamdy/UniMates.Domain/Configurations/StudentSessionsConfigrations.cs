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
    public class StudentSessionsConfigrations : IEntityTypeConfiguration<StudentSessions>
    {
        public void Configure(EntityTypeBuilder<StudentSessions> builder)
        {
            builder
            .HasKey(ss => new { ss.SessionId, ss.StudentId });

            builder
                .HasOne(ss => ss.Session)
                .WithMany(s => s.StudentSessions)
                .HasForeignKey(ss => ss.SessionId)
                .OnDelete((DeleteBehavior.NoAction));

            builder
                .HasOne(ss => ss.Student)
                .WithMany(u => u.SessionStudents)
                .HasForeignKey(ss => ss.StudentId)
                .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
