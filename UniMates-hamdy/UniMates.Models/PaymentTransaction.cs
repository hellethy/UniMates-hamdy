using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class PaymentTransaction : BaseEntity
    {
        public Guid SessionId { get; set; }
        public Guid StudentId { get; set; }
        public Guid TutorId { get; set; }
       public Guid PaymentMethodId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        // Navigation properties
        public Session ?Session { get; set; }
        public User ?Student { get; set; }
        public User? Tutor { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

    }
}
