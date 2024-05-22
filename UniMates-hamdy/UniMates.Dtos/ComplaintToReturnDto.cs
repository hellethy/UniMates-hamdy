using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Dtos
{
    public class ComplaintToReturnDto
    {


        public string? Reason { get; set; }
        public Guid SessionId { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; } = Guid.NewGuid();
        public Guid TutorId { get; set; } = Guid.NewGuid();
        public DateTime ComplaintDate { get; set; }
        public string? Status { get; set; }


    }
}
