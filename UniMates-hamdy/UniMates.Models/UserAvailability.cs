using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models.Enums;

namespace UniMates.Models
{
    public class UserAvailability : BaseEntity
    {
       
            public Guid UserId { get; set; }
            public DateTime AvailableOn { get; set; }
            public DateTime AvailableFrom { get; set; }
            public DateTime AvailableTo { get; set; }
            public bool? IsRecurring { get; set; }
            public DateTime? RecurringStartOn { get; set; }
            public DateTime? RecurringFinishOn { get; set; }
            //enum
            public RecurringType? RecurringType { get; set; } // Assuming this can be "weekly" or "monthly", "one" ,"none"
            public int? WeekNumber { get; set; }
            public bool IsActive { get; set; }

            // Navigation property
            public User ?User { get; set; }
        


    }
}
