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
    public class PaymentTransactionConfigurations : IEntityTypeConfiguration<PaymentTransaction>
    {
        public void Configure(EntityTypeBuilder<PaymentTransaction> builder)
        {

            builder.HasKey(pt => pt.Id);
            builder.Property(pt => pt.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(pt => pt.TransactionDate).IsRequired();

            builder.HasOne(pt => pt.Student)
                   .WithMany(u => u.PaymentTransactionsAsStudent)
                   .HasForeignKey(pt => pt.StudentId)
                    .OnDelete((DeleteBehavior.NoAction));



            builder.HasOne(pt => pt.PaymentMethod)
                   .WithMany(pm => pm.Transactions)
                   .HasForeignKey(pt => pt.PaymentMethodId)
                 .OnDelete((DeleteBehavior.NoAction));

            builder.HasOne(pt => pt.Session)
                 .WithMany(pm => pm.PaymentTransactions)
                 .HasForeignKey(pt => pt.SessionId)
               .OnDelete((DeleteBehavior.NoAction));
        }
    }
}
