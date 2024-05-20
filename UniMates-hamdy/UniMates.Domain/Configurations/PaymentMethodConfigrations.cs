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
    public class PaymentMethodConfigrations : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(pm => pm.Id); 
            builder.Property(pm => pm.Name).IsRequired().HasMaxLength(255);
            builder.Property(pm => pm.MethodType).IsRequired().HasMaxLength(50);
            builder.Property(pm => pm.MethodDetails).IsRequired().HasMaxLength(255);

            builder.HasOne(pm => pm.User)
               .WithMany(u => u.PaymentMethods)
               .HasForeignKey(pm => pm.UserId)
             .OnDelete((DeleteBehavior.NoAction));


        }
    }
}
