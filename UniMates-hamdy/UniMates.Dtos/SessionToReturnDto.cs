using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Dtos
{
    public class SessionToReturnDto
    {


        public Guid SubjectId { get; set; } = Guid.NewGuid();
        public Guid TutorId { get; set; } = Guid.NewGuid();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalHours { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
    }
}
