using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class UserLanguage : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid LanguageId { get; set; }
        // Navigation properties
        public User ?User { get; set; }
        public Language ?Language { get; set; }
    }
}
