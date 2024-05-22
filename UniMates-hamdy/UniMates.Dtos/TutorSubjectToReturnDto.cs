using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Dtos
{
    public class TutorSubjectToReturnDto
    {


    
        public Guid TutorId { get; set; } = Guid.NewGuid();
        public Guid SubjectId { get; set; } = Guid.NewGuid();

    }
 
}
