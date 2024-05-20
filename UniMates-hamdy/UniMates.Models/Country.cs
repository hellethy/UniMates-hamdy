using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Country: BaseEntity
    {
        public string Name { get; set; }
        //Collection navigation property
        public virtual ICollection<City>? Cities { get; set; }
        public virtual ICollection<User>? Users { get; set; }


    }
}
