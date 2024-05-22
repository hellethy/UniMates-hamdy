using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models.Enums;

namespace UniMates.Models
{
    public class PaymentMethod:BaseEntity
    {
        public string ?Name { get; set; }
        public Guid UserId { get; set;}
        //enum
        public MethodType MethodType { get; set; }
        public string? MethodDetails { get; set; }
        public bool IsDefault { get; set; }
        // Navigation properties
        public User ?User { get; set; }
        //Collection navigation property
        public virtual ICollection<PaymentTransaction>? Transactions { get; set; }



    }
}
