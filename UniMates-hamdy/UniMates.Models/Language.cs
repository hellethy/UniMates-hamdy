using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        //
        //Collection navigation property
        public virtual ICollection<UserLanguage>? UserLanguages { get; set; }


    }
}
