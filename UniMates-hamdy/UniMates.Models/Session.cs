using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Session:BaseEntity
    {
        public Guid SubjectId { get; set; } = Guid.NewGuid();
        public Guid TutorId { get; set; } = Guid.NewGuid();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalHours { get; set; }
        public decimal TotalAmount { get; set; }
        public string ?Status { get; set; }
        // Navigation properties
        public Subject ?Subject { get; set; } 
        public User ?Tutor { get; set; } 
        //Collection navigation property
        public virtual ICollection<Complaint>? Complaints { get; set; }
        public virtual ICollection<PaymentTransaction>? PaymentTransactions { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<StudentSessions>? StudentSessions { get; set; }
    }
}
