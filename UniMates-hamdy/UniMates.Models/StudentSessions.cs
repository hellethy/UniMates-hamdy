using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class StudentSessions: BaseEntity
    {
        public Guid SessionId { get; set; }
     

        public Guid StudentId { get; set; }
        // navigation properties
        public User? Student { get; set; }
        public Session? Session { get; set; }
    }
}
