using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniMates.Domain;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Models;

namespace UniMates.Infrastructure.Repositories
{
    public class CompliantReposatory : IComplaintReposaitory
    {
        private readonly ApplicationDbContext _dbContext;

        public CompliantReposatory(ApplicationDbContext dbContext)
        {
           _dbContext = dbContext;
        }
        public async Task<IEnumerable<Complaint?>> GetAllComplaintsAsync()
        {
            return await _dbContext.Complaints.ToListAsync();
        }

        public async Task<Complaint?> GetComplaintBySesstionIdAsync(Guid sesstionId)
        {
            return await _dbContext.Complaints.FindAsync(sesstionId);
        }

        public async Task<Complaint?> GetComplaintByStudentIdAsync(Guid studentId)
        {
            return await _dbContext.Complaints.FindAsync(studentId);
        }
    }
}
