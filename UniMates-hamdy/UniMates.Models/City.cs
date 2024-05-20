using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class City : BaseEntity
    {     
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        // Navigation properties
        public Country Country { get; set; }

        //Collection navigation property

        public virtual ICollection<University>? Universities { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
