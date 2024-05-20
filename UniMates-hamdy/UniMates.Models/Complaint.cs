using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Complaint : BaseEntity
    {
       
        public string ?Reason { get; set; }
        public Guid SessionId { get; set; }
        public Guid StudentId { get; set; }
        public Guid TutorId { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string? Status { get; set; }
        // Navigation properties

        public Session? Session { get; set; }
        public User? Student { get; set; }
        public User? Tutor { get; set; }



      



    }
}
