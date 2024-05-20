using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Review:BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid SessionId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        // Navigation properties
        public User Student { get; set; }
        public Session session { get; set; }
    }
}
