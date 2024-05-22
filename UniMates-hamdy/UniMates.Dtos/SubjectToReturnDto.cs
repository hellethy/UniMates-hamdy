using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Dtos
{
    public class SubjectToReturnDto
    {


        public string? Name { get; set; }
        public Guid FacultyId { get; set; } = Guid.NewGuid();
        public string? ProfessorName { get; set; }
        public decimal PricePerHour { get; set; }
    }
}
