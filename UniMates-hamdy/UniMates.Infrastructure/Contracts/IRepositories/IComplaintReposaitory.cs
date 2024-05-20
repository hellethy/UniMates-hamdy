using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Models;

namespace UniMates.Infrastructure.Contracts.IRepositories
{
    public interface IComplaintReposaitory
    {
        //لو عاوز اشوف الشكاوي 
        //Task<IEnumerable<Complaint?>> GetAllComplaintsAsync();
        Task<Complaint?> GetComplaintBySesstionIdAsync(Guid sesstionId);
        Task<Complaint?> GetComplaintByStudentIdAsync(Guid studentId);
        Task<IEnumerable<Complaint?>> GetAllComplaintsAsync();


    }
}
