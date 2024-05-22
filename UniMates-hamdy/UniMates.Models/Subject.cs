using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Subject : BaseEntity
    {
        public string? Name { get; set; }
 
        public Guid FacultyId { get; set; } = Guid.NewGuid();
        public string ?ProfessorName { get; set; }
        public decimal PricePerHour { get; set; }

        // Navigation properties
        public Faculty? Faculty { get; set; }

        //Collection navigation property
        public virtual ICollection<Session>? SubjectSessions { get; set; }
        public virtual ICollection<TutorSubject>? TutorSubjects { get; set; }

    }
}
