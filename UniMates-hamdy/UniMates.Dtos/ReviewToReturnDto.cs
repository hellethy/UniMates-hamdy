using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Dtos
{
    public class ReviewToReturnDto
    {

        public Guid StudentId { get; set; } = Guid.NewGuid();
        public Guid SessionId { get; set; } = Guid.NewGuid();
        public string? Comment { get; set; }
        public int Rating { get; set; }
    }
}
