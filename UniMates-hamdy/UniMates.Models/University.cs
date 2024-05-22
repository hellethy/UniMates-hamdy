using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class University: BaseEntity
    {
        public string Name { get; set; }
 
        public Guid CityId { get; set; }
        // Navigation properties
        public City ?City { get; set; }
        //Collection navigation property
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<User> Users { get; set; }


    }
}
